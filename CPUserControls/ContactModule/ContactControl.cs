using System;
using System.Drawing;
using System.Windows.Forms;
using CreateCustomer.API.Entities;

namespace CPUserControls.ContactModule
{
    public partial class ContactControl : UserControl
    {
        //PUBLIC EVENTS
        public delegate void DoneEventHandler(Contact contact);
        public event DoneEventHandler Done = delegate { };

        public delegate void StatusChangedEventHandler(Color statusColor, string statusMessage);
        public event StatusChangedEventHandler StatusChanged = delegate { };

        public event Action Invalid = delegate { };
        public event Action EnterPressed = delegate { };

        //PUBLIC FIELDS
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Cell { get; set; }
        public string Fax { get; set; }
        public string PhoneExt { get; set; }
        public string FaxExt { get; set; }
        public bool CurrentContactIsDirty
        {
            get
            {
                return contact == null ? false : contact.IsDirty;
            }
            set
            {
                if (contact != null)
                    contact.IsDirty = value;
            }
        }

        public bool IsValid()
        {
            return containerValidator.IsValid();
        }


        //PRIVATE OBJECT
        private Contact contact;


        //CONSTRUCTOR
        public ContactControl()
        {
            InitializeComponent();
        }




        //PUBLIC FUNCTIONS
        public void HideStatus()
        {
            groupBoxStatus.Visible = false;
            lblStatus.Visible = false;
        }

        public void EnableDisableForm(bool state)
        {
            txtName.Enabled = state;
            txtEmail.Enabled = state;
            txtPhone.Enabled = state;
            txtPhoneExt.Enabled = state;
            txtFax.Enabled = state;
            txtFaxExt.Enabled = state;
            txtMobile.Enabled = state;
            txtTitle.Enabled = state;
        }

        public bool ValidateManually()
        {
            containerValidator.Validate();
            return containerValidator.IsValid();
        }

        public void HighlightEmail()
        {
            txtEmail.Focus();
            txtEmail.BackColor = Color.Yellow;

            var tm = new Timer();
            tm.Interval = 800;
            tm.Tick += (s, ei) => { txtEmail.BackColor = Color.White; };
            tm.Start();
        }

        public void ClearForm()
        {
            UnsubscribeToTextChanged();
            txtName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtPhoneExt.Clear();
            txtFax.Clear();
            txtFaxExt.Clear();
            txtMobile.Clear();
            txtTitle.Clear();
            SubscribeToTextChanged();

            SetStatus(Color.Red, "");
        }

        public override void Refresh()
        {
            contact = new Contact();

            SetContactProperties();
            SetTextBoxes();
            containerValidator.Validate();
            base.Refresh();

            StatusChanged(Color.Green, "");
        }

        public void SetStatus(Color labelColor, string statusMessage)
        {
            lblStatus.ForeColor = labelColor;
            lblStatus.Text = statusMessage;

            StatusChanged(labelColor, statusMessage);
        }

        public void CreateNewContact()
        {
            contact = new Contact();
        }





        //CONTROL LOAD
        private void ContactControl_Load(object sender, EventArgs e)
        {
            contact = new Contact();

            SetContactProperties();
            SetTextBoxes();

            if (containerValidator.IsValid())
                SetFormStatus(Color.Green, "All fields are valid.");
            else
                SetFormStatus(Color.Red, "Please fix errors before proceeding");

            containerValidator.Validate();
        }

        private void SetTextBoxes()
        {
            UnsubscribeToTextChanged();
            txtName.Text = contact.Name;
            txtEmail.Text = contact.Email;
            txtTitle.Text = contact.Title;
            txtPhone.Text = contact.Phone;
            txtPhoneExt.Text = contact.PhoneExt;
            txtFax.Text = contact.Fax;
            txtFaxExt.Text = contact.FaxExt;
            txtMobile.Text = contact.MobilePhone;
            SubscribeToTextChanged();
        }

        private void SetContactProperties()
        {
            contact.Name = FullName ?? "";
            contact.Email = Email ?? "";
            contact.Phone = Phone ?? "";
            contact.PhoneExt = PhoneExt ?? "";
            contact.Fax = Fax ?? "";
            contact.FaxExt = FaxExt ?? "";
            contact.MobilePhone = Cell ?? "";
            contact.Title = Title ?? "";
        }

        private void SetFormStatus(Color labelColor, string statusMessage)
        {
            lblStatus.ForeColor = labelColor;
            lblStatus.Text = statusMessage;

            StatusChanged(labelColor, statusMessage);
        }




        //TEXTCHANGED
        private void UnsubscribeToTextChanged()
        {
            txtName.TextChanged -= txtName_TextChanged;
            txtEmail.TextChanged -= txtEmail_TextChanged;
            txtPhone.TextChanged -= txtPhone_TextChanged;
            txtFax.TextChanged -= txtFax_TextChanged;
            txtMobile.TextChanged -= txtMobile_TextChanged;
            txtPhoneExt.TextChanged -= txtPhoneExt_TextChanged;
            txtFaxExt.TextChanged -= txtFaxExt_TextChanged;
            txtTitle.TextChanged -= txtTitle_TextChanged;
        }

        private void SubscribeToTextChanged()
        {
            txtName.TextChanged += txtName_TextChanged;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtPhone.TextChanged += txtPhone_TextChanged;
            txtFax.TextChanged += txtFax_TextChanged;
            txtMobile.TextChanged += txtMobile_TextChanged;
            txtPhoneExt.TextChanged += txtPhoneExt_TextChanged;
            txtFaxExt.TextChanged += txtFaxExt_TextChanged;
            txtTitle.TextChanged += txtTitle_TextChanged;
        }

        private void RaiseDoneOrInvalidEvent()
        {
            if (containerValidator.IsValid())
            {
                Done(contact);
                SetFormStatus(Color.Green, "Contact is valid.");
            }
            else
            {
                Invalid();
                SetFormStatus(Color.Red, "Please fix errors before proceeding");
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            contact.Name = txtName.Text.TrimEnd();
            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            contact.Email = txtEmail.Text.TrimEnd();
            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            contact.Title = txtTitle.Text.TrimEnd();
            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            var cleanPhone = txtPhone.Text.Replace(" ", "");
            contact.Phone = cleanPhone;
            txtPhone.Text = cleanPhone;

            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtFax_TextChanged(object sender, EventArgs e)
        {
            var cleanFax = txtFax.Text.Replace(" ", "");
            contact.Fax = cleanFax;
            txtFax.Text = cleanFax;

            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            var cleanPhone = txtMobile.Text.Replace(" ", "");
            contact.MobilePhone = cleanPhone;
            txtMobile.Text = cleanPhone;

            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtPhoneExt_TextChanged(object sender, EventArgs e)
        {
            contact.PhoneExt = txtPhoneExt.Text.TrimEnd();
            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }

        private void txtFaxExt_TextChanged(object sender, EventArgs e)
        {
            contact.FaxExt = txtFaxExt.Text.TrimEnd();
            contact.IsDirty = true;
            RaiseDoneOrInvalidEvent();
        }





        #region KEYDOWN
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }

        private void txtFax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }

        private void txtMobile_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }

        private void txtPhoneExt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }

        private void txtFaxExt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && containerValidator.IsValid())
                EnterPressed();
        }
        #endregion
    }
}
