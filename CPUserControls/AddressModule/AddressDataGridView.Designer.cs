namespace CPUserControls.AddressModule
{
    partial class AddressDataGridView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAddress = new System.Windows.Forms.DataGridView();
            this.AddrType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Line2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Zip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddrKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAddress
            // 
            this.dgvAddress.AllowUserToAddRows = false;
            this.dgvAddress.AllowUserToDeleteRows = false;
            this.dgvAddress.AllowUserToResizeRows = false;
            this.dgvAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAddress.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AddrType,
            this.CustID,
            this.Active,
            this.AddrName,
            this.Line1,
            this.Line2,
            this.City,
            this.Zip,
            this.State,
            this.AddrKey});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddress.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddress.Location = new System.Drawing.Point(3, 3);
            this.dgvAddress.MultiSelect = false;
            this.dgvAddress.Name = "dgvAddress";
            this.dgvAddress.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddress.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAddress.RowHeadersVisible = false;
            this.dgvAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddress.Size = new System.Drawing.Size(745, 227);
            this.dgvAddress.TabIndex = 1;
            this.dgvAddress.SelectionChanged += new System.EventHandler(this.dgvAddress_SelectionChanged);
            this.dgvAddress.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAddress_KeyUp);
            // 
            // AddrType
            // 
            this.AddrType.HeaderText = "Type";
            this.AddrType.Name = "AddrType";
            this.AddrType.ReadOnly = true;
            this.AddrType.Width = 56;
            // 
            // CustID
            // 
            this.CustID.HeaderText = "CustID";
            this.CustID.Name = "CustID";
            this.CustID.ReadOnly = true;
            this.CustID.Visible = false;
            this.CustID.Width = 64;
            // 
            // Active
            // 
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            this.Active.Width = 43;
            // 
            // AddrName
            // 
            this.AddrName.HeaderText = "Name";
            this.AddrName.Name = "AddrName";
            this.AddrName.ReadOnly = true;
            this.AddrName.Width = 60;
            // 
            // Line1
            // 
            this.Line1.HeaderText = "Street";
            this.Line1.Name = "Line1";
            this.Line1.ReadOnly = true;
            this.Line1.Width = 60;
            // 
            // Line2
            // 
            this.Line2.HeaderText = "Ste/Apt";
            this.Line2.Name = "Line2";
            this.Line2.ReadOnly = true;
            this.Line2.Width = 69;
            // 
            // City
            // 
            this.City.HeaderText = "City";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 49;
            // 
            // Zip
            // 
            this.Zip.HeaderText = "Zip";
            this.Zip.Name = "Zip";
            this.Zip.ReadOnly = true;
            this.Zip.Width = 47;
            // 
            // State
            // 
            this.State.HeaderText = "State";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 57;
            // 
            // AddrKey
            // 
            this.AddrKey.HeaderText = "AddrKey";
            this.AddrKey.Name = "AddrKey";
            this.AddrKey.ReadOnly = true;
            this.AddrKey.Visible = false;
            this.AddrKey.Width = 72;
            // 
            // AddressDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvAddress);
            this.Name = "AddressDataGridView";
            this.Size = new System.Drawing.Size(752, 233);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddress)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddrType;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustID;
        private System.Windows.Forms.DataGridViewImageColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Line2;
        private System.Windows.Forms.DataGridViewTextBoxColumn City;
        private System.Windows.Forms.DataGridViewTextBoxColumn Zip;
        private System.Windows.Forms.DataGridViewTextBoxColumn State;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddrKey;
    }
}
