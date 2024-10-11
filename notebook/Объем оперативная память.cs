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
    public partial class Operativ : Form
    {
        public Operativ()
        {
            InitializeComponent();
        }

        private void Operativ_Load(object sender, EventArgs e)
        {
            
            this.operativTableAdapter.Fill(this.notebookDataSet3.Operativ);                       

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // если нажато на ОК передаем..
        }
        public string ozy = "";
        public string id_ozy = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            ozy = selectedRow.Cells[0].Value.ToString();
            id_ozy = selectedRow.Cells[1].Value.ToString();
        }
    }
}
