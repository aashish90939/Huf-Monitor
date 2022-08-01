namespace ReadFromserial3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExitmenu = new System.Windows.Forms.ToolStripMenuItem();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.plotView2 = new OxyPlot.WindowsForms.PlotView();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tboxlogdatafile = new System.Windows.Forms.TextBox();
            this.chboxOffline = new System.Windows.Forms.CheckBox();
            this.btnOpenlog = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxconfiguration = new System.Windows.Forms.TextBox();
            this.btnStopmonitor = new System.Windows.Forms.Button();
            this.btnStartmonitor = new System.Windows.Forms.Button();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.Channel = new System.Windows.Forms.GroupBox();
            this.btnChannelSettings = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.channel6 = new System.Windows.Forms.CheckBox();
            this.channel5 = new System.Windows.Forms.CheckBox();
            this.channel4 = new System.Windows.Forms.CheckBox();
            this.channel3 = new System.Windows.Forms.CheckBox();
            this.channel2 = new System.Windows.Forms.CheckBox();
            this.channel1 = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Channel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.printToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.btnExitmenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1443, 32);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphSetupToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(59, 28);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // graphSetupToolStripMenuItem
            // 
            this.graphSetupToolStripMenuItem.Name = "graphSetupToolStripMenuItem";
            this.graphSetupToolStripMenuItem.Size = new System.Drawing.Size(222, 34);
            this.graphSetupToolStripMenuItem.Text = "Graph Setup";
            this.graphSetupToolStripMenuItem.Click += new System.EventHandler(this.graphSetupToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // btnExitmenu
            // 
            this.btnExitmenu.Name = "btnExitmenu";
            this.btnExitmenu.Size = new System.Drawing.Size(60, 28);
            this.btnExitmenu.Text = "Exit";
            this.btnExitmenu.Click += new System.EventHandler(this.btnExitmenu_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // plotView2
            // 
            this.plotView2.Location = new System.Drawing.Point(395, 197);
            this.plotView2.Name = "plotView2";
            this.plotView2.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView2.Size = new System.Drawing.Size(8, 8);
            this.plotView2.TabIndex = 5;
            this.plotView2.Text = "plotView2";
            this.plotView2.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView2.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView2.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tboxlogdatafile);
            this.panel1.Controls.Add(this.chboxOffline);
            this.panel1.Controls.Add(this.btnOpenlog);
            this.panel1.Controls.Add(this.flowLayoutPanel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(10, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(255, 335);
            this.panel1.TabIndex = 6;
            // 
            // tboxlogdatafile
            // 
            this.tboxlogdatafile.Location = new System.Drawing.Point(12, 297);
            this.tboxlogdatafile.Name = "tboxlogdatafile";
            this.tboxlogdatafile.Size = new System.Drawing.Size(227, 26);
            this.tboxlogdatafile.TabIndex = 11;
            // 
            // chboxOffline
            // 
            this.chboxOffline.AutoSize = true;
            this.chboxOffline.Location = new System.Drawing.Point(139, 263);
            this.chboxOffline.Name = "chboxOffline";
            this.chboxOffline.Size = new System.Drawing.Size(113, 24);
            this.chboxOffline.TabIndex = 10;
            this.chboxOffline.Text = "checkBox2";
            this.chboxOffline.UseVisualStyleBackColor = true;
            // 
            // btnOpenlog
            // 
            this.btnOpenlog.Location = new System.Drawing.Point(12, 263);
            this.btnOpenlog.Name = "btnOpenlog";
            this.btnOpenlog.Size = new System.Drawing.Size(112, 31);
            this.btnOpenlog.TabIndex = 9;
            this.btnOpenlog.Text = "Plot log data";
            this.btnOpenlog.UseVisualStyleBackColor = true;
            this.btnOpenlog.Click += new System.EventHandler(this.btnOpenlog_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(116, 527);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxconfiguration);
            this.groupBox1.Controls.Add(this.btnStopmonitor);
            this.groupBox1.Controls.Add(this.btnStartmonitor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 242);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings and Control";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Configuration";
            // 
            // tboxconfiguration
            // 
            this.tboxconfiguration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxconfiguration.Location = new System.Drawing.Point(6, 196);
            this.tboxconfiguration.Name = "tboxconfiguration";
            this.tboxconfiguration.ReadOnly = true;
            this.tboxconfiguration.Size = new System.Drawing.Size(215, 26);
            this.tboxconfiguration.TabIndex = 2;
            // 
            // btnStopmonitor
            // 
            this.btnStopmonitor.BackColor = System.Drawing.Color.Red;
            this.btnStopmonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStopmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopmonitor.Location = new System.Drawing.Point(17, 94);
            this.btnStopmonitor.Name = "btnStopmonitor";
            this.btnStopmonitor.Size = new System.Drawing.Size(169, 53);
            this.btnStopmonitor.TabIndex = 1;
            this.btnStopmonitor.Text = "Stop";
            this.btnStopmonitor.UseVisualStyleBackColor = false;
            this.btnStopmonitor.Click += new System.EventHandler(this.btnStopmonitor_Click_1);
            // 
            // btnStartmonitor
            // 
            this.btnStartmonitor.BackColor = System.Drawing.Color.YellowGreen;
            this.btnStartmonitor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStartmonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartmonitor.Location = new System.Drawing.Point(17, 25);
            this.btnStartmonitor.Name = "btnStartmonitor";
            this.btnStartmonitor.Size = new System.Drawing.Size(169, 53);
            this.btnStartmonitor.TabIndex = 0;
            this.btnStartmonitor.Text = "Start";
            this.btnStartmonitor.UseVisualStyleBackColor = false;
            this.btnStartmonitor.Click += new System.EventHandler(this.btnStartmonitor_Click_1);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("zedGraphControl1.BackgroundImage")));
            this.zedGraphControl1.Location = new System.Drawing.Point(284, 53);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(1146, 731);
            this.zedGraphControl1.TabIndex = 7;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // Channel
            // 
            this.Channel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Channel.Controls.Add(this.btnChannelSettings);
            this.Channel.Controls.Add(this.checkBox1);
            this.Channel.Controls.Add(this.channel6);
            this.Channel.Controls.Add(this.channel5);
            this.Channel.Controls.Add(this.channel4);
            this.Channel.Controls.Add(this.channel3);
            this.Channel.Controls.Add(this.channel2);
            this.Channel.Controls.Add(this.channel1);
            this.Channel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Channel.Location = new System.Drawing.Point(10, 407);
            this.Channel.Name = "Channel";
            this.Channel.Size = new System.Drawing.Size(255, 377);
            this.Channel.TabIndex = 8;
            this.Channel.TabStop = false;
            this.Channel.Text = "Channel Settings";
            this.Channel.Enter += new System.EventHandler(this.Channel_Enter);
            // 
            // btnChannelSettings
            // 
            this.btnChannelSettings.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnChannelSettings.Location = new System.Drawing.Point(18, 297);
            this.btnChannelSettings.Name = "btnChannelSettings";
            this.btnChannelSettings.Size = new System.Drawing.Size(194, 42);
            this.btnChannelSettings.TabIndex = 10;
            this.btnChannelSettings.Text = "Channel Settings";
            this.btnChannelSettings.UseVisualStyleBackColor = true;
            this.btnChannelSettings.Click += new System.EventHandler(this.graphSetupToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(29, 395);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 29);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // channel6
            // 
            this.channel6.AutoSize = true;
            this.channel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel6.Location = new System.Drawing.Point(6, 226);
            this.channel6.Name = "channel6";
            this.channel6.Size = new System.Drawing.Size(132, 29);
            this.channel6.TabIndex = 5;
            this.channel6.Text = "channel 6";
            this.channel6.UseVisualStyleBackColor = true;
            // 
            // channel5
            // 
            this.channel5.AutoSize = true;
            this.channel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel5.Location = new System.Drawing.Point(6, 191);
            this.channel5.Name = "channel5";
            this.channel5.Size = new System.Drawing.Size(132, 29);
            this.channel5.TabIndex = 4;
            this.channel5.Text = "channel 5";
            this.channel5.UseVisualStyleBackColor = true;
            // 
            // channel4
            // 
            this.channel4.AutoSize = true;
            this.channel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel4.Location = new System.Drawing.Point(6, 152);
            this.channel4.Name = "channel4";
            this.channel4.Size = new System.Drawing.Size(132, 29);
            this.channel4.TabIndex = 3;
            this.channel4.Text = "channel 4";
            this.channel4.UseVisualStyleBackColor = true;
            // 
            // channel3
            // 
            this.channel3.AutoSize = true;
            this.channel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel3.Location = new System.Drawing.Point(6, 117);
            this.channel3.Name = "channel3";
            this.channel3.Size = new System.Drawing.Size(132, 29);
            this.channel3.TabIndex = 2;
            this.channel3.Text = "channel 3";
            this.channel3.UseVisualStyleBackColor = true;
            // 
            // channel2
            // 
            this.channel2.AutoSize = true;
            this.channel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel2.Location = new System.Drawing.Point(6, 81);
            this.channel2.Name = "channel2";
            this.channel2.Size = new System.Drawing.Size(132, 29);
            this.channel2.TabIndex = 1;
            this.channel2.Text = "channel 2";
            this.channel2.UseVisualStyleBackColor = true;
            // 
            // channel1
            // 
            this.channel1.AutoSize = true;
            this.channel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channel1.Location = new System.Drawing.Point(6, 46);
            this.channel1.Name = "channel1";
            this.channel1.Size = new System.Drawing.Size(126, 29);
            this.channel1.TabIndex = 0;
            this.channel1.Text = "channel1";
            this.channel1.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1443, 798);
            this.Controls.Add(this.Channel);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plotView2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1465, 855);
            this.MinimumSize = new System.Drawing.Size(1465, 854);
            this.Name = "Form2";
            this.Text = "Value Plotter";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Channel.ResumeLayout(false);
            this.Channel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnExitmenu;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Timer timer1;
        private OxyPlot.WindowsForms.PlotView plotView2;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStopmonitor;
        private System.Windows.Forms.Button btnStartmonitor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.GroupBox Channel;
        private System.Windows.Forms.CheckBox channel6;
        private System.Windows.Forms.CheckBox channel5;
        private System.Windows.Forms.CheckBox channel4;
        private System.Windows.Forms.CheckBox channel3;
        private System.Windows.Forms.CheckBox channel2;
        private System.Windows.Forms.CheckBox channel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnOpenlog;
        private System.Windows.Forms.CheckBox chboxOffline;
        private System.Windows.Forms.TextBox tboxlogdatafile;
        private System.Windows.Forms.ToolStripMenuItem graphSetupToolStripMenuItem;
        private System.Windows.Forms.TextBox tboxconfiguration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChannelSettings;
    }
}