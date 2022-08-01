namespace ReadFromserial3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gboxComsetup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CBoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.CBoxBAUDRATE = new System.Windows.Forms.ComboBox();
            this.CBoxDATABITS = new System.Windows.Forms.ComboBox();
            this.CBoxSTOPBITS = new System.Windows.Forms.ComboBox();
            this.CBoxPARITYBITS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRefreshComport = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.chBoxRTSEnable = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chBoxDTREnable = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxConfig = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.labelCOMportstatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.btnDemo = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwrite = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_writelineOrWritetext = new System.Windows.Forms.ToolStripComboBox();
            this.btnSaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOPEN = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCLOSE = new System.Windows.Forms.ToolStripMenuItem();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearDataInReceiver = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnShowdataWith = new System.Windows.Forms.ToolStripComboBox();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox3 = new System.Windows.Forms.ToolStripComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tBoxDataIN = new System.Windows.Forms.TextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.datainlabel = new System.Windows.Forms.Label();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.lbDataInLength = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.gboxComsetup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.gboxComsetup);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnClearLog);
            this.groupBox1.Controls.Add(this.btnDemo);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 793);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM port Setup";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // gboxComsetup
            // 
            this.gboxComsetup.Controls.Add(this.label1);
            this.gboxComsetup.Controls.Add(this.CBoxCOMPORT);
            this.gboxComsetup.Controls.Add(this.CBoxBAUDRATE);
            this.gboxComsetup.Controls.Add(this.CBoxDATABITS);
            this.gboxComsetup.Controls.Add(this.CBoxSTOPBITS);
            this.gboxComsetup.Controls.Add(this.CBoxPARITYBITS);
            this.gboxComsetup.Controls.Add(this.label2);
            this.gboxComsetup.Controls.Add(this.label3);
            this.gboxComsetup.Controls.Add(this.btnRefreshComport);
            this.gboxComsetup.Controls.Add(this.label4);
            this.gboxComsetup.Controls.Add(this.chBoxRTSEnable);
            this.gboxComsetup.Controls.Add(this.label5);
            this.gboxComsetup.Controls.Add(this.chBoxDTREnable);
            this.gboxComsetup.Location = new System.Drawing.Point(6, 25);
            this.gboxComsetup.Name = "gboxComsetup";
            this.gboxComsetup.Size = new System.Drawing.Size(315, 324);
            this.gboxComsetup.TabIndex = 21;
            this.gboxComsetup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Com port";
            // 
            // CBoxCOMPORT
            // 
            this.CBoxCOMPORT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxCOMPORT.FormattingEnabled = true;
            this.CBoxCOMPORT.Location = new System.Drawing.Point(128, 19);
            this.CBoxCOMPORT.Name = "CBoxCOMPORT";
            this.CBoxCOMPORT.Size = new System.Drawing.Size(177, 28);
            this.CBoxCOMPORT.TabIndex = 0;
            this.CBoxCOMPORT.SelectedIndexChanged += new System.EventHandler(this.CBoxCOMPORT_SelectedIndexChanged);
            this.CBoxCOMPORT.TextChanged += new System.EventHandler(this.CBoxCOMPORT_TextChanged);
            // 
            // CBoxBAUDRATE
            // 
            this.CBoxBAUDRATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxBAUDRATE.FormattingEnabled = true;
            this.CBoxBAUDRATE.Items.AddRange(new object[] {
            "110",
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "38400",
            "57600",
            "115200"});
            this.CBoxBAUDRATE.Location = new System.Drawing.Point(128, 89);
            this.CBoxBAUDRATE.Name = "CBoxBAUDRATE";
            this.CBoxBAUDRATE.Size = new System.Drawing.Size(177, 28);
            this.CBoxBAUDRATE.TabIndex = 1;
            this.CBoxBAUDRATE.TextChanged += new System.EventHandler(this.CBoxBAUDRATE_TextChanged);
            // 
            // CBoxDATABITS
            // 
            this.CBoxDATABITS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxDATABITS.FormattingEnabled = true;
            this.CBoxDATABITS.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CBoxDATABITS.Location = new System.Drawing.Point(128, 137);
            this.CBoxDATABITS.Name = "CBoxDATABITS";
            this.CBoxDATABITS.Size = new System.Drawing.Size(177, 28);
            this.CBoxDATABITS.TabIndex = 2;
            this.CBoxDATABITS.TextChanged += new System.EventHandler(this.CBoxDATABITS_TextChanged);
            // 
            // CBoxSTOPBITS
            // 
            this.CBoxSTOPBITS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxSTOPBITS.FormattingEnabled = true;
            this.CBoxSTOPBITS.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.CBoxSTOPBITS.Location = new System.Drawing.Point(128, 189);
            this.CBoxSTOPBITS.Name = "CBoxSTOPBITS";
            this.CBoxSTOPBITS.Size = new System.Drawing.Size(177, 28);
            this.CBoxSTOPBITS.TabIndex = 3;
            this.CBoxSTOPBITS.TextChanged += new System.EventHandler(this.CBoxSTOPBITS_TextChanged);
            // 
            // CBoxPARITYBITS
            // 
            this.CBoxPARITYBITS.AllowDrop = true;
            this.CBoxPARITYBITS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBoxPARITYBITS.FormattingEnabled = true;
            this.CBoxPARITYBITS.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.CBoxPARITYBITS.Location = new System.Drawing.Point(128, 241);
            this.CBoxPARITYBITS.Name = "CBoxPARITYBITS";
            this.CBoxPARITYBITS.Size = new System.Drawing.Size(175, 28);
            this.CBoxPARITYBITS.TabIndex = 4;
            this.CBoxPARITYBITS.SelectedIndexChanged += new System.EventHandler(this.CBoxPARITYBITS_SelectedIndexChanged);
            this.CBoxPARITYBITS.TextChanged += new System.EventHandler(this.CBoxPARITYBITS_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "BaudeRate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Databits";
            // 
            // btnRefreshComport
            // 
            this.btnRefreshComport.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRefreshComport.Location = new System.Drawing.Point(227, 51);
            this.btnRefreshComport.Name = "btnRefreshComport";
            this.btnRefreshComport.Size = new System.Drawing.Size(78, 32);
            this.btnRefreshComport.TabIndex = 15;
            this.btnRefreshComport.Text = "Refresh";
            this.btnRefreshComport.UseVisualStyleBackColor = true;
            this.btnRefreshComport.Click += new System.EventHandler(this.btnRefreshComport_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "StopBits";
            // 
            // chBoxRTSEnable
            // 
            this.chBoxRTSEnable.AutoSize = true;
            this.chBoxRTSEnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxRTSEnable.Location = new System.Drawing.Point(170, 283);
            this.chBoxRTSEnable.Name = "chBoxRTSEnable";
            this.chBoxRTSEnable.Size = new System.Drawing.Size(145, 24);
            this.chBoxRTSEnable.TabIndex = 11;
            this.chBoxRTSEnable.Text = "RTS ENABLE";
            this.chBoxRTSEnable.UseVisualStyleBackColor = true;
            this.chBoxRTSEnable.CheckedChanged += new System.EventHandler(this.chBoxRTSEnable_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "ParityBits";
            // 
            // chBoxDTREnable
            // 
            this.chBoxDTREnable.AutoSize = true;
            this.chBoxDTREnable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBoxDTREnable.Location = new System.Drawing.Point(11, 283);
            this.chBoxDTREnable.Name = "chBoxDTREnable";
            this.chBoxDTREnable.Size = new System.Drawing.Size(146, 24);
            this.chBoxDTREnable.TabIndex = 10;
            this.chBoxDTREnable.Text = "DTR ENABLE";
            this.chBoxDTREnable.UseVisualStyleBackColor = true;
            this.chBoxDTREnable.CheckedChanged += new System.EventHandler(this.chBoxDTREnable_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tboxConfig);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Location = new System.Drawing.Point(0, 551);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 225);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Configuration";
            // 
            // tboxConfig
            // 
            this.tboxConfig.Location = new System.Drawing.Point(46, 193);
            this.tboxConfig.Name = "tboxConfig";
            this.tboxConfig.ReadOnly = true;
            this.tboxConfig.Size = new System.Drawing.Size(226, 26);
            this.tboxConfig.TabIndex = 21;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.labelCOMportstatus);
            this.groupBox7.Location = new System.Drawing.Point(78, 24);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(172, 79);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "COM Port Status";
            // 
            // labelCOMportstatus
            // 
            this.labelCOMportstatus.AutoSize = true;
            this.labelCOMportstatus.Font = new System.Drawing.Font("Impact", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCOMportstatus.Location = new System.Drawing.Point(47, 34);
            this.labelCOMportstatus.Name = "labelCOMportstatus";
            this.labelCOMportstatus.Size = new System.Drawing.Size(60, 39);
            this.labelCOMportstatus.TabIndex = 0;
            this.labelCOMportstatus.Text = "OFF";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 109);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(319, 39);
            this.progressBar1.TabIndex = 2;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearLog.Location = new System.Drawing.Point(17, 443);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(120, 56);
            this.btnClearLog.TabIndex = 20;
            this.btnClearLog.Text = "Clear Log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearDataInReceiver_Click);
            // 
            // btnDemo
            // 
            this.btnDemo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDemo.Location = new System.Drawing.Point(175, 443);
            this.btnDemo.Name = "btnDemo";
            this.btnDemo.Size = new System.Drawing.Size(129, 56);
            this.btnDemo.TabIndex = 14;
            this.btnDemo.Text = "Graph";
            this.btnDemo.UseVisualStyleBackColor = true;
            this.btnDemo.Click += new System.EventHandler(this.btnDemo_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(17, 355);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 58);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Red;
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(175, 355);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 58);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.receiverToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 32);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.btnSaveFile,
            this.btnOpenFile,
            this.btnExit});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(59, 28);
            this.toolStripMenuItem2.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwrite,
            this.toolStripComboBox_writelineOrWritetext});
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(249, 34);
            this.openToolStripMenuItem1.Text = "Save To Txt File";
            // 
            // toolStripComboBox_appendOrOverwrite
            // 
            this.toolStripComboBox_appendOrOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwrite.Items.AddRange(new object[] {
            "Append Text",
            "Overwrite Text"});
            this.toolStripComboBox_appendOrOverwrite.Name = "toolStripComboBox_appendOrOverwrite";
            this.toolStripComboBox_appendOrOverwrite.Size = new System.Drawing.Size(121, 33);
            this.toolStripComboBox_appendOrOverwrite.DropDownClosed += new System.EventHandler(this.toolStripComboBox_appendOrOverwrite_DropDownClosed);
            // 
            // toolStripComboBox_writelineOrWritetext
            // 
            this.toolStripComboBox_writelineOrWritetext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_writelineOrWritetext.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_writelineOrWritetext.Items.AddRange(new object[] {
            "WriteLine",
            "Write"});
            this.toolStripComboBox_writelineOrWritetext.Name = "toolStripComboBox_writelineOrWritetext";
            this.toolStripComboBox_writelineOrWritetext.Size = new System.Drawing.Size(121, 33);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(249, 34);
            this.btnSaveFile.Text = "Save Log";
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(249, 34);
            this.btnOpenFile.Text = "Open Log File";
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnExit
            // 
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(249, 34);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOPEN,
            this.btnCLOSE});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 28);
            this.toolStripMenuItem1.Text = "COM Control";
            // 
            // btnOPEN
            // 
            this.btnOPEN.Name = "btnOPEN";
            this.btnOPEN.Size = new System.Drawing.Size(160, 34);
            this.btnOPEN.Text = "Open";
            this.btnOPEN.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // btnCLOSE
            // 
            this.btnCLOSE.Name = "btnCLOSE";
            this.btnCLOSE.Size = new System.Drawing.Size(160, 34);
            this.btnCLOSE.Text = "Close";
            this.btnCLOSE.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClearDataInReceiver,
            this.showDataWithToolStripMenuItem,
            this.dataFormatToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // btnClearDataInReceiver
            // 
            this.btnClearDataInReceiver.Name = "btnClearDataInReceiver";
            this.btnClearDataInReceiver.Size = new System.Drawing.Size(251, 34);
            this.btnClearDataInReceiver.Text = "Clear";
            this.btnClearDataInReceiver.Click += new System.EventHandler(this.btnClearDataInReceiver_Click);
            // 
            // showDataWithToolStripMenuItem
            // 
            this.showDataWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowdataWith});
            this.showDataWithToolStripMenuItem.Name = "showDataWithToolStripMenuItem";
            this.showDataWithToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.showDataWithToolStripMenuItem.Text = "Show Data With";
            // 
            // btnShowdataWith
            // 
            this.btnShowdataWith.Items.AddRange(new object[] {
            "Always Update",
            "Add to Old Data"});
            this.btnShowdataWith.Name = "btnShowdataWith";
            this.btnShowdataWith.Size = new System.Drawing.Size(121, 33);
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox3});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(251, 34);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // toolStripComboBox3
            // 
            this.toolStripComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox3.Items.AddRange(new object[] {
            "char",
            "Hex",
            "Binary",
            "Decimal"});
            this.toolStripComboBox3.Name = "toolStripComboBox3";
            this.toolStripComboBox3.Size = new System.Drawing.Size(121, 33);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contactToolStripMenuItem,
            this.btnHelp});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(79, 28);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // contactToolStripMenuItem
            // 
            this.contactToolStripMenuItem.Name = "contactToolStripMenuItem";
            this.contactToolStripMenuItem.Size = new System.Drawing.Size(179, 34);
            this.contactToolStripMenuItem.Text = "Contact";
            // 
            // btnHelp
            // 
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(179, 34);
            this.btnHelp.Text = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tBoxDataIN
            // 
            this.tBoxDataIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBoxDataIN.Location = new System.Drawing.Point(6, 25);
            this.tBoxDataIN.Multiline = true;
            this.tBoxDataIN.Name = "tBoxDataIN";
            this.tBoxDataIN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tBoxDataIN.Size = new System.Drawing.Size(477, 674);
            this.tBoxDataIN.TabIndex = 4;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.datainlabel);
            this.groupBox12.Location = new System.Drawing.Point(99, 698);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(145, 52);
            this.groupBox12.TabIndex = 10;
            this.groupBox12.TabStop = false;
            // 
            // datainlabel
            // 
            this.datainlabel.AutoSize = true;
            this.datainlabel.Location = new System.Drawing.Point(6, 21);
            this.datainlabel.Name = "datainlabel";
            this.datainlabel.Size = new System.Drawing.Size(136, 20);
            this.datainlabel.TabIndex = 0;
            this.datainlabel.Text = "Data IN length :";
            this.datainlabel.Click += new System.EventHandler(this.ta_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.lbDataInLength);
            this.groupBox11.Location = new System.Drawing.Point(250, 698);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(72, 53);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            // 
            // lbDataInLength
            // 
            this.lbDataInLength.AutoSize = true;
            this.lbDataInLength.Location = new System.Drawing.Point(17, 21);
            this.lbDataInLength.Name = "lbDataInLength";
            this.lbDataInLength.Size = new System.Drawing.Size(29, 20);
            this.lbDataInLength.TabIndex = 0;
            this.lbDataInLength.Text = "00";
            // 
            // groupBox10
            // 
            this.groupBox10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox10.Controls.Add(this.groupBox11);
            this.groupBox10.Controls.Add(this.groupBox12);
            this.groupBox10.Controls.Add(this.tBoxDataIN);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(360, 44);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(493, 793);
            this.groupBox10.TabIndex = 5;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Receiver Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(878, 849);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(933, 905);
            this.MinimumSize = new System.Drawing.Size(900, 900);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Huf-Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.gboxComsetup.ResumeLayout(false);
            this.gboxComsetup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CBoxCOMPORT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CBoxPARITYBITS;
        private System.Windows.Forms.ComboBox CBoxSTOPBITS;
        private System.Windows.Forms.ComboBox CBoxDATABITS;
        private System.Windows.Forms.ComboBox CBoxBAUDRATE;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chBoxRTSEnable;
        private System.Windows.Forms.CheckBox chBoxDTREnable;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnOPEN;
        private System.Windows.Forms.ToolStripMenuItem btnCLOSE;
        private System.Windows.Forms.ToolStripMenuItem btnClearDataInReceiver;
        private System.Windows.Forms.ToolStripMenuItem contactToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnHelp;
        private System.Windows.Forms.ToolStripMenuItem showDataWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox btnShowdataWith;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox3;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnSaveFile;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwrite;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_writelineOrWritetext;
        private System.Windows.Forms.ToolStripMenuItem btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnRefreshComport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxDataIN;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label datainlabel;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label lbDataInLength;
        private System.Windows.Forms.Button btnDemo;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.Label labelCOMportstatus;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox tboxConfig;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gboxComsetup;
    }
}

