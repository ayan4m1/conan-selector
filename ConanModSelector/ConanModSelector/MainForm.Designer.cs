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
            this.fbdConanPath = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdConanPathBrowse = new System.Windows.Forms.Button();
            this.lblConanBrowse = new System.Windows.Forms.Label();
            this.txtConanPath = new System.Windows.Forms.TextBox();
            this.lblMods = new System.Windows.Forms.Label();
            this.txtMods = new System.Windows.Forms.TextBox();
            this.cmdModsBrowse = new System.Windows.Forms.Button();
            this.fbdModPath = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPreset = new System.Windows.Forms.Label();
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMods = new System.Windows.Forms.ListView();
            this.clmInstalled = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCollectionURL = new System.Windows.Forms.TextBox();
            this.cmdReadMods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fbdConanPath
            // 
            this.fbdConanPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // cmdConanPathBrowse
            // 
            this.cmdConanPathBrowse.Location = new System.Drawing.Point(395, 32);
            this.cmdConanPathBrowse.Name = "cmdConanPathBrowse";
            this.cmdConanPathBrowse.Size = new System.Drawing.Size(30, 20);
            this.cmdConanPathBrowse.TabIndex = 0;
            this.cmdConanPathBrowse.Text = "...";
            this.cmdConanPathBrowse.UseVisualStyleBackColor = true;
            this.cmdConanPathBrowse.Click += new System.EventHandler(this.cmdConanPathBrowse_Click);
            // 
            // lblConanBrowse
            // 
            this.lblConanBrowse.AutoSize = true;
            this.lblConanBrowse.Location = new System.Drawing.Point(12, 35);
            this.lblConanBrowse.Name = "lblConanBrowse";
            this.lblConanBrowse.Size = new System.Drawing.Size(71, 13);
            this.lblConanBrowse.TabIndex = 1;
            this.lblConanBrowse.Text = "Conan Install:";
            // 
            // txtConanPath
            // 
            this.txtConanPath.Location = new System.Drawing.Point(89, 32);
            this.txtConanPath.Name = "txtConanPath";
            this.txtConanPath.Size = new System.Drawing.Size(300, 20);
            this.txtConanPath.TabIndex = 2;
            this.txtConanPath.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Conan Exiles";
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Location = new System.Drawing.Point(13, 62);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(70, 13);
            this.lblMods.TabIndex = 3;
            this.lblMods.Text = "Conan Mods:";
            // 
            // txtMods
            // 
            this.txtMods.Location = new System.Drawing.Point(89, 58);
            this.txtMods.Name = "txtMods";
            this.txtMods.Size = new System.Drawing.Size(300, 20);
            this.txtMods.TabIndex = 4;
            this.txtMods.Text = "C:\\Program Files (x86)\\Steam\\steamapps\\workshop\\content\\440900";
            // 
            // cmdModsBrowse
            // 
            this.cmdModsBrowse.Location = new System.Drawing.Point(395, 58);
            this.cmdModsBrowse.Name = "cmdModsBrowse";
            this.cmdModsBrowse.Size = new System.Drawing.Size(30, 20);
            this.cmdModsBrowse.TabIndex = 5;
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
            this.clmID,
            this.clmFilename,
            this.clmInstalled});
            this.listMods.Location = new System.Drawing.Point(12, 110);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(413, 237);
            this.listMods.TabIndex = 6;
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
            this.txtCollectionURL.TabIndex = 12;
            this.txtCollectionURL.Text = "https://steamcommunity.com/sharedfiles/filedetails/?id=";
            this.txtCollectionURL.Leave += new System.EventHandler(this.txtCollectionURL_Leave);
            // 
            // cmdReadMods
            // 
            this.cmdReadMods.Location = new System.Drawing.Point(327, 84);
            this.cmdReadMods.Name = "cmdReadMods";
            this.cmdReadMods.Size = new System.Drawing.Size(98, 20);
            this.cmdReadMods.TabIndex = 13;
            this.cmdReadMods.Text = "Write modlist.txt";
            this.cmdReadMods.UseVisualStyleBackColor = true;
            this.cmdReadMods.Click += new System.EventHandler(this.cmdReadMods_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 351);
            this.Controls.Add(this.cmdReadMods);
            this.Controls.Add(this.txtCollectionURL);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.listMods);
            this.Controls.Add(this.cmdModsBrowse);
            this.Controls.Add(this.txtMods);
            this.Controls.Add(this.lblMods);
            this.Controls.Add(this.txtConanPath);
            this.Controls.Add(this.lblConanBrowse);
            this.Controls.Add(this.cmdConanPathBrowse);
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
        private System.Windows.Forms.Button cmdConanPathBrowse;
        private System.Windows.Forms.Label lblConanBrowse;
        private System.Windows.Forms.TextBox txtConanPath;
        private System.Windows.Forms.Label lblMods;
        private System.Windows.Forms.TextBox txtMods;
        private System.Windows.Forms.Button cmdModsBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbdModPath;
        private System.Windows.Forms.Label lblPreset;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmFilename;
        private System.Windows.Forms.ListView listMods;
        private System.Windows.Forms.ColumnHeader clmInstalled;
        private System.Windows.Forms.TextBox txtCollectionURL;
        private System.Windows.Forms.Button cmdReadMods;
    }
}

