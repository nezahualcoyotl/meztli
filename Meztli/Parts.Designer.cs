namespace Meztli
{
    partial class Parts
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
            this.partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meztlidbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.meztlidbDataSet = new Meztli.meztlidbDataSet();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.partTableAdapter = new Meztli.meztlidbDataSetTableAdapters.PartTableAdapter();
            this.btnDeleteRows = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // partBindingSource
            // 
            this.partBindingSource.DataMember = "Part";
            this.partBindingSource.DataSource = this.meztlidbDataSetBindingSource;
            // 
            // meztlidbDataSetBindingSource
            // 
            this.meztlidbDataSetBindingSource.DataSource = this.meztlidbDataSet;
            this.meztlidbDataSetBindingSource.Position = 0;
            // 
            // meztlidbDataSet
            // 
            this.meztlidbDataSet.DataSetName = "meztlidbDataSet";
            this.meztlidbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvParts
            // 
            this.dgvParts.AutoGenerateColumns = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.name});
            this.dgvParts.DataSource = this.partBindingSource;
            this.dgvParts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvParts.Location = new System.Drawing.Point(12, 12);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowHeadersWidth = 62;
            this.dgvParts.Size = new System.Drawing.Size(448, 361);
            this.dgvParts.TabIndex = 0;
            this.dgvParts.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Part number";
            this.numberDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.Width = 150;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Part name";
            this.name.Name = "name";
            this.name.Width = 200;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Location = new System.Drawing.Point(385, 386);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // partTableAdapter
            // 
            this.partTableAdapter.ClearBeforeFill = true;
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRows.Location = new System.Drawing.Point(12, 386);
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteRows.TabIndex = 2;
            this.btnDeleteRows.Text = "Delete row";
            this.btnDeleteRows.UseVisualStyleBackColor = true;
            this.btnDeleteRows.Click += new System.EventHandler(this.btnDeleteRows_Click);
            // 
            // Parts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 421);
            this.Controls.Add(this.btnDeleteRows);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dgvParts);
            this.Name = "Parts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.Parts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meztlidbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource meztlidbDataSetBindingSource;
        private meztlidbDataSet meztlidbDataSet;
        private System.Windows.Forms.BindingSource partBindingSource;
        private meztlidbDataSetTableAdapters.PartTableAdapter partTableAdapter;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.Button btnDeleteRows;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
    }
}