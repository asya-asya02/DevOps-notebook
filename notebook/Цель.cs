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
    public partial class Цель : Form
    {
        public Цель()
        {
            InitializeComponent();
        }

        private void Цель_Load(object sender, EventArgs e)
        {            
            this.usingTableAdapter.Fill(this.notebookDataSet3.Using); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public string isp = "";
        public string id_isp = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            isp = selectedRow.Cells[0].Value.ToString();
            id_isp = selectedRow.Cells[1].Value.ToString();
        }
    }
}
