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
            this.partTableAdapter.Update(this.meztlidbDataSet.Part);
        }
    }
}
