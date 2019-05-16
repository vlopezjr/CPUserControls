using CPUserControls.Services;
using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CPUserControls.AddressModule
{
    public class BLAddress
    {
        public string CustId { get; set; }
        public Address Data { get; set; }
        public bool IsDirty { get; set; }
        public string Zip4 { get; set; }
        public string Zip5 { get; set; }
        public int SalesTaxKey { get; set; }
        public decimal SalesTaxRate { get; set; }
        public string SalesTaxId { get; set; }
        public bool IsDefaultTaxSet { get; set; }
        public bool IsNew { get { return Data.Key == 0; } }
        public bool IsValidated { get; set; }
        public bool IsGovernment { get; set; }
        public bool IsSameAsPrimary { get; set; }
        public string Type { get; set; }
        public bool IsDefaultShipping { get; set; }
        public bool IsDefaultBilling { get; set; }
        public bool IsPrimaryAddress { get; set; }
        public int CustKey { get; set; }

        TaxService taxService;
        ValidationService validationService;

        public BLAddress()
        {

        }

        public BLAddress(TaxService _taxService, ValidationService _validationService)
        {
            taxService = _taxService;
            validationService = _validationService;
            Data = new Address();
        }

        internal bool ValidateAndClassify()
        {
            var address = validationService.ValidateAndClassify(this);

            this.Data.Line1 = address.Data.Line1;
            this.Data.Line2 = address.Data.Line2;
            this.Data.City = address.Data.City;
            this.Data.State = address.Data.State;
            this.Zip5 = address.Zip5;
            this.Zip4 = address.Zip4;

            if (address.IsValidated)
                return true;
            else
                return false;
        }

        internal void SetTaxSchedule()
        {
            var address = taxService.SetTaxSchedule(this, CustKey);
            this.SalesTaxId = address.SalesTaxId;
            this.SalesTaxKey = address.SalesTaxKey;
            this.SalesTaxRate = address.SalesTaxRate;
            this.IsDefaultTaxSet = address.IsDefaultTaxSet;
        }


        public void SplitZipCode()
        {
            if (Data == null)
                return;


            if (Data.Zip == null || (Data.Zip != null && Data.Zip.TrimEnd() == string.Empty))
            {
                Zip5 = "";
                Zip4 = "";
                return;
            }

            if (Data.Country != "USA")
            {
                Zip5 = Data.Zip;
                Zip4 = "";
            }
            else
            {
                Zip5 = Data.Zip.Substring(0, 5);

                if (Data.Zip.Length > 5)
                    Zip4 = Data.Zip.Substring(5);
                else
                    Zip4 = "";
            }
        }

        public void CombineZip5AndZip4()
        {
            if (string.IsNullOrEmpty(Zip4) && !string.IsNullOrEmpty(Zip5))
                Data.Zip = Zip5;
            else
                Data.Zip = Zip5 + Zip4;
        }

        public void SetZip5Only()
        {
            Data.Zip = Zip5;
        }


        public void GenerateCustID()
        {
            string companyName = Data.Name.ToUpper();
            string zip = Zip5;

            string custId = "";

            //remove the
            var nameWithoutThe = companyName.Replace("THE", "");
            var rgx = new Regex("[^a-zA-Z0-9]");

            //remove special characters
            var nameWithoutSymbols = rgx.Replace(nameWithoutThe, "");

            //do first 5 letters + zip code
            if (nameWithoutSymbols.Length > 5)
                custId = nameWithoutSymbols.Substring(0, 5) + zip;
            else
                custId = nameWithoutSymbols.Substring(0, nameWithoutSymbols.Length) + zip;


            string existingCustId = "";

            if (CustKey != 0) //customer has an existing cust ID
            {
                existingCustId = new CustomerService().LoadCustomer(CustKey).Id;

                string custIdWithoutDifferentiator = existingCustId.TrimEnd().Substring(0, 10);

                if (custId == custIdWithoutDifferentiator)
                {
                    CustId = existingCustId;
                    return;
                }
            }

            //check against existing cust ids
            var matchTuple = new CustomerService().SearchByCustId(custId);
            if (matchTuple != null)
            {
                int largestExistingDifferentiator = 0;
                string matchId = matchTuple.Item1;

                if (matchId.Contains("-"))
                {
                    largestExistingDifferentiator = Convert.ToInt32(matchId.Substring(matchId.Length - 1));
                }

                int differentiator = largestExistingDifferentiator + 1;
                custId = string.Format("{0}-{1}", custId, differentiator);
            }

            CustId = custId;
        }
    }
}
