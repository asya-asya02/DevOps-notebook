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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Вход
            string connectionString = @"Data Source=.;Initial Catalog=NOTEBOOK;Integrated Security=True";

            SqlConnection SQLCon = new SqlConnection(connectionString);
            SqlCommand sqlcomm = new SqlCommand();
            sqlcomm.Connection = SQLCon;

            sqlcomm.CommandType = CommandType.StoredProcedure;
            sqlcomm.CommandText = "chck_password"; // Stored Procedure name
            sqlcomm.Parameters.AddWithValue("@login", textBox1.Text.ToString()); // Input parameters
            sqlcomm.Parameters.AddWithValue("@hpwd", textBox2.Text); // Input parameters

            // Your output parameter in Stored Procedure           
            var returnParam1 = new SqlParameter
            {
                ParameterName = "@id",
                Direction = ParameterDirection.Output,
                Size = 3
            };
            sqlcomm.Parameters.Add(returnParam1);

            // Your output parameter in Stored Procedure            

            SQLCon.Open();
            sqlcomm.ExecuteNonQuery();

            string retunvalue = (string)sqlcomm.Parameters["@id"].Value;

            //MessageBox.Show(retunvalue);
            SQLCon.Close();
            switch (retunvalue)
            {
                case "-1":
                    MessageBox.Show("Неверный пароль или логин! Попробуйте заново!");
                    break;
                case "1":
                    Form6 fr6 = new Form6();
                    fr6.ShowDialog();
                    break;
                case "2":
                    //MessageBox.Show("Азырынча андай форма жок!");
                    this.Close();
                    break;
                default:
                    break;
            }

            //this.Visible = false;            
            //this.Close();


        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 14;
            textBox1.Text = "";
            textBox2.MaxLength = 14;
            textBox2.Text = "";
            textBox2.PasswordChar = '*';

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                button1_Click(this, new EventArgs());
            }

        }
    }
}
