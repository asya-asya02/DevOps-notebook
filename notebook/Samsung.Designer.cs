﻿namespace Vybor_noutbuka
{
    partial class Samsung
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
            this.notebookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nOTEBOOKDataSet = new Vybor_noutbuka.NOTEBOOKDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.notebookTableAdapter = new Vybor_noutbuka.NOTEBOOKDataSetTableAdapters.NotebookTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notebookDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parameters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTEBOOKDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.notebookDataGridViewTextBoxColumn,
            this.Parameters});
            this.dataGridView1.DataSource = this.notebookBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(307, 182);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // notebookBindingSource
            // 
            this.notebookBindingSource.DataMember = "Notebook";
            this.notebookBindingSource.DataSource = this.nOTEBOOKDataSet;
            // 
            // nOTEBOOKDataSet
            // 
            this.nOTEBOOKDataSet.DataSetName = "NOTEBOOKDataSet";
            this.nOTEBOOKDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(242, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // notebookTableAdapter
            // 
            this.notebookTableAdapter.ClearBeforeFill = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // notebookDataGridViewTextBoxColumn
            // 
            this.notebookDataGridViewTextBoxColumn.DataPropertyName = "Notebook";
            this.notebookDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.notebookDataGridViewTextBoxColumn.Name = "notebookDataGridViewTextBoxColumn";
            this.notebookDataGridViewTextBoxColumn.ReadOnly = true;
            this.notebookDataGridViewTextBoxColumn.Width = 250;
            // 
            // Parameters
            // 
            this.Parameters.DataPropertyName = "Parameters";
            this.Parameters.HeaderText = "Parameters";
            this.Parameters.Name = "Parameters";
            this.Parameters.ReadOnly = true;
            this.Parameters.Visible = false;
            // 
            // Samsung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 243);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Samsung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Samsung";
            this.Load += new System.EventHandler(this.Samsung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notebookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nOTEBOOKDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private NOTEBOOKDataSet nOTEBOOKDataSet;
        private System.Windows.Forms.BindingSource notebookBindingSource;
        private NOTEBOOKDataSetTableAdapters.NotebookTableAdapter notebookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notebookDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parameters;
    }
}