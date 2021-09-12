using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meztli
{
    public partial class VendorCodes : Form
    {
        public VendorCodes()
        {
            InitializeComponent();
        }

        private void VendorCodes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meztlidbDataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.meztlidbDataSet.Vendor);

        }

        private void dgvVendor_CellEnter(object sender, EventArgs e)
        {
            saveDataGridViewChanges();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            saveDataGridViewChanges();
        }

        private void saveDataGridViewChanges()
        {
            this.vendorTableAdapter.Update(this.meztlidbDataSet.Vendor);
        }

        private void btnDeleteRows_Click(object sender, EventArgs e)
        {
            if (this.dgvVendor.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select at least one row to delete");
                return;
            }

            foreach (DataGridViewRow item in this.dgvVendor.SelectedRows)
            {
                if (item.DataBoundItem != null)
                    dgvVendor.Rows.RemoveAt(item.Index);
            }
            saveDataGridViewChanges();
        }
    }
}
