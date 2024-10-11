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
    public partial class hdd : Form
    {
        public hdd()
        {
            InitializeComponent();
        }

        private void hdd_Load(object sender, EventArgs e)
        {            
            this.hDDTableAdapter.Fill(this.notebookDataSet3.HDD);                    

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // если нажато на ОК передаем..
        }
        public string hddisk = "";
        public string id_hddisk = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            hddisk = selectedRow.Cells[0].Value.ToString();
            id_hddisk = selectedRow.Cells[1].Value.ToString();
        }

    }
}
