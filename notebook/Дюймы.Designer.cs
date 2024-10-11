namespace Vybor_noutbuka
{
    partial class Дюймы
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.diagonalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddiagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagonalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookDataSet3 = new Vybor_noutbuka.notebookDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.diagonalTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.DiagonalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagonalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.diagonalDataGridViewTextBoxColumn,
            this.iddiagDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.diagonalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(159, 166);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // diagonalDataGridViewTextBoxColumn
            // 
            this.diagonalDataGridViewTextBoxColumn.DataPropertyName = "Diagonal";
            this.diagonalDataGridViewTextBoxColumn.HeaderText = "Diagonal";
            this.diagonalDataGridViewTextBoxColumn.Name = "diagonalDataGridViewTextBoxColumn";
            this.diagonalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iddiagDataGridViewTextBoxColumn
            // 
            this.iddiagDataGridViewTextBoxColumn.DataPropertyName = "id_diag";
            this.iddiagDataGridViewTextBoxColumn.HeaderText = "id_diag";
            this.iddiagDataGridViewTextBoxColumn.Name = "iddiagDataGridViewTextBoxColumn";
            this.iddiagDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddiagDataGridViewTextBoxColumn.Visible = false;
            // 
            // diagonalBindingSource
            // 
            this.diagonalBindingSource.DataMember = "Diagonal";
            this.diagonalBindingSource.DataSource = this.notebookDataSet3;
            // 
            // notebookDataSet3
            // 
            this.notebookDataSet3.DataSetName = "notebookDataSet3";
            this.notebookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(112, 184);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // diagonalTableAdapter
            // 
            this.diagonalTableAdapter.ClearBeforeFill = true;
            // 
            // Дюймы
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(178, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Дюймы";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Дюймы";
            this.Load += new System.EventHandler(this.Дюймы_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diagonalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private notebookDataSet3 notebookDataSet3;
        private System.Windows.Forms.BindingSource diagonalBindingSource;
        private notebookDataSet3TableAdapters.DiagonalTableAdapter diagonalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagonalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddiagDataGridViewTextBoxColumn;
    }
}