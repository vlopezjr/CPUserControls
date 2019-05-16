using CPUserControls.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CPUserControls.AddressModule
{
    public partial class AddressDataGridView : UserControl
    {
        public delegate void SCEventHandler(int key);
        public event SCEventHandler SelectionChanged = delegate { };
        public event Action EscapePressed = delegate { };
        public event DataGridViewCellEventHandler CellContentDoubleClicked
        {
            add { dgvAddress.CellContentDoubleClick += value; }
            remove { dgvAddress.CellContentDoubleClick -= value; }
        }

        List<BLAddress> blAddresses;

        public AddressDataGridView()
        {
            InitializeComponent();
        }




        //PUBLIC METHODS
        public void Initialize(ICollection<BLAddress> _blAddresses)
        {
            blAddresses = _blAddresses.ToList();
            Refresh(blAddresses);
        }

        public int GetColumnWidth()
        {
            int width = 0;
            foreach (DataGridViewColumn column in dgvAddress.Columns)
                if (column.Visible == true)
                    width += column.Width;
            return width;
        }

        public void SelectDGVRow(int index)
        {
            if (dgvAddress.Rows.Count == 0) return;

            dgvAddress.SelectionChanged -= dgvAddress_SelectionChanged;
            dgvAddress.Rows[index].Selected = true;
            dgvAddress.SelectionChanged += dgvAddress_SelectionChanged;
        }

        public void ShowActiveColumn()
        {
            var activeCol = dgvAddress.Columns["Active"];
            activeCol.Visible = true;
        }

        public void Refresh(List<BLAddress> _blAddresses)
        {
            dgvAddress.SelectionChanged -= dgvAddress_SelectionChanged;

            dgvAddress.Rows.Clear();

            foreach (var blAddr in _blAddresses)
            {
                var index = dgvAddress.Rows.Add();
                var row = dgvAddress.Rows[index];

                bool isActive = blAddr.Data.CustAddress.ShipDays < 90;
                row.Cells["Active"].Value = isActive ? Resources.singlecheck16x16 : Resources.singlex16x16;
                row.Cells["AddrKey"].Value = blAddr.Data.Key;
                row.Cells["AddrType"].Value = blAddr.Type;
                row.Cells["AddrName"].Value = blAddr.Data.Name;
                row.Cells["Line1"].Value = blAddr.Data.Line1;
                row.Cells["Line2"].Value = blAddr.Data.Line2;
                row.Cells["City"].Value = blAddr.Data.City;
                row.Cells["Zip"].Value = blAddr.Data.Zip;
                row.Cells["State"].Value = blAddr.Data.State;

                if (dgvAddress.Columns["CustID"].Visible == true)
                {
                    row.Cells["CustID"].Value = blAddr.CustId;
                }
            }

            dgvAddress.SelectionChanged += dgvAddress_SelectionChanged;
        }

        public void ShowCustIDColumn()
        {
            dgvAddress.Columns["CustID"].Visible = true;
        }





        //EVENT HANDLERS
        private void dgvAddress_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAddress.Rows.Count == 0) return;
            if (dgvAddress.SelectedRows.Count == 0) return;

            var currentKey = Convert.ToInt32(dgvAddress.SelectedRows[0].Cells["AddrKey"].Value);
            SelectionChanged(currentKey);
        }

        private void dgvAddress_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                EscapePressed();
        }
    }
}
