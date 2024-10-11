using System;
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
    

    public partial class edit_s : Form
    {
        public string connectionString = "Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public edit_s()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void edit_s_Load(object sender, EventArgs e)
        {           
            
            this.paramTableAdapter.Fill(this.notebookDataSet3.Param);
            comboBox1_SelectionChangeCommitted(this, e);
            textBox2.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox1.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            /*******************************************************************/

           

            
        }
        string sql;
        string tab_name;
        
        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Желаете сохранить исправленный запись", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                // Обновить
                
                //textBox1.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                //textBox2.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
                
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                //cmd.CommandText = "UPDATE Money SET  Money = @money  WHERE id_money = @id";
                cmd.CommandText = sw_tab(tab_name);
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@tab_col", textBox2.Text);
                //MessageBox.Show(sw_tab(tab_name));                
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value));
                con.Open();
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("Запись обновлен. ");
                comboBox1_SelectionChangeCommitted(this, e);    
                
                con.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

                //do something else
            }

            
        }
        
        public static string  sw_tab(string s)
        {
            
            string upd_sql ="";
            switch (s)
            {
                case "Money":
                    tabcol="money";
                    upd_sql = "UPDATE [Money] SET  [money] = @tab_col  WHERE [id_money] = @id";
                    break;
                case "Firm":
                    tabcol = "firm";
                    upd_sql = "UPDATE [firm] SET  [firm] = @tab_col  WHERE [id_firm] = @id";
                    break;
                case "Tip":
                    tabcol = "[tip]";
                    upd_sql = "UPDATE [tip] SET  [tip] = @tab_col  WHERE [id_tip] = @id";
                    break;
                case "Processor":
                    tabcol = "[Proc]";
                    upd_sql = "UPDATE [Processor] SET  [Proc] = @tab_col  WHERE [id_proc] = @id";
                    break;
                case "Operativ":
                    tabcol = "Operativ_pam";
                    upd_sql = "UPDATE [Operativ] SET  [Operativ_pam] = @tab_col  WHERE [id_oper] = @id";
                    break;
                case "HDD":
                    tabcol = "HDD";
                    upd_sql = "UPDATE [HDD] SET  [HDD] = @tab_col  WHERE [id_hdd] = @id";
                    break;
                case "Disk":
                    tabcol = "Disk";
                    upd_sql = "UPDATE [Disk] SET  [Disk] = @tab_col  WHERE [id_disk] = @id";
                    break;
                case "Diagonal":
                    tabcol = "Diagonal";
                    upd_sql = "UPDATE [Diagonal] SET  [Diagonal] = @tab_col  WHERE [id_diag] = @id";
                    break;
                case "OS":
                    tabcol = "OS";
                    upd_sql = "UPDATE [OS] SET  [OS] = @tab_col  WHERE [id_os] = @id";
                    break;
                case "bluetooth":
                    tabcol = "bluetooth";
                    upd_sql = "UPDATE [bluetooth] SET  [bluetooth] = @tab_col  WHERE [id_bluetooth] = @id";
                    break;
                case "Using":
                    tabcol = "using";
                    upd_sql = "UPDATE [Using] SET  [Using] = @tab_col  WHERE [id_using] = @id";
                    break;

                default:
                
                    break;
            }
             return  upd_sql;
        }

        public static string tabcol;
        public static string sw_col(string s)
        {
                        
            switch (s)
            {
                case "Money":
                    tabcol = "money";                    
                    break;
                case "Firm":
                    tabcol = "firm";                    
                    break;
                case "Tip":
                    tabcol = "tip";                    
                    break;
                case "Processor":
                    tabcol = "Proc";                    
                    break;
                case "Operativ":
                    tabcol = "Operativ_pam";                    
                    break;
                case "HDD":
                    tabcol = "HDD";                    
                    break;
                case "Disk":
                    tabcol = "Disk";                    
                    break;
                case "Diagonal":
                    tabcol = "Diagonal";                    
                    break;
                case "OS":
                    tabcol = "OS";                    
                    break;
                case "bluetooth":
                    tabcol = "bluetooth";                    
                    break;
                case "Using":
                    tabcol = "using";                    
                    break;

                default:

                    break;
            }
            return tabcol;
        }
        public static string tabid;
        public static string sw_id(string s)
        {

            switch (s)
            {
                case "Money":
                    tabcol = "id_money";
                    break;
                case "Firm":
                    tabcol = "id_firm";
                    break;
                case "Tip":
                    tabcol = "id_tip";
                    break;
                case "Processor":
                    tabcol = "id_proc";
                    break;
                case "Operativ":
                    tabcol = "id_oper";
                    break;
                case "HDD":
                    tabcol = "id_hdd";
                    break;
                case "Disk":
                    tabcol = "id_disk";
                    break;
                case "Diagonal":
                    tabcol = "id_diag";
                    break;
                case "OS":
                    tabcol = "id_os";
                    break;
                case "bluetooth":
                    tabcol = "id_bluetooth";
                    break;
                case "Using":
                    tabcol = "id_using";
                    break;

                default:

                    break;
            }
            return tabcol;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Выбор производителя
            SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=notebook;Integrated Security=True");
            string sqlExpression = "SELECT * FROM Param WHERE id_param = @id_param;";
            SqlCommand cmd = new SqlCommand(sqlExpression, con1);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@id_param", Convert.ToInt32(comboBox1.SelectedValue));


            con1.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                tab_name = reader.GetValue(2).ToString();
            }

            reader.Close();
            con1.Close();

            /******************************************************************/
            //MessageBox.Show(comboBox1.Text + "    " + comboBox1.SelectedValue.ToString());

            sql = @"SELECT " + sw_tab(tab_name) + " FROM " + tab_name;
            sql = @"SELECT * FROM " + tab_name;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, tab_name);
            dataGridView1.DataSource = ds.Tables[0];
            //dataGridView1.Columns[0].HeaderText = @"Параметр";            
            dataGridView1.Columns[1].Visible = false;
            //dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value = 0;
            dataGridView1[1, 0].Selected = true;
            textBox2.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox1.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            textBox2.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            textBox1.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
        //    String s = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
         //   MessageBox.Show(s);

            //textBox2.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //textBox2.Text = dataGridView1[2, 1].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // новая запись
            col1.Value = sw_col(tab_name);
            tab1.Value = tab_name;
            Form5 fr5 = new Form5();
            fr5.ShowDialog();
            comboBox1_SelectionChangeCommitted(this, e);    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // удалить запись
            /*********************************************************/
            int id;
            string sql_d = "";
            string id_name = "";
            int count=1;
            
            DialogResult dialogResult = MessageBox.Show("Хотите удалить запись ?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {                               
                id_name = sw_id(tab_name);
                id = Convert.ToInt32(textBox1.Text);
                SqlConnection cond = new SqlConnection(connectionString);
                // 
                string sqlExpression = "SELECT count(*) FROM notebook WHERE "+id_name+ " = @id;";
                SqlCommand cmd1 = new SqlCommand(sqlExpression, cond);
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.AddWithValue("@id", textBox1.Text);
                               
                cond.Open();
                SqlDataReader reader = cmd1.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    //MessageBox.Show(reader.GetValue(0).ToString());
                    count = Convert.ToInt32(reader.GetValue(0));
                }

                reader.Close();
                cond.Close();

                //
                //
                if (count == 0)
                {
                    sql_d = "DELETE FROM " + tab_name + " WHERE " + id_name + " = @id";

                    SqlConnection con = new SqlConnection(connectionString);
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = sql_d;
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@id", id);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Запись удален. ");
                    con.Close();
                    comboBox1_SelectionChangeCommitted(this, e);
                }
                else 
                {
                    MessageBox.Show("Имеется " + count.ToString() + " запись. Вы можете удалить записи только не связанные !");
                }

            }
            else if (dialogResult == DialogResult.No)
            {

                //do something else
            }

            /*********************************************************/
            

        }
    }
}
