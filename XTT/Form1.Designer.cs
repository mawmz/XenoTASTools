namespace XTT
{
    partial class mainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPanel));
            this.sidebarPanel = new System.Windows.Forms.Panel();
            this.pageResources = new System.Windows.Forms.Button();
            this.pageAbout = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pageFrameSnippets = new System.Windows.Forms.Button();
            this.btnSaveLoader = new System.Windows.Forms.Button();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.slLabel = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtLoad = new System.Windows.Forms.ComboBox();
            this.directoryLabel = new System.Windows.Forms.Label();
            this.labelLoad = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnBackupSave = new System.Windows.Forms.Button();
            this.labelBackup = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBackupName = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.labelLog = new System.Windows.Forms.Label();
            this.directorybox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sidebarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.sidebarPanel.Controls.Add(this.pageResources);
            this.sidebarPanel.Controls.Add(this.pageAbout);
            this.sidebarPanel.Controls.Add(this.button3);
            this.sidebarPanel.Controls.Add(this.pageFrameSnippets);
            this.sidebarPanel.Controls.Add(this.btnSaveLoader);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.Size = new System.Drawing.Size(267, 613);
            this.sidebarPanel.TabIndex = 0;
            this.sidebarPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pageResources
            // 
            this.pageResources.Location = new System.Drawing.Point(68, 565);
            this.pageResources.Margin = new System.Windows.Forms.Padding(4);
            this.pageResources.Name = "pageResources";
            this.pageResources.Size = new System.Drawing.Size(199, 47);
            this.pageResources.TabIndex = 4;
            this.pageResources.Text = "Resources";
            this.pageResources.UseVisualStyleBackColor = true;
            this.pageResources.Click += new System.EventHandler(this.pageResources_Click);
            // 
            // pageAbout
            // 
            this.pageAbout.Location = new System.Drawing.Point(0, 565);
            this.pageAbout.Margin = new System.Windows.Forms.Padding(4);
            this.pageAbout.Name = "pageAbout";
            this.pageAbout.Size = new System.Drawing.Size(71, 47);
            this.pageAbout.TabIndex = 3;
            this.pageAbout.Text = "About";
            this.pageAbout.UseVisualStyleBackColor = true;
            this.pageAbout.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(267, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pageFrameSnippets
            // 
            this.pageFrameSnippets.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageFrameSnippets.Location = new System.Drawing.Point(0, 47);
            this.pageFrameSnippets.Margin = new System.Windows.Forms.Padding(4);
            this.pageFrameSnippets.Name = "pageFrameSnippets";
            this.pageFrameSnippets.Size = new System.Drawing.Size(267, 47);
            this.pageFrameSnippets.TabIndex = 1;
            this.pageFrameSnippets.Text = "Frame Snippets";
            this.pageFrameSnippets.UseVisualStyleBackColor = true;
            this.pageFrameSnippets.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveLoader
            // 
            this.btnSaveLoader.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSaveLoader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveLoader.Location = new System.Drawing.Point(0, 0);
            this.btnSaveLoader.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveLoader.Name = "btnSaveLoader";
            this.btnSaveLoader.Size = new System.Drawing.Size(267, 47);
            this.btnSaveLoader.TabIndex = 0;
            this.btnSaveLoader.Text = "Save Loader";
            this.btnSaveLoader.UseVisualStyleBackColor = true;
            this.btnSaveLoader.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDirectory
            // 
            this.txtDirectory.Location = new System.Drawing.Point(303, 36);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(251, 22);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // slLabel
            // 
            this.slLabel.AutoSize = true;
            this.slLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slLabel.Location = new System.Drawing.Point(289, 119);
            this.slLabel.Name = "slLabel";
            this.slLabel.Size = new System.Drawing.Size(112, 22);
            this.slLabel.TabIndex = 3;
            this.slLabel.Text = "Save Loader";
            this.slLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(575, 30);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(175, 34);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtLoad
            // 
            this.txtLoad.FormattingEnabled = true;
            this.txtLoad.Location = new System.Drawing.Point(303, 172);
            this.txtLoad.Name = "txtLoad";
            this.txtLoad.Size = new System.Drawing.Size(766, 24);
            this.txtLoad.TabIndex = 1;
            this.txtLoad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // directoryLabel
            // 
            this.directoryLabel.AutoSize = true;
            this.directoryLabel.Location = new System.Drawing.Point(310, 17);
            this.directoryLabel.Name = "directoryLabel";
            this.directoryLabel.Size = new System.Drawing.Size(124, 16);
            this.directoryLabel.TabIndex = 5;
            this.directoryLabel.Text = "Save File Directory:";
            this.directoryLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // labelLoad
            // 
            this.labelLoad.AutoSize = true;
            this.labelLoad.Location = new System.Drawing.Point(310, 153);
            this.labelLoad.Name = "labelLoad";
            this.labelLoad.Size = new System.Drawing.Size(80, 16);
            this.labelLoad.TabIndex = 6;
            this.labelLoad.Text = "File to Load:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(894, 218);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(175, 34);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load Save";
            this.btnLoad.UseVisualStyleBackColor = true;
            // 
            // btnBackupSave
            // 
            this.btnBackupSave.Location = new System.Drawing.Point(894, 381);
            this.btnBackupSave.Name = "btnBackupSave";
            this.btnBackupSave.Size = new System.Drawing.Size(175, 34);
            this.btnBackupSave.TabIndex = 14;
            this.btnBackupSave.Text = "Backup Save";
            this.btnBackupSave.UseVisualStyleBackColor = true;
            // 
            // labelBackup
            // 
            this.labelBackup.AutoSize = true;
            this.labelBackup.Location = new System.Drawing.Point(310, 316);
            this.labelBackup.Name = "labelBackup";
            this.labelBackup.Size = new System.Drawing.Size(96, 16);
            this.labelBackup.TabIndex = 13;
            this.labelBackup.Text = "Backup Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(289, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Save Backup";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBackupName
            // 
            this.txtBackupName.Location = new System.Drawing.Point(303, 335);
            this.txtBackupName.Name = "txtBackupName";
            this.txtBackupName.Size = new System.Drawing.Size(766, 22);
            this.txtBackupName.TabIndex = 15;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(970, 30);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(99, 34);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lstLog
            // 
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 16;
            this.lstLog.Location = new System.Drawing.Point(303, 476);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(766, 100);
            this.lstLog.TabIndex = 17;
            // 
            // labelLog
            // 
            this.labelLog.AutoSize = true;
            this.labelLog.Location = new System.Drawing.Point(310, 457);
            this.labelLog.Name = "labelLog";
            this.labelLog.Size = new System.Drawing.Size(117, 16);
            this.labelLog.TabIndex = 18;
            this.labelLog.Text = "Load/Backup Log:";
            // 
            // directorybox
            // 
            this.directorybox.Location = new System.Drawing.Point(293, 17);
            this.directorybox.Name = "directorybox";
            this.directorybox.Size = new System.Drawing.Size(784, 54);
            this.directorybox.TabIndex = 19;
            this.directorybox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(293, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(784, 138);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(293, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(784, 139);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Location = new System.Drawing.Point(293, 457);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(794, 132);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // mainPanel
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1116, 613);
            this.Controls.Add(this.labelLog);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtBackupName);
            this.Controls.Add(this.btnBackupSave);
            this.Controls.Add(this.labelBackup);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.labelLoad);
            this.Controls.Add(this.directoryLabel);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.slLabel);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.txtLoad);
            this.Controls.Add(this.sidebarPanel);
            this.Controls.Add(this.directorybox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainPanel";
            this.Text = "XenoTAS Tools";
            this.sidebarPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sidebarPanel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button pageFrameSnippets;
        private System.Windows.Forms.Button btnSaveLoader;
        private System.Windows.Forms.Button pageAbout;
        private System.Windows.Forms.Button pageResources;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.Label slLabel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ComboBox txtLoad;
        private System.Windows.Forms.Label directoryLabel;
        private System.Windows.Forms.Label labelLoad;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnBackupSave;
        private System.Windows.Forms.Label labelBackup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBackupName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label labelLog;
        private System.Windows.Forms.GroupBox directorybox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

