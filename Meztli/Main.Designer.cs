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
            this.lblSerial = new System.Windows.Forms.Label();
            this.serialFrom = new System.Windows.Forms.NumericUpDown();
            this.lblFrom = new System.Windows.Forms.Label();
            this.serialTo = new System.Windows.Forms.NumericUpDown();
            this.btnPartsForm = new System.Windows.Forms.Button();
            this.lblTo = new System.Windows.Forms.Label();
            this.btnVendorCodes = new System.Windows.Forms.Button();
            this.lblNemeSys = new System.Windows.Forms.Label();
            this.lblPartDesc = new System.Windows.Forms.Label();
            this.lblDumpFolder = new System.Windows.Forms.Label();
            this.btnChangeLoc = new System.Windows.Forms.Button();
            this.lnkDumpFolder = new System.Windows.Forms.LinkLabel();
            this.lblSettings = new System.Windows.Forms.Label();
            this.lblFirstDivider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.lblFecha.Location = new System.Drawing.Point(63, 121);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(39, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "DATE:";
            // 
            // lblVendor
            // 
            this.lblVendor.AutoSize = true;
            this.lblVendor.ForeColor = System.Drawing.SystemColors.Window;
            this.lblVendor.Location = new System.Drawing.Point(19, 154);
            this.lblVendor.Name = "lblVendor";
            this.lblVendor.Size = new System.Drawing.Size(89, 13);
            this.lblVendor.TabIndex = 2;
            this.lblVendor.Text = "VENDOR CODE:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTurno.Location = new System.Drawing.Point(63, 189);
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
            this.cmbPart.SelectedValueChanged += new System.EventHandler(this.cmbPartChanged);
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(123, 115);
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
            this.cmbVendorCode.Location = new System.Drawing.Point(122, 151);
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
            this.cmbShift.Location = new System.Drawing.Point(123, 186);
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
            this.btnGenerate.Location = new System.Drawing.Point(149, 276);
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
            this.lblWarning.Location = new System.Drawing.Point(189, 338);
            this.lblWarning.Margin = new System.Windows.Forms.Padding(3);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblWarning.Size = new System.Drawing.Size(0, 19);
            this.lblWarning.TabIndex = 14;
            // 
            // lblSerial
            // 
            this.lblSerial.AutoSize = true;
            this.lblSerial.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSerial.Location = new System.Drawing.Point(64, 233);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(48, 13);
            this.lblSerial.TabIndex = 18;
            this.lblSerial.Text = "SERIAL:";
            // 
            // serialFrom
            // 
            this.serialFrom.Location = new System.Drawing.Point(122, 233);
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
            this.lblFrom.Location = new System.Drawing.Point(121, 218);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(38, 13);
            this.lblFrom.TabIndex = 20;
            this.lblFrom.Text = "FROM";
            // 
            // serialTo
            // 
            this.serialTo.Location = new System.Drawing.Point(278, 233);
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
            this.lblTo.Location = new System.Drawing.Point(275, 218);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(22, 13);
            this.lblTo.TabIndex = 23;
            this.lblTo.Text = "TO";
            // 
            // btnVendorCodes
            // 
            this.btnVendorCodes.BackColor = System.Drawing.Color.Gray;
            this.btnVendorCodes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVendorCodes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVendorCodes.ForeColor = System.Drawing.SystemColors.Window;
            this.btnVendorCodes.Location = new System.Drawing.Point(398, 151);
            this.btnVendorCodes.Name = "btnVendorCodes";
            this.btnVendorCodes.Size = new System.Drawing.Size(75, 23);
            this.btnVendorCodes.TabIndex = 24;
            this.btnVendorCodes.Text = "V. CODES";
            this.btnVendorCodes.UseVisualStyleBackColor = false;
            this.btnVendorCodes.Click += new System.EventHandler(this.btnVendorCodes_Click);
            // 
            // lblNemeSys
            // 
            this.lblNemeSys.AutoSize = true;
            this.lblNemeSys.ForeColor = System.Drawing.Color.DimGray;
            this.lblNemeSys.Location = new System.Drawing.Point(407, 538);
            this.lblNemeSys.Name = "lblNemeSys";
            this.lblNemeSys.Size = new System.Drawing.Size(91, 13);
            this.lblNemeSys.TabIndex = 25;
            this.lblNemeSys.Text = "© NemeSys 2021";
            // 
            // lblPartDesc
            // 
            this.lblPartDesc.AutoSize = true;
            this.lblPartDesc.ForeColor = System.Drawing.SystemColors.Window;
            this.lblPartDesc.Location = new System.Drawing.Point(124, 88);
            this.lblPartDesc.Name = "lblPartDesc";
            this.lblPartDesc.Size = new System.Drawing.Size(0, 13);
            this.lblPartDesc.TabIndex = 27;
            // 
            // lblDumpFolder
            // 
            this.lblDumpFolder.AutoSize = true;
            this.lblDumpFolder.ForeColor = System.Drawing.SystemColors.Window;
            this.lblDumpFolder.Location = new System.Drawing.Point(23, 437);
            this.lblDumpFolder.Name = "lblDumpFolder";
            this.lblDumpFolder.Size = new System.Drawing.Size(88, 13);
            this.lblDumpFolder.TabIndex = 29;
            this.lblDumpFolder.Text = "DUMP FOLDER:";
            // 
            // btnChangeLoc
            // 
            this.btnChangeLoc.BackColor = System.Drawing.Color.Gray;
            this.btnChangeLoc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChangeLoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLoc.ForeColor = System.Drawing.SystemColors.Window;
            this.btnChangeLoc.Location = new System.Drawing.Point(398, 432);
            this.btnChangeLoc.Name = "btnChangeLoc";
            this.btnChangeLoc.Size = new System.Drawing.Size(75, 23);
            this.btnChangeLoc.TabIndex = 30;
            this.btnChangeLoc.Text = "CHANGE";
            this.btnChangeLoc.UseVisualStyleBackColor = false;
            this.btnChangeLoc.Click += new System.EventHandler(this.button2_Click);
            // 
            // lnkDumpFolder
            // 
            this.lnkDumpFolder.AutoSize = true;
            this.lnkDumpFolder.LinkColor = System.Drawing.Color.Aqua;
            this.lnkDumpFolder.Location = new System.Drawing.Point(119, 437);
            this.lnkDumpFolder.Name = "lnkDumpFolder";
            this.lnkDumpFolder.Size = new System.Drawing.Size(83, 13);
            this.lnkDumpFolder.TabIndex = 31;
            this.lnkDumpFolder.TabStop = true;
            this.lnkDumpFolder.Text = "Dump folder link";
            this.lnkDumpFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.ForeColor = System.Drawing.SystemColors.Window;
            this.lblSettings.Location = new System.Drawing.Point(226, 385);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(61, 13);
            this.lblSettings.TabIndex = 32;
            this.lblSettings.Text = "SETTINGS";
            // 
            // lblFirstDivider
            // 
            this.lblFirstDivider.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblFirstDivider.Location = new System.Drawing.Point(12, 392);
            this.lblFirstDivider.Name = "lblFirstDivider";
            this.lblFirstDivider.Size = new System.Drawing.Size(194, 2);
            this.lblFirstDivider.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(304, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 2);
            this.label1.TabIndex = 34;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(510, 560);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFirstDivider);
            this.Controls.Add(this.lblSettings);
            this.Controls.Add(this.lnkDumpFolder);
            this.Controls.Add(this.btnChangeLoc);
            this.Controls.Add(this.lblDumpFolder);
            this.Controls.Add(this.lblPartDesc);
            this.Controls.Add(this.lblNemeSys);
            this.Controls.Add(this.btnVendorCodes);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.btnPartsForm);
            this.Controls.Add(this.serialTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.serialFrom);
            this.Controls.Add(this.lblSerial);
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
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.NumericUpDown serialFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.NumericUpDown serialTo;
        private System.Windows.Forms.Button btnPartsForm;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Button btnVendorCodes;
        private System.Windows.Forms.Label lblNemeSys;
        private System.Windows.Forms.Label lblPartDesc;
        private System.Windows.Forms.Label lblDumpFolder;
        private System.Windows.Forms.Button btnChangeLoc;
        private System.Windows.Forms.LinkLabel lnkDumpFolder;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblFirstDivider;
        private System.Windows.Forms.Label label1;
    }
}

