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
            this.btnVendorCodes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.serialFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPart
            // 
            this.lblPart.AutoSize = true;
            this.lblPart.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPart.Location = new System.Drawing.Point(94, 88);
            this.lblPart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPart.Name = "lblPart";
            this.lblPart.Size = new System.Drawing.Size(55, 20);
            this.lblPart.TabIndex = 0;
            this.lblPart.Text = "PART:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFecha.Location = new System.Drawing.Point(94, 143);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(56, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "DATE:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVendor.Location = new System.Drawing.Point(28, 194);
            this.lblVendor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(132, 20);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "VENDOR CODE:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTurno.Location = new System.Drawing.Point(94, 248);
            this.lblTurno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(60, 20);
            this.lblTurno.TabIndex = 3;
            this.lblTurno.Text = "SHIFT:";
            // 
            // cmbPart
            // 
            this.cmbPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPart.FormattingEnabled = true;
            this.cmbPart.Location = new System.Drawing.Point(183, 83);
            this.cmbPart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbPart.Name = "cmbPart";
            this.cmbPart.Size = new System.Drawing.Size(403, 28);
            this.cmbPart.TabIndex = 6;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(184, 134);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(402, 26);
            this.dtpDate.TabIndex = 7;
            // 
            // cmbVendorCode
            // 
            this.cmbVendorCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVendorCode.FormattingEnabled = true;
            this.cmbVendorCode.Items.AddRange(new object[] {
            "TSPL"});
            this.cmbVendorCode.Location = new System.Drawing.Point(183, 189);
            this.cmbVendorCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVendorCode.Name = "cmbVendorCode";
            this.cmbVendorCode.Size = new System.Drawing.Size(403, 28);
            this.cmbVendorCode.TabIndex = 8;
            // 
            // cmbShift
            // 
            this.cmbShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShift.FormattingEnabled = true;
            this.cmbShift.Items.AddRange(new object[] {
            "DAY",
            "NIGHT"});
            this.cmbShift.Location = new System.Drawing.Point(184, 243);
            this.cmbShift.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbShift.Name = "cmbShift";
            this.cmbShift.Size = new System.Drawing.Size(264, 28);
            this.cmbShift.TabIndex = 9;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Gray;
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGenerate.Location = new System.Drawing.Point(213, 388);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(321, 72);
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
            this.lblWarning.Location = new System.Drawing.Point(273, 483);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.lblWarning.Size = new System.Drawing.Size(0, 30);
            this.lblWarning.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(96, 315);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "SERIAL";
            // 
            // serialFrom
            // 
            this.serialFrom.Location = new System.Drawing.Point(183, 315);
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
            this.serialFrom.Size = new System.Drawing.Size(153, 26);
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
            this.lblFrom.Location = new System.Drawing.Point(182, 292);
            this.lblFrom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(56, 20);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "FROM";
            // 
            // serialTo
            // 
            this.serialTo.Location = new System.Drawing.Point(417, 315);
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
            this.serialTo.Size = new System.Drawing.Size(171, 26);
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
            this.btnPartsForm.Location = new System.Drawing.Point(597, 80);
            this.btnPartsForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPartsForm.Name = "btnPartsForm";
            this.btnPartsForm.Size = new System.Drawing.Size(112, 35);
            this.btnPartsForm.TabIndex = 22;
            this.btnPartsForm.Text = "PARTS";
            this.btnPartsForm.UseVisualStyleBackColor = false;
            this.btnPartsForm.Click += new System.EventHandler(this.btnPartsForm_Click);
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTo.Location = new System.Drawing.Point(412, 292);
            this.lblTo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(30, 20);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "TO";
            // 
            // btnVendorCodes
            // 
            this.btnVendorCodes.BackColor = System.Drawing.Color.Gray;
            this.btnVendorCodes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVendorCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendorCodes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVendorCodes.Location = new System.Drawing.Point(597, 189);
            this.btnVendorCodes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVendorCodes.Name = "btnVendorCodes";
            this.btnVendorCodes.Size = new System.Drawing.Size(112, 35);
            this.btnVendorCodes.TabIndex = 24;
            this.btnVendorCodes.Text = "V. CODES";
            this.btnVendorCodes.UseVisualStyleBackColor = false;
            this.btnVendorCodes.Click += new System.EventHandler(this.btnVendorCodes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(610, 534);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "© NemeSys 2021";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(765, 568);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnVendorCodes);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button btnVendorCodes;
        private System.Windows.Forms.Label label2;
    }
}

