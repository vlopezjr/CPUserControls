using CPUserControls.AddressModule;
using CPUserControls.CASalesTax;
using CPUserControls.UPSOnline;
using CPUserControls.WASalesTax;
using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUserControls.Services
{
    public class TaxService
    {
        private CustomerService service;
        private CATaxRateAPISoapClient caTaxProxy;
        private serviceSoapClient waTaxProxy;

        public TaxService()
        {
            service = new CustomerService();
            caTaxProxy = new CATaxRateAPISoapClient();
            waTaxProxy = new serviceSoapClient();
        }


        BLAddress address;
        int custKey;

        private Customer GetCustomerForEmailSender()
        {
            return service.LoadCustomer(custKey);
        }

        internal BLAddress SetTaxSchedule(BLAddress _address, int _custKey)
        {
            address = _address;
            custKey = _custKey;

            if (address.IsGovernment)
            {
                GetGovernmentTaxSchedule();
                return address;
            }

            switch (address.Data.State)
            {
                case "CA":
                    GetCATaxSchedule();
                    break;

                case "WA":
                    GetWATaxSchedule();
                    break;

                case "MO":
                    GetMOTaxSchedule();
                    break;

                default:
                    GetTaxByCountry();
                    break;
            }

            return address;
        }


        private void GetTaxByCountry()
        {
            if (address.Data.Country == "USA")
            {
                GetInterstateTaxSchedule();
            }
            else
            {
                GetInternationalTaxSchedule();
            }
        }

        private void GetGovernmentTaxSchedule()
        {
            address.SalesTaxId = Properties.Settings.Default.GOVTaxId;
            address.SalesTaxKey = Properties.Settings.Default.GOVTaxKey;
            address.SalesTaxRate = Properties.Settings.Default.GovTaxRate;

            address.IsDefaultTaxSet = false;
        }

        private void GetInternationalTaxSchedule()
        {
            address.SalesTaxId = Properties.Settings.Default.INTLTaxId;
            address.SalesTaxKey = Properties.Settings.Default.INTLTaxKey;
            address.SalesTaxRate = Properties.Settings.Default.INTLTaxRate;

            address.IsDefaultTaxSet = true;
        }

        private void GetInterstateTaxSchedule()
        {
            address.SalesTaxId = Properties.Settings.Default.ISTATETaxId;
            address.SalesTaxKey = Properties.Settings.Default.ISTATETaxKey;
            address.SalesTaxRate = Properties.Settings.Default.ISTATETaxRate;

            address.IsDefaultTaxSet = false;
        }


        private void GetCATaxSchedule()
        {
            string _taxRate = "";
            string _county = "";
            string _jurisdiction = "";
            try
            {
                int result = caTaxProxy.GetTaxRate(address.Data.Line1, address.Data.City, address.Zip5, ref _taxRate, ref _county, ref _jurisdiction);
                if (result == -1)
                {
                    //send email and apply default tax rate from config file
                    address.SalesTaxId = Properties.Settings.Default.MPKTaxId;
                    address.SalesTaxKey = Properties.Settings.Default.MPKTaxKey;
                    address.SalesTaxRate = Properties.Settings.Default.MPKTaxRate;

                    EmailSender.EmailSalesTaxServiceFailure("CA", address, GetCustomerForEmailSender());
                    address.IsDefaultTaxSet = true;
                }
                else
                {
                    if (_jurisdiction.Contains("UNINCORPORATED"))
                    {
                        //find by county
                        var taxTuple = service.GetCATaxScheduleByCounty(_county);

                        address.SalesTaxKey = taxTuple.Item1;
                        address.SalesTaxId = taxTuple.Item2;
                        address.SalesTaxRate = Convert.ToDecimal(taxTuple.Item3);

                        address.IsDefaultTaxSet = false;
                    }
                    else
                    {
                        //find by city
                        var taxTuple = service.GetCATaxScheduleByCity(_jurisdiction);

                        if (taxTuple.Item1 != 0)
                        {
                            //succeeded by city
                            address.SalesTaxKey = taxTuple.Item1;
                            address.SalesTaxId = taxTuple.Item2;
                            address.SalesTaxRate = Convert.ToDecimal(taxTuple.Item3);

                            address.IsDefaultTaxSet = false;
                        }
                        else
                        {
                            //failed by city - attempt by county
                            taxTuple = service.GetCATaxScheduleByCounty(_county);
                            //taxTuple = new Tuple<int, string, string>(0, "", "");

                            if (taxTuple.Item1 != 0)
                            {
                                //succeeded by county
                                address.SalesTaxKey = taxTuple.Item1;
                                address.SalesTaxId = taxTuple.Item2;
                                address.SalesTaxRate = Convert.ToDecimal(taxTuple.Item3);

                                address.IsDefaultTaxSet = false;
                            }
                            else //failed to find by county 
                            {
                                //send email and apply default tax rate from config file
                                address.SalesTaxId = Properties.Settings.Default.MPKTaxId;
                                address.SalesTaxKey = Properties.Settings.Default.MPKTaxKey;
                                address.SalesTaxRate = Properties.Settings.Default.MPKTaxRate;

                                EmailSender.EmailSalesTaxServiceFailure("CA", address, GetCustomerForEmailSender());
                                address.IsDefaultTaxSet = true;
                            }
                        }
                    }
                }
            }
            catch
            {
                //send email and apply default tax rate from config file
                address.SalesTaxId = Properties.Settings.Default.MPKTaxId;
                address.SalesTaxKey = Properties.Settings.Default.MPKTaxKey;
                address.SalesTaxRate = Properties.Settings.Default.MPKTaxRate;

                EmailSender.EmailSalesTaxServiceFailure("CA", address, GetCustomerForEmailSender());
                address.IsDefaultTaxSet = true;
            }
        }


        private void GetWATaxSchedule()
        {
            try
            {
                var locCode = "";
                var result = waTaxProxy.GetLocCode(address.Data.Line1, address.Data.City, address.Zip5, ref locCode);
                if (result < 3)
                {
                    var taxTuple = service.GetWATaxScheduleByLocationCode(locCode);
                    //var taxTuple = new Tuple<int, string, string>(0, "", "");

                    if (taxTuple.Item1 != 0)
                    {
                        address.SalesTaxKey = taxTuple.Item1;
                        address.SalesTaxId = taxTuple.Item2;
                        address.SalesTaxRate = Convert.ToDecimal(taxTuple.Item3);

                        address.IsDefaultTaxSet = false;
                    }
                    else
                    {
                        address.SalesTaxKey = Properties.Settings.Default.SEATaxKey;
                        address.SalesTaxId = Properties.Settings.Default.SEATaxId;
                        address.SalesTaxRate = Properties.Settings.Default.SEATaxRate;

                        address.IsDefaultTaxSet = true;
                        EmailSender.EmailSalesTaxServiceFailure("WA", address, GetCustomerForEmailSender());
                    }
                }
                //0: adress was found
                //1 address not found but zip4 was located
                //2 neither address or zip4 found but zip5 was located

                //3: address and zip not found
                //4: invalid arguments
                //5: internal errror
            }
            catch
            {
                address.SalesTaxKey = Properties.Settings.Default.SEATaxKey;
                address.SalesTaxId = Properties.Settings.Default.SEATaxId;
                address.SalesTaxRate = Properties.Settings.Default.SEATaxRate;

                address.IsDefaultTaxSet = true;
                EmailSender.EmailSalesTaxServiceFailure("WA", address, GetCustomerForEmailSender());
            }

        }


        private void GetMOTaxSchedule()
        {
            var taxTuple = service.GetTaxScheduleByZip(address.Zip5);

            if (taxTuple.Item1 != 0)
            {
                address.SalesTaxKey = taxTuple.Item1;
                address.SalesTaxId = taxTuple.Item2;
                address.SalesTaxRate = Convert.ToDecimal(taxTuple.Item3);

                address.IsDefaultTaxSet = false;
            }
            else
            {
                address.SalesTaxKey = Properties.Settings.Default.STLTaxKey;
                address.SalesTaxId = Properties.Settings.Default.STLTaxId;
                address.SalesTaxRate = Properties.Settings.Default.STLTaxRate;

                address.IsDefaultTaxSet = true;
                EmailSender.EmailSalesTaxServiceFailure("WA", address, GetCustomerForEmailSender());
            }
        }


    }
}
