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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'meztlidbDataSet.Part' table. You can move, or remove it, as needed.
            this.partTableAdapter.Fill(this.meztlidbDataSet.Part);

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            saveDataGridViewChanges();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            saveDataGridViewChanges();
        }

        private void btnDeleteRows_Click(object sender, EventArgs e)
        {
            if(this.dgvParts.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select at least one row to delete");
                return;
            }

            foreach (DataGridViewRow item in this.dgvParts.SelectedRows)
            {
                if(item.DataBoundItem != null)
                    dgvParts.Rows.RemoveAt(item.Index);
            }
            saveDataGridViewChanges();
        }

        private void saveDataGridViewChanges()
        {
            this.partTableAdapter.Update(this.meztlidbDataSet.Part);
        }
    }
}
