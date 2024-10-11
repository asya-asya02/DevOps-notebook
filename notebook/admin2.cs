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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
        }

        private void admin2_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet2.Notebook". При необходимости она может быть перемещена или удалена.
            this.notebookTableAdapter1.Fill(this.notebookDataSet2.Notebook);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet1.Notebook". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nOTEBOOKDataSet.Notebook". При необходимости она может быть перемещена или удалена.
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.notebookTableAdapter1.Update(this.notebookDataSet2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
