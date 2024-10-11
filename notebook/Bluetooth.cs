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
    public partial class Bluetooth : Form
    {
        public Bluetooth()
        {
            InitializeComponent();
        }

        private void Bluetooth_Load(object sender, EventArgs e)
        {            
            this.bluetoothTableAdapter.Fill(this.notebookDataSet3.bluetooth);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        public string bl_podkl = "";
        public string id_bl_podkl = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            bl_podkl = selectedRow.Cells[0].Value.ToString();
            id_bl_podkl = selectedRow.Cells[1].Value.ToString();
        }
    }
}
