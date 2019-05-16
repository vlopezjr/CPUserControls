namespace CPUserControls.ContactModule
{
    partial class ContactControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactControl));
            this.groupBoxStatus = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFaxExt = new System.Windows.Forms.TextBox();
            this.txtPhoneExt = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.MaskedTextBox();
            this.txtFax = new System.Windows.Forms.MaskedTextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.containerValidator = new Genghis.Windows.Forms.ContainerValidator();
            this.regexEmail = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.regexPhone = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.regexPhoneExt = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.regexFax = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.regexMobile = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.regexFaxExt = new Genghis.Windows.Forms.RegularExpressionValidator();
            this.rfvName = new Genghis.Windows.Forms.RequiredFieldValidator();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBoxStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerValidator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexPhoneExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexMobile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFaxExt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStatus
            // 
            this.groupBoxStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxStatus.Controls.Add(this.lblStatus);
            this.groupBoxStatus.Location = new System.Drawing.Point(-16, 158);
            this.groupBoxStatus.Name = "groupBoxStatus";
            this.groupBoxStatus.Size = new System.Drawing.Size(341, 40);
            this.groupBoxStatus.TabIndex = 61;
            this.groupBoxStatus.TabStop = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(20, 12);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 13);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "{{ Status }}";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 60;
            this.label12.Text = "X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 59;
            this.label11.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 58;
            this.label6.Text = "Mobile";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Fax";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Name";
            // 
            // txtFaxExt
            // 
            this.txtFaxExt.Location = new System.Drawing.Point(196, 111);
            this.txtFaxExt.Name = "txtFaxExt";
            this.txtFaxExt.Size = new System.Drawing.Size(36, 20);
            this.txtFaxExt.TabIndex = 7;
            this.txtFaxExt.TextChanged += new System.EventHandler(this.txtFaxExt_TextChanged);
            this.txtFaxExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFaxExt_KeyDown);
            // 
            // txtPhoneExt
            // 
            this.txtPhoneExt.Location = new System.Drawing.Point(196, 85);
            this.txtPhoneExt.Name = "txtPhoneExt";
            this.txtPhoneExt.Size = new System.Drawing.Size(36, 20);
            this.txtPhoneExt.TabIndex = 6;
            this.txtPhoneExt.TextChanged += new System.EventHandler(this.txtPhoneExt_TextChanged);
            this.txtPhoneExt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhoneExt_KeyDown);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(60, 137);
            this.txtMobile.Mask = "(999) 000-0000";
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(117, 20);
            this.txtMobile.TabIndex = 5;
            this.txtMobile.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtMobile.TextChanged += new System.EventHandler(this.txtMobile_TextChanged);
            this.txtMobile.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMobile_KeyDown);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(60, 111);
            this.txtFax.Mask = "(999) 000-0000";
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(117, 20);
            this.txtFax.TabIndex = 4;
            this.txtFax.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtFax.TextChanged += new System.EventHandler(this.txtFax_TextChanged);
            this.txtFax.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFax_KeyDown);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(60, 85);
            this.txtPhone.Mask = "(999) 000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(117, 20);
            this.txtPhone.TabIndex = 3;
            this.txtPhone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPhone_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(60, 35);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(185, 20);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmail_KeyDown);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(60, 9);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(185, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            this.txtName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyDown);
            // 
            // containerValidator
            // 
            this.containerValidator.ContainerToValidate = this;
            // 
            // regexEmail
            // 
            this.regexEmail.ControlToValidate = this.txtEmail;
            this.regexEmail.ErrorMessage = "Please enter a valid email.";
            this.regexEmail.Icon = ((System.Drawing.Icon)(resources.GetObject("regexEmail.Icon")));
            this.regexEmail.Required = false;
            this.regexEmail.ValidationExpression = "^.*@.+\\..+$";
            // 
            // regexPhone
            // 
            this.regexPhone.ControlToValidate = this.txtPhone;
            this.regexPhone.ErrorMessage = "Must be a valid 10 digit phone number.";
            this.regexPhone.Icon = ((System.Drawing.Icon)(resources.GetObject("regexPhone.Icon")));
            this.regexPhone.ValidationExpression = "^\\(?\\d{3}\\)? ?-?\\d{3}\\)? ?-?\\d{4}$";
            // 
            // regexPhoneExt
            // 
            this.regexPhoneExt.ControlToValidate = this.txtPhoneExt;
            this.regexPhoneExt.ErrorMessage = "Can only contain digits.";
            this.regexPhoneExt.Icon = ((System.Drawing.Icon)(resources.GetObject("regexPhoneExt.Icon")));
            this.regexPhoneExt.Required = false;
            this.regexPhoneExt.ValidationExpression = "^\\d*$";
            // 
            // regexFax
            // 
            this.regexFax.ControlToValidate = this.txtFax;
            this.regexFax.ErrorMessage = "Must be a valid 10 digit phone number.";
            this.regexFax.Icon = ((System.Drawing.Icon)(resources.GetObject("regexFax.Icon")));
            this.regexFax.Required = false;
            this.regexFax.ValidationExpression = "^\\(?\\d{3}\\)? ?-?\\d{3}\\)? ?-?\\d{4}$";
            // 
            // regexMobile
            // 
            this.regexMobile.ControlToValidate = this.txtMobile;
            this.regexMobile.ErrorMessage = "Must be a valid 10 digit phone number.";
            this.regexMobile.Icon = ((System.Drawing.Icon)(resources.GetObject("regexMobile.Icon")));
            this.regexMobile.Required = false;
            this.regexMobile.ValidationExpression = "^\\(?\\d{3}\\)? ?-?\\d{3}\\)? ?-?\\d{4}$";
            // 
            // regexFaxExt
            // 
            this.regexFaxExt.ControlToValidate = this.txtFaxExt;
            this.regexFaxExt.ErrorMessage = "Can only contain digits.";
            this.regexFaxExt.Icon = ((System.Drawing.Icon)(resources.GetObject("regexFaxExt.Icon")));
            this.regexFaxExt.Required = false;
            this.regexFaxExt.ValidationExpression = "^\\d*$";
            // 
            // rfvName
            // 
            this.rfvName.ControlToValidate = this.txtName;
            this.rfvName.ErrorMessage = "Name is required.";
            this.rfvName.Icon = ((System.Drawing.Icon)(resources.GetObject("rfvName.Icon")));
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(60, 59);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(185, 20);
            this.txtTitle.TabIndex = 2;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // ContactControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.groupBoxStatus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFaxExt);
            this.Controls.Add(this.txtPhoneExt);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtName);
            this.Name = "ContactControl";
            this.Size = new System.Drawing.Size(318, 187);
            this.Load += new System.EventHandler(this.ContactControl_Load);
            this.groupBoxStatus.ResumeLayout(false);
            this.groupBoxStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.containerValidator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexPhoneExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexMobile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regexFaxExt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rfvName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFaxExt;
        private System.Windows.Forms.TextBox txtPhoneExt;
        private System.Windows.Forms.MaskedTextBox txtMobile;
        private System.Windows.Forms.MaskedTextBox txtFax;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private Genghis.Windows.Forms.ContainerValidator containerValidator;
        private Genghis.Windows.Forms.RegularExpressionValidator regexEmail;
        private Genghis.Windows.Forms.RegularExpressionValidator regexPhone;
        private Genghis.Windows.Forms.RegularExpressionValidator regexPhoneExt;
        private Genghis.Windows.Forms.RegularExpressionValidator regexFax;
        private Genghis.Windows.Forms.RegularExpressionValidator regexMobile;
        private Genghis.Windows.Forms.RegularExpressionValidator regexFaxExt;
        private Genghis.Windows.Forms.RequiredFieldValidator rfvName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitle;
    }
}
