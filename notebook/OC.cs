using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vybor_noutbuka
{
    public partial class OC : Form
    {
        public OC()
        {
            InitializeComponent();
        }

        private void OC_Load(object sender, EventArgs e)
        {            
            this.oSTableAdapter.Fill(this.notebookDataSet3.OS);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public string op_sys = "";
        public string id_op_sys = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            op_sys = selectedRow.Cells[0].Value.ToString();
            id_op_sys = selectedRow.Cells[1].Value.ToString();
        }
    }
}
