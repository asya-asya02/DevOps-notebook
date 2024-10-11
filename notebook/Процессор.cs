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
    public partial class Proc : Form
    {
        public Proc()
        {
            InitializeComponent();
        }

        private void Proc_Load(object sender, EventArgs e)
        {
            
            this.processorTableAdapter.Fill(this.notebookDataSet3.Processor);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // если нажато на ОК передаем..
        }
        public string proc = "";
        public string id_pr = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            proc = selectedRow.Cells[0].Value.ToString();
            id_pr = selectedRow.Cells[1].Value.ToString();
        }

    }
}
