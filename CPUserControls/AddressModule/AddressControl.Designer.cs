namespace CPUserControls.AddressModule
{
    partial class AddressControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddressControl));
            this.label6 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtZip4 = new System.Windows.Forms.TextBox();
            this.btnValidateAddress = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZip5 = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtLine2 = new System.Windows.Forms.TextBox();
            this.txtLine1 = new System.Windows.Forms.TextBox();
            this.containerValidator = new Genghis.Windows.Forms.ContainerValidator();
            this.rfvCity = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.cvState = new Genghis.Windows.Forms.CustomValidator();
            this.cboState = new System.Windows.Forms.ComboBox();
            this.rfvLine1 = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.rfvName = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.regexZip = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.lblCustId = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.rfvCoName = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.btnOverride = new System.Windows.Forms.Button();
            this.chkGovernment = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClassification = new System.Windows.Forms.TextBox();
            this.cvCountry = new Genghis.Windows.Forms.CustomValidator();
            this.cboCountry = new System.Windows.Forms.ComboBox();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.containerValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvState)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexZip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCoName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvCountry)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 41;
            this.label6.Text = "Company";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(61, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(201, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "-";
            // 
            // txtZip4
            // 
            this.txtZip4.Location = new System.Drawing.Point(213, 114);
            this.txtZip4.Name = "txtZip4";
            this.txtZip4.Size = new System.Drawing.Size(35, 20);
            this.txtZip4.TabIndex = 6;
            this.txtZip4.TextChanged += new System.EventHandler(this.txtZip4_TextChanged);
            this.txtZip4.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtZip4_KeyUp);
            // 
            // btnValidateAddress
            // 
            this.btnValidateAddress.Location = new System.Drawing.Point(61, 166);
            this.btnValidateAddress.Name = "btnValidateAddress";
            this.btnValidateAddress.Size = new System.Drawing.Size(93, 30);
            this.btnValidateAddress.TabIndex = 9;
            this.btnValidateAddress.Text = "&Validate";
            this.btnValidateAddress.UseVisualStyleBackColor = true;
            this.btnValidateAddress.Click += new System.EventHandler(this.btnValidateAddress_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Zip";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Apt/Ste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Street";
            // 
            // txtZip5
            // 
            this.txtZip5.Location = new System.Drawing.Point(154, 114);
            this.txtZip5.Name = "txtZip5";
            this.txtZip5.Size = new System.Drawing.Size(45, 20);
            this.txtZip5.TabIndex = 3;
            this.txtZip5.TextChanged += new System.EventHandler(this.txtZip5_TextChanged);
            this.txtZip5.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtZip5_KeyUp);
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(61, 88);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(187, 20);
            this.txtCity.TabIndex = 4;
            this.txtCity.TextChanged += new System.EventHandler(this.txtCity_TextChanged);
            this.txtCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCity_KeyUp);
            // 
            // txtLine2
            // 
            this.txtLine2.Location = new System.Drawing.Point(61, 62);
            this.txtLine2.Name = "txtLine2";
            this.txtLine2.Size = new System.Drawing.Size(187, 20);
            this.txtLine2.TabIndex = 2;
            this.txtLine2.TextChanged += new System.EventHandler(this.txtLine2_TextChanged);
            this.txtLine2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLine2_KeyUp);
            // 
            // txtLine1
            // 
            this.txtLine1.Location = new System.Drawing.Point(61, 36);
            this.txtLine1.Name = "txtLine1";
            this.txtLine1.Size = new System.Drawing.Size(187, 20);
            this.txtLine1.TabIndex = 1;
            this.txtLine1.TextChanged += new System.EventHandler(this.txtLine1_TextChanged);
            this.txtLine1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtLine1_KeyUp);
            // 
            // containerValidator
            // 
            this.containerValidator.ContainerToValidate = this;
            // 
            // rfvCity
            // 
            this.rfvCity.ControlToValidate = this.txtCity;
            this.rfvCity.ErrorMessage = "Cannot be left blank.";
            this.rfvCity.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvCity.Icon")));
            // 
            // cvState
            // 
            this.cvState.ControlToValidate = this.cboState;
            this.cvState.ErrorMessage = "Must be a valid state. Choose from selection.";
            this.cvState.Icon = ((System.Drawing.Icon)(resources.GetObject("cvState.Icon")));
            this.cvState.Validating += new Genghis.Windows.Forms.CustomValidator.ValidatingEventHandler(this.cvState_Validating);
            // 
            // cboState
            // 
            this.cboState.BackColor = System.Drawing.Color.White;
            this.cboState.FormattingEnabled = true;
            this.cboState.Location = new System.Drawing.Point(61, 114);
            this.cboState.Name = "cboState";
            this.cboState.Size = new System.Drawing.Size(57, 21);
            this.cboState.TabIndex = 5;
            this.cboState.TextChanged += new System.EventHandler(this.cboState_TextChanged);
            this.cboState.Leave += new System.EventHandler(this.cboState_Leave);
            // 
            // rfvLine1
            // 
            this.rfvLine1.ControlToValidate = this.txtLine1;
            this.rfvLine1.ErrorMessage = "Cannot be left blank";
            this.rfvLine1.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvLine1.Icon")));
            // 
            // rfvName
            // 
            this.rfvName.ControlToValidate = this.txtName;
            this.rfvName.ErrorMessage = "Cannot be left blank";
            this.rfvName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvName.Icon")));
            // 
            // regexZip
            // 
            this.regexZip.ControlToValidate = this.txtZip5;
            this.regexZip.ErrorMessage = "Must be a valid US zip code.";
            this.regexZip.Icon = ((System.Drawing.Icon)(resources.GetObject("regexZip.Icon")));
            this.regexZip.ValidationExpression = "^\\d{5}$";
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(9, 230);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(40, 13);
            this.lblCustId.TabIndex = 48;
            this.lblCustId.Text = "Cust Id";
            // 
            // txtCustId
            // 
            this.txtCustId.ForeColor = System.Drawing.Color.Green;
            this.txtCustId.Location = new System.Drawing.Point(61, 227);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.ReadOnly = true;
            this.txtCustId.Size = new System.Drawing.Size(187, 20);
            this.txtCustId.TabIndex = 47;
            this.txtCustId.TabStop = false;
            this.txtCustId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rfvCoName
            // 
            this.rfvCoName.ControlToValidate = this.txtName;
            this.rfvCoName.ErrorMessage = "Cannot be left blank";
            this.rfvCoName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvCoName.Icon")));
            // 
            // btnOverride
            // 
            this.btnOverride.Enabled = false;
            this.btnOverride.Location = new System.Drawing.Point(160, 166);
            this.btnOverride.Name = "btnOverride";
            this.btnOverride.Size = new System.Drawing.Size(91, 30);
            this.btnOverride.TabIndex = 10;
            this.btnOverride.Text = "&Override";
            this.btnOverride.UseVisualStyleBackColor = true;
            this.btnOverride.Click += new System.EventHandler(this.btnOverride_Click);
            // 
            // chkGovernment
            // 
            this.chkGovernment.AutoSize = true;
            this.chkGovernment.Location = new System.Drawing.Point(154, 142);
            this.chkGovernment.Name = "chkGovernment";
            this.chkGovernment.Size = new System.Drawing.Size(84, 17);
            this.chkGovernment.TabIndex = 8;
            this.chkGovernment.Text = "Government";
            this.chkGovernment.UseVisualStyleBackColor = true;
            this.chkGovernment.CheckedChanged += new System.EventHandler(this.chkGovernment_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Class";
            // 
            // txtClassification
            // 
            this.txtClassification.ForeColor = System.Drawing.Color.Green;
            this.txtClassification.Location = new System.Drawing.Point(61, 201);
            this.txtClassification.Name = "txtClassification";
            this.txtClassification.ReadOnly = true;
            this.txtClassification.Size = new System.Drawing.Size(187, 20);
            this.txtClassification.TabIndex = 49;
            this.txtClassification.TabStop = false;
            this.txtClassification.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cvCountry
            // 
            this.cvCountry.ControlToValidate = this.cboCountry;
            this.cvCountry.ErrorMessage = "Must be a country from this list.";
            this.cvCountry.Icon = ((System.Drawing.Icon)(resources.GetObject("cvCountry.Icon")));
            this.cvCountry.Validating += new Genghis.Windows.Forms.CustomValidator.ValidatingEventHandler(this.cvCountry_Validating);
            // 
            // cboCountry
            // 
            this.cboCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCountry.FormattingEnabled = true;
            this.cboCountry.Location = new System.Drawing.Point(61, 138);
            this.cboCountry.Name = "cboCountry";
            this.cboCountry.Size = new System.Drawing.Size(57, 21);
            this.cboCountry.TabIndex = 51;
            this.cboCountry.TextChanged += new System.EventHandler(this.cboCountry_TextChanged);
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusTextBox.ForeColor = System.Drawing.Color.Green;
            this.StatusTextBox.Location = new System.Drawing.Point(0, 261);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ReadOnly = true;
            this.StatusTextBox.Size = new System.Drawing.Size(286, 38);
            this.StatusTextBox.TabIndex = 52;
            this.StatusTextBox.TabStop = false;
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cboState);
            this.Controls.Add(this.StatusTextBox);
            this.Controls.Add(this.cboCountry);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtClassification);
            this.Controls.Add(this.chkGovernment);
            this.Controls.Add(this.btnOverride);
            this.Controls.Add(this.lblCustId);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtZip4);
            this.Controls.Add(this.btnValidateAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtZip5);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtLine2);
            this.Controls.Add(this.txtLine1);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(286, 299);
            this.Load += new System.EventHandler(this.AddressControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.containerValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvState)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexZip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvCoName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cvCountry)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtZip4;
        private System.Windows.Forms.Button btnValidateAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZip5;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtLine2;
        private System.Windows.Forms.TextBox txtLine1;
        private Genghis.Windows.Forms.ContainerValidator containerValidator;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvCity;
        private Genghis.Windows.Forms.CustomValidator cvState;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvLine1;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvName;
        private Genghis.Windows.Forms.RegularExpressionValidator regexZip;
        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.TextBox txtCustId;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvCoName;
        private System.Windows.Forms.Button btnOverride;
        private System.Windows.Forms.CheckBox chkGovernment;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClassification;
        private System.Windows.Forms.ComboBox cboCountry;
        private Genghis.Windows.Forms.CustomValidator cvCountry;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.ComboBox cboState;
    }
}
