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
    public partial class Disk : Form
    {
        public Disk()
        {
            InitializeComponent();
        }

        private void Disk_Load(object sender, EventArgs e)
        {            
            this.diskTableAdapter.Fill(this.notebookDataSet3.Disk);            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;  // если нажато на ОК передаем..
        }
        public string disk_tip = "";
        public string id_disk_tip = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            disk_tip = selectedRow.Cells[0].Value.ToString();
            id_disk_tip = selectedRow.Cells[1].Value.ToString();
        }
    }
}
