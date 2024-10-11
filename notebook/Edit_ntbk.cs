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
    public partial class Edit_ntbk : Form
    {

        
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Vybor_noutbuka.Properties.Settings.NOTEBOOKConnectionString"].ConnectionString);
        public string[] Mas01 = new string[14];

        Form2 frm2 = new Form2();
        public Edit_ntbk()
        {
            InitializeComponent();
        }

        private void Edit_ntbk_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "notebookDataSet3.vnotebook". При необходимости она может быть перемещена или удалена.
            
            this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);
            
            this.usingTableAdapter.Fill(this.notebookDataSet3.Using);            
            this.bluetoothTableAdapter.Fill(this.notebookDataSet3.bluetooth);            
            this.oSTableAdapter.Fill(this.notebookDataSet3.OS);            
            this.diagonalTableAdapter.Fill(this.notebookDataSet3.Diagonal);            
            this.diskTableAdapter.Fill(this.notebookDataSet3.Disk);            
            this.hDDTableAdapter.Fill(this.notebookDataSet3.HDD);            
            this.operativTableAdapter.Fill(this.notebookDataSet3.Operativ);            
            this.processorTableAdapter.Fill(this.notebookDataSet3.Processor);            
            this.tipTableAdapter.Fill(this.notebookDataSet3.tip);            
            this.moneyTableAdapter.Fill(this.notebookDataSet3.Money);            
            this.firmTableAdapter.Fill(this.notebookDataSet3.Firm);            
            this.notebookTableAdapter1.Fill(this.notebookDataSet3.Notebook);            
            this.notebookTableAdapter.Fill(this.nOTEBOOKDataSet.Notebook);
            
        }

        private void notebookBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.notebookBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.nOTEBOOKDataSet);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void notebookDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Новая запись
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
            dataGridView.DataSource = null;
            dataGridView.DataSource = vnotebookBindingSource;
            this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);
                       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            /*
            Mas01 = frm2.Mas1;
            dataGridView[2, dataGridView.CurrentCell.RowIndex].Value = Mas01[1];
            dataGridView[3, dataGridView.CurrentCell.RowIndex].Value = Mas01[2];
            dataGridView[4, dataGridView.CurrentCell.RowIndex].Value = Mas01[3];
            dataGridView[5, dataGridView.CurrentCell.RowIndex].Value = Mas01[4];
            dataGridView[6, dataGridView.CurrentCell.RowIndex].Value = Mas01[5];
            dataGridView[7, dataGridView.CurrentCell.RowIndex].Value = Mas01[6];
            dataGridView[8, dataGridView.CurrentCell.RowIndex].Value = Mas01[7];
            dataGridView[9, dataGridView.CurrentCell.RowIndex].Value = Mas01[8];
            dataGridView[10, dataGridView.CurrentCell.RowIndex].Value = Mas01[9];
            dataGridView[11, dataGridView.CurrentCell.RowIndex].Value = Mas01[10];
            dataGridView[12, dataGridView.CurrentCell.RowIndex].Value = Mas01[11];
            dataGridView[13, dataGridView.CurrentCell.RowIndex].Value = Mas01[12];

            */

            //MessageBox.Show(Mas01[1]);
            dataGridView.DataSource = null;
            dataGridView.DataSource = vnotebookBindingSource;
            
            this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);
            
            //dataGridView.Update();
            //this.notebookTableAdapter1.Update(this.notebookDataSet3.Notebook);
            //MessageBox.Show("Записи обнавлены !");




            //editor fr_edit = new editor();
            //fr_edit.ShowDialog();
//---------------------            
/*            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE [Notebook] SET  [notebook] = @notebook, [Parameters] = @Pr, [price] = @price WHERE [id]=@id";
            cmd.Connection = con;
            cmd.Parameters.AddWithValue("@notebook", textBox1.Text);
            cmd.Parameters.AddWithValue("@Pr", textBox2.Text);
            cmd.Parameters.AddWithValue("@price", textBox3.Text);
            cmd.Parameters.AddWithValue("@Id", id);
            con.Open();
            cmd.ExecuteNonQuery();

            MessageBox.Show("Запись обнавлен. Данные отобразятся при следующем входе в базу данных.");


            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM notebook", con);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "notebook");
            dataGridView1.DataSource = ds.Tables[0];
            //---------

            dataGridView1.FirstDisplayedScrollingRowIndex = 10;
            DataGridViewRow selectedRow = dataGridView1.Rows[10];
                //firstDisplayed + 1;
            this.Close();
 */
            //---------
        }
        //string id;
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
            int Index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[Index];
            id = selectedRow.Cells[0].Value.ToString();
            textBox1.Text = selectedRow.Cells[1].Value.ToString();
            textBox2.Text = selectedRow.Cells[2].Value.ToString();
            textBox3.Text = selectedRow.Cells[3].Value.ToString();

            int firstDisplayed = dataGridView1.FirstDisplayedScrollingRowIndex;
            int displayed = dataGridView1.DisplayedRowCount(true);
            int lastVisible = (firstDisplayed + displayed) - 1;
            int lastIndex = dataGridView1.RowCount - 1;
            //dataGridView1.Rows.Add();  
            if (lastVisible == lastIndex)
            {
                //dataGridView1.FirstDisplayedScrollingRowIndex = firstDisplayed + 1;
            }
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            edit_s eds = new edit_s();
            eds.ShowDialog();
        }

        private void dataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            /*int index = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows[index].Selected = true;
            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Red;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.White;
            cmbx14.Value = dataGridView[14, 1].Value.ToString(); // Модель
             */
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        
        private void dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Удалить

            SqlCommand cmd = new SqlCommand();
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Строка для удаления не выбрана");
                return;
            }
            int id = (int)dataGridView["IdDataGridViewTextBoxColumn", dataGridView.CurrentRow.Index].Value;

            //if (MessageBox.Show("Вы действительно хотите удалить запись " + id + "?", "Удаление ",
            if (MessageBox.Show("Вы действительно хотите удалить запись " + "?", "Удаление ",
                MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                return;
            else
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "DELETE FROM notebook WHERE id = @id";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                //MessageBox.Show("База данных обновлена. Данные отобразятся при следующем входе в базу данных.");
                dataGridView.DataSource = null;
                dataGridView.DataSource = vnotebookBindingSource;

                this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);
            }
            //this.Close();


        }

        private void dataGridView_DoubleClick(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows[index].Selected = true;

            string[] result = new string[dataGridView.ColumnCount];


            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                result[j] = Convert.ToString(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[j].Value);
            }


            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Red;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.White;


            Data_id.Value = Convert.ToInt32(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);// Id

            int f = 0;
            f = dataGridView.CurrentRow.Index;

            frm2.ShowDialog();
            dataGridView.DataSource = null;
            dataGridView.DataSource = vnotebookBindingSource;
            this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);
            if (f < dataGridView.RowCount)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[f].Selected = true;
                dataGridView.FirstDisplayedScrollingRowIndex = f;
                dataGridView.Update();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int index = dataGridView.CurrentCell.RowIndex;
            dataGridView.Rows[index].Selected = true;

            string[] result = new string[dataGridView.ColumnCount];


            for (int j = 0; j < dataGridView.ColumnCount; j++)
            {
                result[j] = Convert.ToString(dataGridView.Rows[dataGridView.CurrentCell.RowIndex].Cells[j].Value);
            }


            dataGridView.RowsDefaultCellStyle.SelectionForeColor = Color.Red;
            dataGridView.RowsDefaultCellStyle.SelectionBackColor = Color.White;


            Data_id.Value = Convert.ToInt32(dataGridView[0, dataGridView.CurrentCell.RowIndex].Value);// Id
            //int scrollPosition = dataGridView.FirstDisplayedScrollingRowIndex;
            int f = 0;
            f = dataGridView.CurrentRow.Index;

            //MessageBox.Show(f.ToString());
            frm2.ShowDialog();

            dataGridView.DataSource = null;
            dataGridView.DataSource = vnotebookBindingSource;
            this.vnotebookTableAdapter.Fill(this.notebookDataSet3.vnotebook);

            if (f < dataGridView.RowCount)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[f].Selected = true;
                dataGridView.FirstDisplayedScrollingRowIndex = f;
                dataGridView.Update();
            }
    //        dataGridView.CurrentCell.Selected = false;
            //dataGridView.CurrentCell = dataGridView.Rows[RowIndex].Cells[ColumnIndex];
  //          dataGridView.CurrentCell = dataGridView.Rows[5].Cells[1];
            //dataGridView.Rows[RowIndex].Cells[ColumnIndex].Selected = true;
//            dataGridView.Rows[5].Cells[1].Selected = true;

            //dataGridView.FirstDisplayedCell = dataGridView.Rows[dataGridView.Rows.Count - 1].Cells[0];
            //dataGridView.FirstDisplayedScrollingRowIndex = scrollPosition;
            //dataGridView.Refresh();
            
            //dataGridView.CurrentCell = dataGridView.Rows.Cells[0];
            /*
            if (f < dataGridView.RowCount)
            {
                dataGridView.ClearSelection();
                dataGridView.Rows[f].Selected = true;
                dataGridView.FirstDisplayedScrollingRowIndex = f;
                dataGridView.Update();
            } 
            */
        }
    }
}
