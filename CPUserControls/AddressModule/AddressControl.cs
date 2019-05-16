using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPUserControls.CASalesTax;
using CPUserControls.UPSOnline;
using CPUserControls.WASalesTax;
using CreateCustomer.API.DomainServices;
using CreateCustomer.API.Entities;

namespace CPUserControls.AddressModule
{
    public partial class AddressControl : UserControl
    {
        public delegate void DoneEventHandler(BLAddress address);
        public event DoneEventHandler Done = delegate { };

        public delegate void StatusChangedEventHandler(Color statusColor, string statusMessage);
        public event StatusChangedEventHandler StatusChanged = delegate { };

        public event Action Invalid = delegate { };
        public event Action EnterPressed = delegate { };
        public event Action FormCleared = delegate { };

        public bool IsValid { get { containerValidator.Validate(); return containerValidator.IsValid() && address.SalesTaxKey != 0; } }

        public string CoName { get; set; }
        public string AddrName { get; set; }
        public string ZipCode { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int TaxKey { get; set; }
        public short Residential { get; set; }
        public string CustId { get; set; }
        public bool IsGovernment { get; set; }
        public int CustKey { get; set; }

        private BLAddress address;


        public AddressControl()
        {
            InitializeComponent();
        }



        #region PUBLIC METHODS
        public void HideStatus()
        {
            StatusTextBox.Visible = false;
        }

        public void HideCustId()
        {
            lblCustId.Visible = false;
            txtCustId.Visible = false;
        }


        public override void Refresh()
        {
            btnOverride.Enabled = false;
            SetAddressProperties();
            PopulateStateComboBox();
            SetFormToCurrentAddress();
            SetZipCodeRegex();
            containerValidator.Validate();
            base.Refresh();
        }

        public void ValidateControls()
        {
            containerValidator.Validate();
        }

        #endregion


        private void SetZipCodeRegex()
        {
            if (cboCountry.Text != null && cboCountry.Text != "USA")
                regexZip.ValidationExpression = "^.*$";
            else
                regexZip.ValidationExpression = "^\\d{5}$";
        }


        private void SetFormStatus(Color labelColor, string statusMessage)
        {
            StatusTextBox.ForeColor = labelColor;
            StatusTextBox.Text = statusMessage;

            StatusChanged(labelColor, statusMessage);
        }



        private List<string> countryNames;





        private void AddressControl_Load(object sender, EventArgs e)
        {
            //poor man's dependency injection
            address = new BLAddress(new Services.TaxService(), new Services.ValidationService());


            SetAddressProperties();
            PopulateStateComboBox();
            PopulateCountryComboBox();
            SetFormToCurrentAddress();

            if (address.SalesTaxKey != 0 && containerValidator.IsValid())
                SetFormStatus(Color.Green, "Address has been validated and sales tax is set!");
            else
                SetFormStatus(Color.Red, "Please enter the billing address.");


            SetZipCodeRegex();

            containerValidator.Validate();
        }

        private void PopulateCountryComboBox()
        {
            UnsubscribeToStateChanged();

            countryNames = countryNames ?? ZoneGenerator.GenerateCountryIDs();
            if (cboCountry.Items.Count == 0)
                cboCountry.DataSource = countryNames;

            SubscribeToStateChanged();
        }



        private void PopulateStateComboBox()
        {
            UnsubscribeToStateChanged();

            var states = ZoneGenerator.GenerateStateIDsByCountry(address.Data.Country);

            cboState.Items.Clear();            
            states.ForEach(c => cboState.Items.Add(c));
            cboState.Items.Insert(0, "");

            SubscribeToStateChanged();
        }

        private void SetAddressProperties()
        {
            if (string.IsNullOrEmpty(AddrName))
                address.Data.Name = CoName ?? "";
            else
                address.Data.Name = AddrName;

            address.CustId = CustId;
            address.Data.Line1 = Line1 ?? "";
            address.Data.Line2 = Line2 ?? "";
            address.Data.City = City ?? "";
            address.Data.State = State ?? "";
            address.Data.Residential = Residential;
            address.Data.Zip = ZipCode ?? "";
            address.Data.Country = string.IsNullOrEmpty(Country) ? "USA" : Country;
            address.SalesTaxKey = TaxKey;
            address.IsGovernment = IsGovernment;
            address.CustKey = CustKey;

            address.SplitZipCode();
        }

        private void SetFormToCurrentAddress()
        {
            UnsubscribeToStateChanged();

            txtName.Text = address.Data.Name;
            txtLine1.Text = address.Data.Line1;
            txtLine2.Text = address.Data.Line2;
            txtCity.Text = address.Data.City;
            SetState();
            txtZip5.Text = address.Zip5;
            txtZip4.Text = address.Zip4;
            txtCustId.Text = address.CustId;
            CheckGovernment();
            SelectCountry();
            SetClassification();


            SubscribeToStateChanged();
        }

        private void SetClassification()
        {
            if (address.SalesTaxKey == 0)
                txtClassification.Text = "";
            else if (address.Data.Residential == 1)
                txtClassification.Text = "Residential";
            else
                txtClassification.Text = "Commercial";
        }

        private void SetState()
        {
            var states = ZoneGenerator.GenerateStateIDsByCountry(address.Data.Country);
            var index = states.FindIndex(c => c.TrimEnd() == address.Data.State);
            if (index != -1)
            {
                cboState.SelectedIndex = index + 1; //make up for empty option
            }
            else
            {
                cboState.SelectedIndex = 0;
            }
        }

        private void CheckGovernment()
        {
            if (address.SalesTaxKey == 172)
                chkGovernment.Checked = true;
            else
                chkGovernment.Checked = address.IsGovernment;
        }

        private void SelectCountry()
        {
            countryNames = countryNames ?? ZoneGenerator.GenerateCountryIDs();

            if (cboCountry.Items.Count == 0)
                cboCountry.DataSource = countryNames;

            var index = countryNames.FindIndex(c => c.Contains(address.Data.Country));
            if (index != -1)
            {
                cboCountry.SelectedIndex = index;
            }
            else
            {
                cboCountry.Text = address.Data.Country;
            }
        }






        public void ClearForm()
        {
            address.CustId = "";
            address.Data.Name = "";
            address.Data.Line1 = "";
            address.Data.Line2 = "";
            address.Data.City = "";
            address.Data.State = "";
            address.Data.Country = "USA";
            address.SalesTaxId = "";
            address.SalesTaxKey = 0;
            address.SalesTaxRate = 0;
            address.IsDirty = false;
            address.IsValidated = false;
            address.Data.Zip = "";
            address.Zip5 = "";
            address.Zip4 = "";

            UnsubscribeToStateChanged();

            txtName.Clear();
            txtLine1.Clear();
            txtLine2.Clear();
            txtCity.Clear();
            cboState.SelectedIndex = 0;
            txtZip5.Clear();
            txtZip4.Clear();
            txtCustId.Clear();
            chkGovernment.Checked = false;
            cboCountry.SelectedIndex = countryNames.FindIndex(c => c.Contains("USA"));
            txtClassification.Clear();

            SubscribeToStateChanged();

            SetFormStatus(Color.Red, "Address not yet validated..");
            containerValidator.Validate();
            txtName.Focus();
            FormCleared();
        }

        private void btnOverride_Click(object sender, EventArgs e)
        {
            address.SetTaxSchedule();
            address.CombineZip5AndZip4();
            SetFormToCurrentAddress();

            CheckStatusAndRaiseDoneOrInvalidEvent();
        }






        #region VALIDATION
        private void btnValidateAddress_Click(object sender, EventArgs e)
        {
            if (address.IsDirty)
            {
                Cursor = Cursors.WaitCursor;

                if (address.ValidateAndClassify())
                {
                    address.GenerateCustID();
                    address.CombineZip5AndZip4();
                    address.SetTaxSchedule();

                    SetFormToCurrentAddress();

                    containerValidator.Validate();

                    btnOverride.Enabled = true;
                }
                else
                {
                    address.GenerateCustID();
                    address.SetTaxSchedule();
                    address.SetZip5Only();

                    SetFormToCurrentAddress();
                }

                CheckStatusAndRaiseDoneOrInvalidEvent();

                Cursor = Cursors.Default;
            }
            else if (address.SalesTaxKey != 0 && containerValidator.IsValid())
            {
                SetFormStatus(Color.Green, "Address has been validated and sales tax is set!");
            }
        }

        private void CheckStatusAndRaiseDoneOrInvalidEvent()
        {
            if (!containerValidator.IsValid())
            {
                SetFormStatus(Color.Red, "Address could not be found with UPS service. Form is invalid.");
                Invalid();
            }
            else if (!address.IsValidated && address.SalesTaxKey != 0 && !address.IsDefaultTaxSet && containerValidator.IsValid())
            {
                SetFormStatus(Color.DarkOrange, "Address could not be found with UPS service. Default tax rate set.");
                Done(address);
            }
            else if (address.IsValidated && address.SalesTaxKey != 0 && !address.IsDefaultTaxSet && containerValidator.IsValid())
            {
                SetFormStatus(Color.Green, "Address is validated and sales tax is set!");
                Done(address);
            }
            else if (!address.IsValidated && address.SalesTaxKey != 0 && address.IsDefaultTaxSet && containerValidator.IsValid())
            {
                SetFormStatus(Color.DarkOrange, "Address could not be found with UPS service. Default tax rate set.");
                Done(address);
            }
            else if (address.SalesTaxKey == 0)
            {
                SetFormStatus(Color.Red, "Sales tax could not be set. Please check address and try again.");
                Invalid();
            }
        }

        private void cboState_Leave(object sender, EventArgs e)
        {
            var index = ZoneGenerator.GenerateStateIDsByCountry(address.Data.Country).FindIndex(c => c.TrimEnd() == cboState.Text.TrimEnd().ToUpper());
            if (index != -1)
            {
                cboState.SelectedIndex = index + 1;
                cvState.Validate();
            }
        }

        private void cvState_Validating(object sender, Genghis.Windows.Forms.CustomValidator.ValidationCancelEventArgs e)
        {
            var states = ZoneGenerator.GenerateStateIDsByCountry(address.Data.Country);

            var stateFound = states.FirstOrDefault(c => c.TrimEnd() == cboState.Text.TrimEnd());
            e.Valid = stateFound != null;
        }

        private void cvCountry_Validating(object sender, Genghis.Windows.Forms.CustomValidator.ValidationCancelEventArgs e)
        {
            var countryFound = countryNames.FirstOrDefault(c => c.Contains(cboCountry.Text.TrimEnd()));
            e.Valid = countryFound != null;
        }
        #endregion




        #region CONTROL STATECHANGED
        private void ResetBLAddressProperties()
        {
            address.IsDirty = true;
            address.IsValidated = false;
            address.SalesTaxKey = 0;
            address.SalesTaxId = "";
            address.SalesTaxRate = 0;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            address.Data.Name = txtName.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void txtLine1_TextChanged(object sender, EventArgs e)
        {
            address.Data.Line1 = txtLine1.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void txtLine2_TextChanged(object sender, EventArgs e)
        {
            address.Data.Line2 = txtLine2.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
            address.Data.City = txtCity.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void txtZip5_TextChanged(object sender, EventArgs e)
        {
            address.Zip5 = txtZip5.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void txtZip4_TextChanged(object sender, EventArgs e)
        {
            address.Zip4 = txtZip4.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void cboState_TextChanged(object sender, EventArgs e)
        {
            address.Data.State = cboState.Text.TrimEnd().ToUpper();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void cboCountry_TextChanged(object sender, EventArgs e)
        {
            address.Data.Country = cboCountry.Text.TrimEnd();
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");

            PopulateStateComboBox();

            if (!cvState.IsValid)
                cvState.Validate();

            SetZipCodeRegex();
            regexZip.Validate();
        }

        private void chkGovernment_CheckedChanged(object sender, EventArgs e)
        {
            address.IsGovernment = chkGovernment.Checked;
            ResetBLAddressProperties();
            Invalid();
            SetFormStatus(Color.Red, "Must validate before before proceeding..");
        }

        private void SubscribeToStateChanged()
        {
            txtName.TextChanged += txtName_TextChanged;
            txtLine1.TextChanged += txtLine1_TextChanged;
            txtLine2.TextChanged += txtLine2_TextChanged;
            txtCity.TextChanged += txtCity_TextChanged;
            cboState.TextChanged += cboState_TextChanged;
            cboCountry.TextChanged += cboCountry_TextChanged;
            txtZip5.TextChanged += txtZip5_TextChanged;
            txtZip4.TextChanged += txtZip4_TextChanged;
            chkGovernment.CheckedChanged += chkGovernment_CheckedChanged;
        }

        private void UnsubscribeToStateChanged()
        {
            txtName.TextChanged -= txtName_TextChanged;
            txtLine1.TextChanged -= txtLine1_TextChanged;
            txtLine2.TextChanged -= txtLine2_TextChanged;
            txtCity.TextChanged -= txtCity_TextChanged;
            cboState.TextChanged -= cboState_TextChanged;
            cboCountry.TextChanged -= cboCountry_TextChanged;
            txtZip5.TextChanged -= txtZip5_TextChanged;
            txtZip4.TextChanged -= txtZip4_TextChanged;
            chkGovernment.CheckedChanged -= chkGovernment_CheckedChanged;
        }

        #endregion




        #region ENTER PRESSED / VALIDATE ACTION ON KEYUP
        //-------------------------KEYUP---------------------------
        private void ValidateNavigateOnKeyUp(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (address.IsValidated)
                    EnterPressed();
                else
                    btnValidateAddress.PerformClick();
            }

            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.Z)
            {
                txtZip5.Focus();
                txtZip5.SelectAll();
            }
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtLine1_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtLine2_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtZip5_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtZip4_KeyDown(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtCity_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtState_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }

        private void txtZip4_KeyUp(object sender, KeyEventArgs e)
        {
            ValidateNavigateOnKeyUp(e);
        }
        #endregion
    }
}
