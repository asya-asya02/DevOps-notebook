namespace Vybor_noutbuka
{
    partial class hdd
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
            this.hDDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idhddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hDDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.notebookDataSet3 = new Vybor_noutbuka.notebookDataSet3();
            this.button1 = new System.Windows.Forms.Button();
            this.hDDTableAdapter = new Vybor_noutbuka.notebookDataSet3TableAdapters.HDDTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).BeginInit();
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
            this.hDDDataGridViewTextBoxColumn,
            this.idhddDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hDDBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(128, 207);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hDDDataGridViewTextBoxColumn
            // 
            this.hDDDataGridViewTextBoxColumn.DataPropertyName = "HDD";
            this.hDDDataGridViewTextBoxColumn.HeaderText = "HDD";
            this.hDDDataGridViewTextBoxColumn.Name = "hDDDataGridViewTextBoxColumn";
            this.hDDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idhddDataGridViewTextBoxColumn
            // 
            this.idhddDataGridViewTextBoxColumn.DataPropertyName = "id_hdd";
            this.idhddDataGridViewTextBoxColumn.HeaderText = "id_hdd";
            this.idhddDataGridViewTextBoxColumn.Name = "idhddDataGridViewTextBoxColumn";
            this.idhddDataGridViewTextBoxColumn.ReadOnly = true;
            this.idhddDataGridViewTextBoxColumn.Visible = false;
            // 
            // hDDBindingSource
            // 
            this.hDDBindingSource.DataMember = "HDD";
            this.hDDBindingSource.DataSource = this.notebookDataSet3;
            // 
            // notebookDataSet3
            // 
            this.notebookDataSet3.DataSetName = "notebookDataSet3";
            this.notebookDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 222);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 22);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hDDTableAdapter
            // 
            this.hDDTableAdapter.ClearBeforeFill = true;
            // 
            // hdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 250);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "hdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Объем_жесткий_диск";
            this.Load += new System.EventHandler(this.hdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hDDBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookDataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private notebookDataSet3 notebookDataSet3;
        private System.Windows.Forms.BindingSource hDDBindingSource;
        private notebookDataSet3TableAdapters.HDDTableAdapter hDDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hDDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idhddDataGridViewTextBoxColumn;
    }
}