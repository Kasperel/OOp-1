
namespace OOp_1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToFileTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_appendOrOverwriteTxt = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripComboBox_writeOrOverwrite = new System.Windows.Forms.ToolStripComboBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transmitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.endLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox2 = new System.Windows.Forms.ToolStripComboBox();
            this.receiverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showDataWithToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timerSerialReceive = new System.Windows.Forms.Timer(this.components);
            this.timerChartAdd = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogConfig = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonwrite3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxpass99 = new System.Windows.Forms.TextBox();
            this.textBoxAH = new System.Windows.Forms.TextBox();
            this.textBoxAL = new System.Windows.Forms.TextBox();
            this.textBoxURV = new System.Windows.Forms.TextBox();
            this.textBoxLRV = new System.Windows.Forms.TextBox();
            this.textBoxTagname = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.labelAH = new System.Windows.Forms.Label();
            this.labelAL = new System.Windows.Forms.Label();
            this.labelURV = new System.Windows.Forms.Label();
            this.labelLRV = new System.Windows.Forms.Label();
            this.labelTagname = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpenFile = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxreadraw = new System.Windows.Forms.TextBox();
            this.textBoxreadstatus = new System.Windows.Forms.TextBox();
            this.textBoxreadscale = new System.Windows.Forms.TextBox();
            this.buttreadscaled = new System.Windows.Forms.Button();
            this.buttreadraw = new System.Windows.Forms.Button();
            this.buttreadstatus = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxVab = new System.Windows.Forms.ListBox();
            this.listBoxVb = new System.Windows.Forms.ListBox();
            this.listBoxVa = new System.Windows.Forms.ListBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxTextFile = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.buttonAddXY = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Vba = new System.Windows.Forms.Label();
            this.ComPort = new System.Windows.Forms.TabPage();
            this.buttReceive = new System.Windows.Forms.Button();
            this.buttsend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BoxBitrate = new System.Windows.Forms.ComboBox();
            this.BoxCOMPORT = new System.Windows.Forms.ComboBox();
            this.BoxDataInLength = new System.Windows.Forms.GroupBox();
            this.labelDataInLength = new System.Windows.Forms.Label();
            this.DataInLength = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.BoxDataOut = new System.Windows.Forms.TextBox();
            this.BoxdataInn = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbldataOUTLength = new System.Windows.Forms.Label();
            this.DataOutLength = new System.Windows.Forms.Label();
            this.COM = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.ComPort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.BoxDataInLength.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.COM.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.cOMControlToolStripMenuItem,
            this.transmitterToolStripMenuItem,
            this.receiverToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1220, 28);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToFileTxtToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToFileTxtToolStripMenuItem
            // 
            this.saveToFileTxtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_appendOrOverwriteTxt,
            this.toolStripComboBox_writeOrOverwrite});
            this.saveToFileTxtToolStripMenuItem.Name = "saveToFileTxtToolStripMenuItem";
            this.saveToFileTxtToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.saveToFileTxtToolStripMenuItem.Text = "Save to Txt File";
            // 
            // toolStripComboBox_appendOrOverwriteTxt
            // 
            this.toolStripComboBox_appendOrOverwriteTxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_appendOrOverwriteTxt.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_appendOrOverwriteTxt.Items.AddRange(new object[] {
            "Append txt",
            "OverWrite txt"});
            this.toolStripComboBox_appendOrOverwriteTxt.Name = "toolStripComboBox_appendOrOverwriteTxt";
            this.toolStripComboBox_appendOrOverwriteTxt.Size = new System.Drawing.Size(121, 28);
            // 
            // toolStripComboBox_writeOrOverwrite
            // 
            this.toolStripComboBox_writeOrOverwrite.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_writeOrOverwrite.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.toolStripComboBox_writeOrOverwrite.Items.AddRange(new object[] {
            "WriteLine ",
            "Write"});
            this.toolStripComboBox_writeOrOverwrite.Name = "toolStripComboBox_writeOrOverwrite";
            this.toolStripComboBox_writeOrOverwrite.Size = new System.Drawing.Size(121, 28);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(191, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // cOMControlToolStripMenuItem
            // 
            this.cOMControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.cOMControlToolStripMenuItem.Name = "cOMControlToolStripMenuItem";
            this.cOMControlToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.cOMControlToolStripMenuItem.Text = "COM Control";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(128, 26);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // transmitterToolStripMenuItem
            // 
            this.transmitterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.endLineToolStripMenuItem});
            this.transmitterToolStripMenuItem.Name = "transmitterToolStripMenuItem";
            this.transmitterToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.transmitterToolStripMenuItem.Text = "Transmitter";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // endLineToolStripMenuItem
            // 
            this.endLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox2});
            this.endLineToolStripMenuItem.Name = "endLineToolStripMenuItem";
            this.endLineToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.endLineToolStripMenuItem.Text = "End Line";
            // 
            // toolStripComboBox2
            // 
            this.toolStripComboBox2.Items.AddRange(new object[] {
            "None ",
            "Both ",
            "New Line",
            "Carrige Return"});
            this.toolStripComboBox2.Name = "toolStripComboBox2";
            this.toolStripComboBox2.Size = new System.Drawing.Size(121, 28);
            // 
            // receiverToolStripMenuItem
            // 
            this.receiverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem1,
            this.showDataWithToolStripMenuItem});
            this.receiverToolStripMenuItem.Name = "receiverToolStripMenuItem";
            this.receiverToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.receiverToolStripMenuItem.Text = "Receiver";
            // 
            // clearToolStripMenuItem1
            // 
            this.clearToolStripMenuItem1.Name = "clearToolStripMenuItem1";
            this.clearToolStripMenuItem1.Size = new System.Drawing.Size(199, 26);
            this.clearToolStripMenuItem1.Text = "Clear";
            this.clearToolStripMenuItem1.Click += new System.EventHandler(this.clearToolStripMenuItem1_Click);
            // 
            // showDataWithToolStripMenuItem
            // 
            this.showDataWithToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox1});
            this.showDataWithToolStripMenuItem.Name = "showDataWithToolStripMenuItem";
            this.showDataWithToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.showDataWithToolStripMenuItem.Text = "Show Data With";
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Items.AddRange(new object[] {
            "Always Update",
            "Add Too Old"});
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(121, 28);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 404);
            this.panel1.TabIndex = 13;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gray;
            this.tabPage3.Controls.Add(this.buttonwrite3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.textBoxpass99);
            this.tabPage3.Controls.Add(this.textBoxAH);
            this.tabPage3.Controls.Add(this.textBoxAL);
            this.tabPage3.Controls.Add(this.textBoxURV);
            this.tabPage3.Controls.Add(this.textBoxLRV);
            this.tabPage3.Controls.Add(this.textBoxTagname);
            this.tabPage3.Controls.Add(this.buttonRead);
            this.tabPage3.Controls.Add(this.labelAH);
            this.tabPage3.Controls.Add(this.labelAL);
            this.tabPage3.Controls.Add(this.labelURV);
            this.tabPage3.Controls.Add(this.labelLRV);
            this.tabPage3.Controls.Add(this.labelTagname);
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.buttonOpenFile);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1212, 627);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            // 
            // buttonwrite3
            // 
            this.buttonwrite3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonwrite3.Location = new System.Drawing.Point(39, 411);
            this.buttonwrite3.Name = "buttonwrite3";
            this.buttonwrite3.Size = new System.Drawing.Size(276, 55);
            this.buttonwrite3.TabIndex = 47;
            this.buttonwrite3.Text = "Write";
            this.buttonwrite3.UseVisualStyleBackColor = true;
            this.buttonwrite3.Click += new System.EventHandler(this.buttonwrite3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Enter Password To continue";
            // 
            // textBoxpass99
            // 
            this.textBoxpass99.Location = new System.Drawing.Point(364, 273);
            this.textBoxpass99.Multiline = true;
            this.textBoxpass99.Name = "textBoxpass99";
            this.textBoxpass99.Size = new System.Drawing.Size(240, 28);
            this.textBoxpass99.TabIndex = 45;
            // 
            // textBoxAH
            // 
            this.textBoxAH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAH.Location = new System.Drawing.Point(364, 231);
            this.textBoxAH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAH.Name = "textBoxAH";
            this.textBoxAH.Size = new System.Drawing.Size(240, 28);
            this.textBoxAH.TabIndex = 29;
            // 
            // textBoxAL
            // 
            this.textBoxAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAL.Location = new System.Drawing.Point(364, 187);
            this.textBoxAL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAL.Name = "textBoxAL";
            this.textBoxAL.Size = new System.Drawing.Size(240, 28);
            this.textBoxAL.TabIndex = 30;
            // 
            // textBoxURV
            // 
            this.textBoxURV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxURV.Location = new System.Drawing.Point(364, 150);
            this.textBoxURV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxURV.Name = "textBoxURV";
            this.textBoxURV.Size = new System.Drawing.Size(240, 28);
            this.textBoxURV.TabIndex = 27;
            // 
            // textBoxLRV
            // 
            this.textBoxLRV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLRV.Location = new System.Drawing.Point(364, 113);
            this.textBoxLRV.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLRV.Name = "textBoxLRV";
            this.textBoxLRV.Size = new System.Drawing.Size(240, 28);
            this.textBoxLRV.TabIndex = 25;
            // 
            // textBoxTagname
            // 
            this.textBoxTagname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTagname.Location = new System.Drawing.Point(364, 76);
            this.textBoxTagname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTagname.Name = "textBoxTagname";
            this.textBoxTagname.Size = new System.Drawing.Size(240, 28);
            this.textBoxTagname.TabIndex = 22;
            // 
            // buttonRead
            // 
            this.buttonRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRead.Location = new System.Drawing.Point(39, 473);
            this.buttonRead.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(276, 55);
            this.buttonRead.TabIndex = 33;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click_1);
            // 
            // labelAH
            // 
            this.labelAH.AutoSize = true;
            this.labelAH.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAH.Location = new System.Drawing.Point(35, 233);
            this.labelAH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAH.Name = "labelAH";
            this.labelAH.Size = new System.Drawing.Size(114, 25);
            this.labelAH.TabIndex = 38;
            this.labelAH.Text = "Alarm High";
            // 
            // labelAL
            // 
            this.labelAL.AutoSize = true;
            this.labelAL.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAL.Location = new System.Drawing.Point(34, 191);
            this.labelAL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAL.Name = "labelAL";
            this.labelAL.Size = new System.Drawing.Size(111, 25);
            this.labelAL.TabIndex = 37;
            this.labelAL.Text = "Alarm Low";
            // 
            // labelURV
            // 
            this.labelURV.AutoSize = true;
            this.labelURV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelURV.Location = new System.Drawing.Point(35, 152);
            this.labelURV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelURV.Name = "labelURV";
            this.labelURV.Size = new System.Drawing.Size(173, 25);
            this.labelURV.TabIndex = 36;
            this.labelURV.Text = "Upper range value";
            // 
            // labelLRV
            // 
            this.labelLRV.AutoSize = true;
            this.labelLRV.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLRV.Location = new System.Drawing.Point(35, 115);
            this.labelLRV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLRV.Name = "labelLRV";
            this.labelLRV.Size = new System.Drawing.Size(174, 25);
            this.labelLRV.TabIndex = 35;
            this.labelLRV.Text = "Lower range value";
            // 
            // labelTagname
            // 
            this.labelTagname.AutoSize = true;
            this.labelTagname.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTagname.Location = new System.Drawing.Point(35, 78);
            this.labelTagname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTagname.Name = "labelTagname";
            this.labelTagname.Size = new System.Drawing.Size(90, 25);
            this.labelTagname.TabIndex = 34;
            this.labelTagname.Text = "Tagname";
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(328, 473);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(276, 55);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Save File ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click_1);
            // 
            // buttonOpenFile
            // 
            this.buttonOpenFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpenFile.Location = new System.Drawing.Point(328, 411);
            this.buttonOpenFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpenFile.Name = "buttonOpenFile";
            this.buttonOpenFile.Size = new System.Drawing.Size(276, 55);
            this.buttonOpenFile.TabIndex = 15;
            this.buttonOpenFile.Text = "Open File";
            this.buttonOpenFile.UseVisualStyleBackColor = true;
            this.buttonOpenFile.Click += new System.EventHandler(this.buttonOpenFile_Click_1);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gray;
            this.tabPage2.Controls.Add(this.textBoxreadraw);
            this.tabPage2.Controls.Add(this.textBoxreadstatus);
            this.tabPage2.Controls.Add(this.textBoxreadscale);
            this.tabPage2.Controls.Add(this.buttreadscaled);
            this.tabPage2.Controls.Add(this.buttreadraw);
            this.tabPage2.Controls.Add(this.buttreadstatus);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.listBoxVab);
            this.tabPage2.Controls.Add(this.listBoxVb);
            this.tabPage2.Controls.Add(this.listBoxVa);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Controls.Add(this.textBoxTextFile);
            this.tabPage2.Controls.Add(this.textBoxY);
            this.tabPage2.Controls.Add(this.textBoxX);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.buttonReadFile);
            this.tabPage2.Controls.Add(this.buttonAddXY);
            this.tabPage2.Controls.Add(this.buttonStart);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.Vba);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1212, 627);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // textBoxreadraw
            // 
            this.textBoxreadraw.Location = new System.Drawing.Point(163, 95);
            this.textBoxreadraw.Multiline = true;
            this.textBoxreadraw.Name = "textBoxreadraw";
            this.textBoxreadraw.Size = new System.Drawing.Size(155, 55);
            this.textBoxreadraw.TabIndex = 42;
            this.textBoxreadraw.TextChanged += new System.EventHandler(this.textBoxreadraw_TextChanged);
            // 
            // textBoxreadstatus
            // 
            this.textBoxreadstatus.Location = new System.Drawing.Point(162, 172);
            this.textBoxreadstatus.Multiline = true;
            this.textBoxreadstatus.Name = "textBoxreadstatus";
            this.textBoxreadstatus.Size = new System.Drawing.Size(155, 55);
            this.textBoxreadstatus.TabIndex = 41;
            // 
            // textBoxreadscale
            // 
            this.textBoxreadscale.Location = new System.Drawing.Point(162, 18);
            this.textBoxreadscale.Multiline = true;
            this.textBoxreadscale.Name = "textBoxreadscale";
            this.textBoxreadscale.Size = new System.Drawing.Size(155, 55);
            this.textBoxreadscale.TabIndex = 40;
            this.textBoxreadscale.TextChanged += new System.EventHandler(this.textBoxreadscale_TextChanged);
            // 
            // buttreadscaled
            // 
            this.buttreadscaled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttreadscaled.Location = new System.Drawing.Point(8, 18);
            this.buttreadscaled.Name = "buttreadscaled";
            this.buttreadscaled.Size = new System.Drawing.Size(118, 36);
            this.buttreadscaled.TabIndex = 39;
            this.buttreadscaled.Text = "Readscaled";
            this.buttreadscaled.UseVisualStyleBackColor = true;
            this.buttreadscaled.Click += new System.EventHandler(this.buttreadscale_Click);
            // 
            // buttreadraw
            // 
            this.buttreadraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttreadraw.Location = new System.Drawing.Point(9, 95);
            this.buttreadraw.Name = "buttreadraw";
            this.buttreadraw.Size = new System.Drawing.Size(118, 36);
            this.buttreadraw.TabIndex = 38;
            this.buttreadraw.Text = "Readraw";
            this.buttreadraw.UseVisualStyleBackColor = true;
            this.buttreadraw.Click += new System.EventHandler(this.buttreadraw_Click);
            // 
            // buttreadstatus
            // 
            this.buttreadstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttreadstatus.Location = new System.Drawing.Point(8, 172);
            this.buttreadstatus.Name = "buttreadstatus";
            this.buttreadstatus.Size = new System.Drawing.Size(118, 36);
            this.buttreadstatus.TabIndex = 37;
            this.buttreadstatus.Text = "Readstatus";
            this.buttreadstatus.UseVisualStyleBackColor = true;
            this.buttreadstatus.Click += new System.EventHandler(this.buttreadstatus_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1058, 517);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 41);
            this.button1.TabIndex = 34;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxVab
            // 
            this.listBoxVab.FormattingEnabled = true;
            this.listBoxVab.ItemHeight = 16;
            this.listBoxVab.Location = new System.Drawing.Point(310, 293);
            this.listBoxVab.Name = "listBoxVab";
            this.listBoxVab.Size = new System.Drawing.Size(120, 212);
            this.listBoxVab.TabIndex = 33;
            // 
            // listBoxVb
            // 
            this.listBoxVb.FormattingEnabled = true;
            this.listBoxVb.ItemHeight = 16;
            this.listBoxVb.Location = new System.Drawing.Point(162, 293);
            this.listBoxVb.Name = "listBoxVb";
            this.listBoxVb.Size = new System.Drawing.Size(120, 212);
            this.listBoxVb.TabIndex = 32;
            // 
            // listBoxVa
            // 
            this.listBoxVa.FormattingEnabled = true;
            this.listBoxVa.ItemHeight = 16;
            this.listBoxVa.Location = new System.Drawing.Point(24, 293);
            this.listBoxVa.Name = "listBoxVa";
            this.listBoxVa.Size = new System.Drawing.Size(120, 212);
            this.listBoxVa.TabIndex = 31;
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            legend4.Title = "Test Legend";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(644, 131);
            this.chart1.Margin = new System.Windows.Forms.Padding(4);
            this.chart1.Name = "chart1";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Legend = "Legend1";
            series10.Name = "SeriesVa";
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "SeriesVb";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "SeriesVab";
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(545, 374);
            this.chart1.TabIndex = 30;
            this.chart1.TabStop = false;
            this.chart1.Text = "chart1";
            // 
            // textBoxTextFile
            // 
            this.textBoxTextFile.Location = new System.Drawing.Point(473, 293);
            this.textBoxTextFile.Multiline = true;
            this.textBoxTextFile.Name = "textBoxTextFile";
            this.textBoxTextFile.Size = new System.Drawing.Size(120, 212);
            this.textBoxTextFile.TabIndex = 29;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(195, 551);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(105, 22);
            this.textBoxY.TabIndex = 20;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(195, 523);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(105, 22);
            this.textBoxX.TabIndex = 21;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(119, 523);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 17);
            this.label13.TabIndex = 26;
            this.label13.Text = "X :";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 556);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(25, 17);
            this.label15.TabIndex = 27;
            this.label15.Text = "Y :";
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReadFile.Location = new System.Drawing.Point(781, 517);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(131, 41);
            this.buttonReadFile.TabIndex = 24;
            this.buttonReadFile.Text = "Read File";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click_1);
            // 
            // buttonAddXY
            // 
            this.buttonAddXY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddXY.Location = new System.Drawing.Point(644, 517);
            this.buttonAddXY.Name = "buttonAddXY";
            this.buttonAddXY.Size = new System.Drawing.Size(131, 41);
            this.buttonAddXY.TabIndex = 23;
            this.buttonAddXY.Text = "Add Point";
            this.buttonAddXY.UseVisualStyleBackColor = true;
            this.buttonAddXY.Click += new System.EventHandler(this.buttonAddXY_Click_1);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(921, 517);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(131, 41);
            this.buttonStart.TabIndex = 25;
            this.buttonStart.Text = "Start Auto";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(158, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 25);
            this.label14.TabIndex = 19;
            this.label14.Text = "Vb";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(20, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "Va";
            // 
            // Vba
            // 
            this.Vba.AutoSize = true;
            this.Vba.Font = new System.Drawing.Font("Times New Roman", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vba.Location = new System.Drawing.Point(306, 257);
            this.Vba.Name = "Vba";
            this.Vba.Size = new System.Drawing.Size(48, 25);
            this.Vba.TabIndex = 18;
            this.Vba.Text = "Vba";
            // 
            // ComPort
            // 
            this.ComPort.BackColor = System.Drawing.Color.Gray;
            this.ComPort.Controls.Add(this.buttReceive);
            this.ComPort.Controls.Add(this.buttsend);
            this.ComPort.Controls.Add(this.groupBox1);
            this.ComPort.Controls.Add(this.BoxDataInLength);
            this.ComPort.Controls.Add(this.groupBox9);
            this.ComPort.Controls.Add(this.groupBox7);
            this.ComPort.Location = new System.Drawing.Point(4, 25);
            this.ComPort.Name = "ComPort";
            this.ComPort.Padding = new System.Windows.Forms.Padding(3);
            this.ComPort.Size = new System.Drawing.Size(1212, 627);
            this.ComPort.TabIndex = 0;
            this.ComPort.Text = "tabPage1";
            // 
            // buttReceive
            // 
            this.buttReceive.Location = new System.Drawing.Point(429, 108);
            this.buttReceive.Name = "buttReceive";
            this.buttReceive.Size = new System.Drawing.Size(75, 23);
            this.buttReceive.TabIndex = 14;
            this.buttReceive.Text = "Receive";
            this.buttReceive.UseVisualStyleBackColor = true;
            this.buttReceive.Click += new System.EventHandler(this.buttReceive_Click);
            // 
            // buttsend
            // 
            this.buttsend.Location = new System.Drawing.Point(429, 46);
            this.buttsend.Name = "buttsend";
            this.buttsend.Size = new System.Drawing.Size(75, 23);
            this.buttsend.TabIndex = 13;
            this.buttsend.Text = "Send";
            this.buttsend.UseVisualStyleBackColor = true;
            this.buttsend.Click += new System.EventHandler(this.buttsend_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BoxBitrate);
            this.groupBox1.Controls.Add(this.BoxCOMPORT);
            this.groupBox1.Location = new System.Drawing.Point(17, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 351);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Control";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(160, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(129, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Disconnect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Century", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(23, 149);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "Connect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 98);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(266, 33);
            this.progressBar1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "BITRATE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "COM PORT";
            // 
            // BoxBitrate
            // 
            this.BoxBitrate.DisplayMember = "9600";
            this.BoxBitrate.FormattingEnabled = true;
            this.BoxBitrate.Items.AddRange(new object[] {
            "2400",
            "4800",
            "9600"});
            this.BoxBitrate.Location = new System.Drawing.Point(109, 56);
            this.BoxBitrate.Name = "BoxBitrate";
            this.BoxBitrate.Size = new System.Drawing.Size(180, 24);
            this.BoxBitrate.TabIndex = 1;
            this.BoxBitrate.Text = "9600";
            // 
            // BoxCOMPORT
            // 
            this.BoxCOMPORT.FormattingEnabled = true;
            this.BoxCOMPORT.Location = new System.Drawing.Point(109, 26);
            this.BoxCOMPORT.Name = "BoxCOMPORT";
            this.BoxCOMPORT.Size = new System.Drawing.Size(180, 24);
            this.BoxCOMPORT.TabIndex = 0;
            // 
            // BoxDataInLength
            // 
            this.BoxDataInLength.Controls.Add(this.labelDataInLength);
            this.BoxDataInLength.Controls.Add(this.DataInLength);
            this.BoxDataInLength.Location = new System.Drawing.Point(749, 297);
            this.BoxDataInLength.Name = "BoxDataInLength";
            this.BoxDataInLength.Size = new System.Drawing.Size(219, 79);
            this.BoxDataInLength.TabIndex = 12;
            this.BoxDataInLength.TabStop = false;
            // 
            // labelDataInLength
            // 
            this.labelDataInLength.AutoSize = true;
            this.labelDataInLength.Location = new System.Drawing.Point(135, 17);
            this.labelDataInLength.Name = "labelDataInLength";
            this.labelDataInLength.Size = new System.Drawing.Size(24, 17);
            this.labelDataInLength.TabIndex = 10;
            this.labelDataInLength.Text = "00";
            // 
            // DataInLength
            // 
            this.DataInLength.AutoSize = true;
            this.DataInLength.Location = new System.Drawing.Point(6, 18);
            this.DataInLength.Name = "DataInLength";
            this.DataInLength.Size = new System.Drawing.Size(103, 17);
            this.DataInLength.TabIndex = 9;
            this.DataInLength.Text = "Data IN Length";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.BoxDataOut);
            this.groupBox9.Controls.Add(this.BoxdataInn);
            this.groupBox9.Location = new System.Drawing.Point(510, 25);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(458, 272);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "MONITOR";
            // 
            // BoxDataOut
            // 
            this.BoxDataOut.Location = new System.Drawing.Point(25, 21);
            this.BoxDataOut.Name = "BoxDataOut";
            this.BoxDataOut.Size = new System.Drawing.Size(351, 22);
            this.BoxDataOut.TabIndex = 7;
            this.BoxDataOut.TextChanged += new System.EventHandler(this.BoxDataOut_TextChanged);
            // 
            // BoxdataInn
            // 
            this.BoxdataInn.Location = new System.Drawing.Point(16, 83);
            this.BoxdataInn.Multiline = true;
            this.BoxdataInn.Name = "BoxdataInn";
            this.BoxdataInn.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.BoxdataInn.Size = new System.Drawing.Size(436, 175);
            this.BoxdataInn.TabIndex = 8;
            this.BoxdataInn.WordWrap = false;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbldataOUTLength);
            this.groupBox7.Controls.Add(this.DataOutLength);
            this.groupBox7.Location = new System.Drawing.Point(510, 297);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(233, 79);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            // 
            // lbldataOUTLength
            // 
            this.lbldataOUTLength.AutoSize = true;
            this.lbldataOUTLength.Location = new System.Drawing.Point(151, 17);
            this.lbldataOUTLength.Name = "lbldataOUTLength";
            this.lbldataOUTLength.Size = new System.Drawing.Size(24, 17);
            this.lbldataOUTLength.TabIndex = 10;
            this.lbldataOUTLength.Text = "00";
            // 
            // DataOutLength
            // 
            this.DataOutLength.AutoSize = true;
            this.DataOutLength.Location = new System.Drawing.Point(18, 18);
            this.DataOutLength.Name = "DataOutLength";
            this.DataOutLength.Size = new System.Drawing.Size(120, 17);
            this.DataOutLength.TabIndex = 9;
            this.DataOutLength.Text = "Data OUT Length";
            // 
            // COM
            // 
            this.COM.Controls.Add(this.ComPort);
            this.COM.Controls.Add(this.tabPage2);
            this.COM.Controls.Add(this.tabPage3);
            this.COM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.COM.Location = new System.Drawing.Point(0, 28);
            this.COM.Name = "COM";
            this.COM.SelectedIndex = 0;
            this.COM.Size = new System.Drawing.Size(1220, 656);
            this.COM.TabIndex = 29;
            this.COM.SelectedIndexChanged += new System.EventHandler(this.COM_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 684);
            this.Controls.Add(this.COM);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Com Port Serial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ComPort.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.BoxDataInLength.ResumeLayout(false);
            this.BoxDataInLength.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.COM.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transmitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem endLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox2;
        private System.Windows.Forms.ToolStripMenuItem receiverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showDataWithToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveToFileTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_appendOrOverwriteTxt;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_writeOrOverwrite;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timerSerialReceive;
        private System.Windows.Forms.Timer timerChartAdd;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogConfig;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonwrite3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxpass99;
        private System.Windows.Forms.TextBox textBoxAH;
        private System.Windows.Forms.TextBox textBoxAL;
        private System.Windows.Forms.TextBox textBoxURV;
        private System.Windows.Forms.TextBox textBoxLRV;
        private System.Windows.Forms.TextBox textBoxTagname;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Label labelAH;
        private System.Windows.Forms.Label labelAL;
        private System.Windows.Forms.Label labelURV;
        private System.Windows.Forms.Label labelLRV;
        private System.Windows.Forms.Label labelTagname;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpenFile;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxVab;
        private System.Windows.Forms.ListBox listBoxVb;
        private System.Windows.Forms.ListBox listBoxVa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxTextFile;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.Button buttonAddXY;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label Vba;
        private System.Windows.Forms.TabPage ComPort;
        private System.Windows.Forms.Button buttReceive;
        private System.Windows.Forms.Button buttsend;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxBitrate;
        private System.Windows.Forms.ComboBox BoxCOMPORT;
        private System.Windows.Forms.GroupBox BoxDataInLength;
        private System.Windows.Forms.Label labelDataInLength;
        private System.Windows.Forms.Label DataInLength;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox BoxDataOut;
        private System.Windows.Forms.TextBox BoxdataInn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lbldataOUTLength;
        private System.Windows.Forms.Label DataOutLength;
        private System.Windows.Forms.TabControl COM;
        private System.Windows.Forms.TextBox textBoxreadraw;
        private System.Windows.Forms.TextBox textBoxreadstatus;
        private System.Windows.Forms.TextBox textBoxreadscale;
        private System.Windows.Forms.Button buttreadscaled;
        private System.Windows.Forms.Button buttreadraw;
        private System.Windows.Forms.Button buttreadstatus;
    }
}

