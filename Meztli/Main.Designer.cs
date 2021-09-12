namespace Meztli
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lblPart = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVendor = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.cmbPart = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cmbVendorCode = new System.Windows.Forms.ComboBox();
            this.cmbShift = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblWarning = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serialFrom = new System.Windows.Forms.NumericUpDown();
            this.lblFrom = new System.Windows.Forms.Label();
            this.serialTo = new System.Windows.Forms.NumericUpDown();
            this.btnPartsForm = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPart.Location = new System.Drawing.Point(63, 57);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(39, 13);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "PART:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFecha.Location = new System.Drawing.Point(63, 93);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "DATE:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVendor.Location = new System.Drawing.Point(19, 126);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(89, 13);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "VENDOR CODE:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTurno.Location = new System.Drawing.Point(63, 161);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(41, 13);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "SHIFT:";
            // 
            // cmbPart
            // 
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(122, 54);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(270, 21);
            this.cmbPart.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(123, 87);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(269, 20);
            this.dtpDate.TabIndex = 7;
            // 
            // cmbVendorCode
            // 
            this.cmbVendorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendorCode.FormattingEnabled = true;
            this.cmbVendorCode.Items.AddRange(new object[] {
            "TSPL"});
            this.cmbVendorCode.Location = new System.Drawing.Point(122, 123);
            this.cmbVendorCode.Name = "cmbVendorCode";
            this.cmbVendorCode.Size = new System.Drawing.Size(270, 21);
            this.cmbVendorCode.TabIndex = 8;
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "DAY",
            "NIGHT"});
            this.cmbShift.Location = new System.Drawing.Point(123, 158);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(177, 21);
            this.cmbShift.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerate.Location = new System.Drawing.Point(142, 252);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(214, 47);
            this.btnGenerate.TabIndex = 12;
            this.btnGenerate.Text = "GENERATE SERIES";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Crimson;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.Snow;
            this.lblWarning.Location = new System.Drawing.Point(182, 314);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(3);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(64, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "SERIAL";
            // 
            // serialFrom
            // 
            this.serialFrom.Location = new System.Drawing.Point(122, 205);
            this.serialFrom.Margin = new System.Windows.Forms.Padding(2);
            this.serialFrom.Maximum = new decimal(new int[] {
            2000000,
            0,
            0,
            0});
            this.serialFrom.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.serialFrom.Name = "serialFrom";
            this.serialFrom.Size = new System.Drawing.Size(102, 20);
            this.serialFrom.TabIndex = 19;
            this.serialFrom.Value = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFrom.Location = new System.Drawing.Point(121, 190);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 13);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "FROM";
            // 
            // serialTo
            // 
            this.serialTo.Location = new System.Drawing.Point(278, 205);
            this.serialTo.Margin = new System.Windows.Forms.Padding(2);
            this.serialTo.Maximum = new decimal(new int[] {
            2000001,
            0,
            0,
            0});
            this.serialTo.Minimum = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            this.serialTo.Name = "serialTo";
            this.serialTo.Size = new System.Drawing.Size(114, 20);
            this.serialTo.TabIndex = 21;
            this.serialTo.Value = new decimal(new int[] {
            1000001,
            0,
            0,
            0});
            // 
            // btnPartsForm
            // 
            this.btnPartsForm.BackColor = System.Drawing.Color.Gray;
            this.btnPartsForm.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPartsForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPartsForm.ForeColor = System.Drawing.SystemColors.Window;
            this.btnPartsForm.Location = new System.Drawing.Point(398, 52);
            this.btnPartsForm.Name = "btnPartsForm";
            this.btnPartsForm.Size = new System.Drawing.Size(75, 23);
            this.btnPartsForm.TabIndex = 22;
            this.btnPartsForm.Text = "PARTS";
            this.btnPartsForm.UseVisualStyleBackColor = false;
            this.btnPartsForm.Click += new System.EventHandler(this.btnPartsForm_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTo.Location = new System.Drawing.Point(275, 190);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 13);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "TO";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(510, 369);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnPartsForm);
            this.Controls.Add(this.serialTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.serialFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.cmbShift);
            this.Controls.Add(this.cmbVendorCode);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.cmbPart);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.lblVendor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblPart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MEZTLI";
            ((System.ComponentModel.ISupportInitialize)(this.serialFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPart;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVendor;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.ComboBox cmbPart;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cmbVendorCode;
        private System.Windows.Forms.ComboBox cmbShift;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown serialFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown serialTo;
        private System.Windows.Forms.Button btnPartsForm;
        private System.Windows.Forms.Label lblTo;
    }
}

