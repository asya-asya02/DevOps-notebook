using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vybor_noutbuka
{
    public partial class Acer : Form
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Vybor_noutbuka.Properties.Settings.NOTEBOOKConnectionString"].ConnectionString);
        public Acer()
        {
            InitializeComponent();
        }
        string sql;
        private void Acer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "nOTEBOOKDataSet.Notebook". При необходимости она может быть перемещена или удалена.
            this.notebookTableAdapter.Fill(this.nOTEBOOKDataSet.Notebook);
            sql = @"SELECT id,notebook, Parameters FROM notebook WHERE notebook like 'Acer%'";

            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "notebook");
            dataGridView1.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Notebook fntbk = new Notebook();
            CallBackMy.callbackEventHandler("Acer",@ntbk, @Prmtr);    
            fntbk.ShowDialog();
        }
        public string Prmtr = "";
        string ntbk = "";
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            ntbk = selectedRow.Cells[2].Value.ToString();
            Prmtr = selectedRow.Cells[1].Value.ToString();
        }
    }
}
