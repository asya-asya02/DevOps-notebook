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
    public partial class Дюймы : Form
    {
        public Дюймы()
        {
            InitializeComponent();
        }

        private void Дюймы_Load(object sender, EventArgs e)
        {            
            this.diagonalTableAdapter.Fill(this.notebookDataSet3.Diagonal);        

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public string diag="";
        public string id_diag = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            diag = selectedRow.Cells[0].Value.ToString();
            id_diag = selectedRow.Cells[1].Value.ToString();
        }
    }
}
