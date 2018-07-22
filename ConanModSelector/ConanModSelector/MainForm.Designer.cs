namespace ConanModSelector
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fbdConanPath = new System.Windows.Forms.FolderBrowserDialog();
            this.lblMods = new System.Windows.Forms.Label();
            this.txtSteamPath = new System.Windows.Forms.TextBox();
            this.cmdModsBrowse = new System.Windows.Forms.Button();
            this.fbdModPath = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPreset = new System.Windows.Forms.Label();
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMods = new System.Windows.Forms.ListView();
            this.clmInstalled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCollectionURL = new System.Windows.Forms.TextBox();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.cmdDownload = new System.Windows.Forms.Button();
            this.prgDownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // fbdConanPath
            // 
            this.fbdConanPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Location = new System.Drawing.Point(13, 36);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(63, 13);
            this.lblMods.TabIndex = 3;
            this.lblMods.Text = "Steamapps:";
            // 
            // txtSteamPath
            // 
            this.txtSteamPath.Location = new System.Drawing.Point(89, 32);
            this.txtSteamPath.Name = "txtSteamPath";
            this.txtSteamPath.Size = new System.Drawing.Size(300, 20);
            this.txtSteamPath.TabIndex = 1;
            this.txtSteamPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps";
            // 
            // cmdModsBrowse
            // 
            this.cmdModsBrowse.Location = new System.Drawing.Point(395, 32);
            this.cmdModsBrowse.Name = "cmdModsBrowse";
            this.cmdModsBrowse.Size = new System.Drawing.Size(30, 20);
            this.cmdModsBrowse.TabIndex = 2;
            this.cmdModsBrowse.Text = "...";
            this.cmdModsBrowse.UseVisualStyleBackColor = true;
            this.cmdModsBrowse.Click += new System.EventHandler(this.cmdModsBrowse_Click);
            // 
            // fbdModPath
            // 
            this.fbdModPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // lblPreset
            // 
            this.lblPreset.AutoSize = true;
            this.lblPreset.Location = new System.Drawing.Point(2, 9);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(81, 13);
            this.lblPreset.TabIndex = 9;
            this.lblPreset.Text = "Collection URL:";
            // 
            // clmPath
            // 
            this.clmPath.Text = "Path";
            this.clmPath.Width = 101;
            // 
            // clmID
            // 
            this.clmID.Text = "ID";
            this.clmID.Width = 118;
            // 
            // clmFilename
            // 
            this.clmFilename.Text = "Filename";
            this.clmFilename.Width = 112;
            // 
            // listMods
            // 
            this.listMods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmPath,
            this.clmFilename,
            this.clmID,
            this.clmInstalled});
            this.listMods.Location = new System.Drawing.Point(12, 58);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(413, 263);
            this.listMods.TabIndex = 3;
            this.listMods.UseCompatibleStateImageBehavior = false;
            this.listMods.View = System.Windows.Forms.View.Details;
            // 
            // clmInstalled
            // 
            this.clmInstalled.Text = "Installed";
            // 
            // txtCollectionURL
            // 
            this.txtCollectionURL.Location = new System.Drawing.Point(89, 6);
            this.txtCollectionURL.Name = "txtCollectionURL";
            this.txtCollectionURL.Size = new System.Drawing.Size(336, 20);
            this.txtCollectionURL.TabIndex = 0;
            this.txtCollectionURL.Text = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
            this.txtCollectionURL.Leave += new System.EventHandler(this.txtCollectionURL_Leave);
            // 
            // cmdWrite
            // 
            this.cmdWrite.Location = new System.Drawing.Point(323, 327);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(94, 23);
            this.cmdWrite.TabIndex = 5;
            this.cmdWrite.Text = "Write modlist.txt";
            this.cmdWrite.UseVisualStyleBackColor = true;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // cmdDownload
            // 
            this.cmdDownload.Enabled = false;
            this.cmdDownload.Location = new System.Drawing.Point(188, 327);
            this.cmdDownload.Name = "cmdDownload";
            this.cmdDownload.Size = new System.Drawing.Size(129, 23);
            this.cmdDownload.TabIndex = 4;
            this.cmdDownload.Text = "Download uninstalled";
            this.cmdDownload.UseVisualStyleBackColor = true;
            this.cmdDownload.Click += new System.EventHandler(this.cmdDownload_Click);
            // 
            // prgDownload
            // 
            this.prgDownload.Enabled = false;
            this.prgDownload.Location = new System.Drawing.Point(12, 327);
            this.prgDownload.Name = "prgDownload";
            this.prgDownload.Size = new System.Drawing.Size(170, 23);
            this.prgDownload.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 351);
            this.Controls.Add(this.prgDownload);
            this.Controls.Add(this.cmdDownload);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.txtCollectionURL);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.listMods);
            this.Controls.Add(this.cmdModsBrowse);
            this.Controls.Add(this.txtSteamPath);
            this.Controls.Add(this.lblMods);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 390);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(445, 390);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conan Mod Selector";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog fbdConanPath;
        private System.Windows.Forms.Label lblMods;
        private System.Windows.Forms.TextBox txtSteamPath;
        private System.Windows.Forms.Button cmdModsBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbdModPath;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmFilename;
        private System.Windows.Forms.ListView listMods;
        private System.Windows.Forms.ColumnHeader clmInstalled;
        private System.Windows.Forms.TextBox txtCollectionURL;
        private System.Windows.Forms.Button cmdWrite;
        private System.Windows.Forms.Button cmdDownload;
        private System.Windows.Forms.ProgressBar prgDownload;
    }
}

