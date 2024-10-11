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
    public partial class Form8 : Form
    {
       public string connectionString = @"Data Source=.;Initial Catalog=notebook;Integrated Security=True";
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            
            this.groupTableAdapter.Fill(this.notebookDataSet3.group);
            
            this.usersTableAdapter.Fill(this.notebookDataSet3.Users);
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Добавить
            Form9 fr9 = new Form9();
            fr9.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usersBindingSource1;
            this.usersTableAdapter.Fill(this.notebookDataSet3.Users);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Обновить
            /*
            int rowindex = dataGridView1.CurrentCell.RowIndex;
            id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
            Data_id.Value = id;
            Form10 fr10 = new Form10();
            fr10.ShowDialog();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usersBindingSource1;
            this.usersTableAdapter.Fill(this.notebookDataSet3.Users);
             */
            
            
                int f = 0;
                f = dataGridView1.CurrentRow.Index;

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                Data_id.Value = id;
                if (id != 1)
                {
                Form10 fr10 = new Form10();
                fr10.ShowDialog();
                this.usersTableAdapter.Update(this.notebookDataSet3);
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = usersBindingSource1;
                this.usersTableAdapter.Fill(this.notebookDataSet3.Users);
                    
                }
                else
                {
                    MessageBox.Show("Изменить запись нельзя!. Защищенный учетный запись");
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = usersBindingSource1;
                    this.usersTableAdapter.Fill(this.notebookDataSet3.Users);
                    
                }
                if (f < dataGridView1.RowCount)
                {
                    dataGridView1.ClearSelection();
                    dataGridView1.Rows[f].Selected = true;
                    dataGridView1.FirstDisplayedScrollingRowIndex = f;
                    dataGridView1.Update();
                }                                            


        }
        int id;
        string sql_d = "";

        private void button3_Click(object sender, EventArgs e)
        {
            //Удалить
            DialogResult dialogResult = MessageBox.Show("Хотите удалить запись ?", "Внимание", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                sql_d = "DELETE FROM Users WHERE id_user = @id";

                int rowindex = dataGridView1.CurrentCell.RowIndex;
                //int columnindex = dataGridView1.CurrentCell.ColumnIndex;

                id = Convert.ToInt32(dataGridView1.Rows[rowindex].Cells[0].Value);
                if (id != 1)
                {
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

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = usersBindingSource1;
                    //                this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);

                    this.usersTableAdapter.Fill(this.notebookDataSet3.Users);
                }
                else
                {
                    MessageBox.Show("Удалить нельзя!. Защищенный учетный запись");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Update(this.notebookDataSet3);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = usersBindingSource1;
            this.usersTableAdapter.Fill(this.notebookDataSet3.Users);                    
        }
    }
}
