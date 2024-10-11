using System;
using System.Configuration;
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
   /* static class model
    {
        public static string Value { get; set; }
    }
    static class price
    {
        public static string Value { get; set; }
    }
    static class cmbx14
    {
        public static string Value { get; set; }
    }
    */

    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        //public static string conn = @"Data Source=USER-PC;Initial Catalog=NOTEBOOK;Integrated Security=True";
        
        private void button1_Click(object sender, EventArgs e)
        {
           Выбор_по_характеристикам  fr1 = new  Выбор_по_характеристикам ();
           fr1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Naznachen fr2 = new Naznachen();
            fr2.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Process SysInfo = new Process();
            //    SysInfo.StartInfo.ErrorDialog = true;
            //    SysInfo.StartInfo.FileName = "help.chm";
            //    SysInfo.Start();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            Help.ShowHelp(this, "Help.chm");

        }

        private void button6_Click(object sender, EventArgs e)
        {
           //Password fr4 = new Password();
           //fr4.ShowDialog();           
           
            Edit_ntbk fr10 = new Edit_ntbk();
            fr10.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Opisanie fr3 = new Opisanie();
            fr3.ShowDialog();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Form7 fr7 = new Form7();
            fr7.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            admin2 fr44 = new admin2();
            fr44.ShowDialog();           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
