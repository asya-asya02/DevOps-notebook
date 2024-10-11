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
    public partial class Цена : Form
    {
        public Цена()
        {
            InitializeComponent();
        }

        private void Цена_Load(object sender, EventArgs e)
        {            
            this.moneyTableAdapter.Fill(this.notebookDataSet3.Money);            
        }
        public string diapozon = "";
        public string id_diapozon = "";
        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            diapozon = selectedRow.Cells[0].Value.ToString();
            id_diapozon = selectedRow.Cells[1].Value.ToString();
        }
    }
}
