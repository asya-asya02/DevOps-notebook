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
    public partial class Proizvodit : Form
    {
        public Proizvodit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // если нажато на ОК передаем..
        }
        
        public string firma = "";
        public string id_firma = "";
        private void Proizvodit_Load(object sender, EventArgs e)
        {

            this.firmTableAdapter.Fill(this.notebookDataSet3.Firm);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            firma = selectedRow.Cells[0].Value.ToString();
            id_firma = selectedRow.Cells[1].Value.ToString();
        }
        
    }
}
