using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Vybor_noutbuka
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void Password_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pass;
            Edit_ntbk fr10 = new Edit_ntbk();
            StreamReader sr = new StreamReader("pass.txt");
            if ((pass = sr.ReadLine()) == textBox1.Text)
            {
                fr10.ShowDialog();
                this.Close();
                sr.Close();
            }
            {
                label1.Text = "Неверно задан пароль !";
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
            }
             
        }
    }
}
