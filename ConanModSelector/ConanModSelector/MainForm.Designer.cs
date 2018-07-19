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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmdWriteModlist = new System.Windows.Forms.Button();
            this.clmPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmFilename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listMods = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // fbdConanPath
            // 
            this.fbdConanPath.RootFolder = System.Environment.SpecialFolder.MyComputer;
            // 
            // cmdConanPathBrowse
            // 
            this.cmdConanPathBrowse.Location = new System.Drawing.Point(315, 32);
            this.cmdConanPathBrowse.Name = "cmdConanPathBrowse";
            this.cmdConanPathBrowse.Size = new System.Drawing.Size(38, 20);
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
            this.txtConanPath.Size = new System.Drawing.Size(220, 20);
            this.txtConanPath.TabIndex = 2;
            this.txtConanPath.Text = "E:\\steamapps\\common\\Conan Exiles";
            this.txtConanPath.TextChanged += new System.EventHandler(this.txtConanPath_TextChanged);
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Location = new System.Drawing.Point(47, 61);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(36, 13);
            this.lblMods.TabIndex = 3;
            this.lblMods.Text = "Mods:";
            // 
            // txtMods
            // 
            this.txtMods.Location = new System.Drawing.Point(89, 58);
            this.txtMods.Name = "txtMods";
            this.txtMods.Size = new System.Drawing.Size(220, 20);
            this.txtMods.TabIndex = 4;
            this.txtMods.Text = "E:\\steamapps\\workshop\\content\\440900";
            this.txtMods.TextChanged += new System.EventHandler(this.txtMods_TextChanged);
            // 
            // cmdModsBrowse
            // 
            this.cmdModsBrowse.Location = new System.Drawing.Point(315, 58);
            this.cmdModsBrowse.Name = "cmdModsBrowse";
            this.cmdModsBrowse.Size = new System.Drawing.Size(38, 20);
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
            this.lblPreset.Location = new System.Drawing.Point(12, 9);
            this.lblPreset.Name = "lblPreset";
            this.lblPreset.Size = new System.Drawing.Size(64, 13);
            this.lblPreset.TabIndex = 9;
            this.lblPreset.Text = "Mod Preset:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(220, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // cmdWriteModlist
            // 
            this.cmdWriteModlist.Location = new System.Drawing.Point(359, 58);
            this.cmdWriteModlist.Name = "cmdWriteModlist";
            this.cmdWriteModlist.Size = new System.Drawing.Size(75, 20);
            this.cmdWriteModlist.TabIndex = 11;
            this.cmdWriteModlist.Text = "Write";
            this.cmdWriteModlist.UseVisualStyleBackColor = true;
            this.cmdWriteModlist.Click += new System.EventHandler(this.cmdWriteModlist_Click);
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
            this.clmFilename});
            this.listMods.Location = new System.Drawing.Point(12, 84);
            this.listMods.Name = "listMods";
            this.listMods.Size = new System.Drawing.Size(413, 383);
            this.listMods.TabIndex = 6;
            this.listMods.UseCompatibleStateImageBehavior = false;
            this.listMods.View = System.Windows.Forms.View.Details;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 479);
            this.Controls.Add(this.cmdWriteModlist);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPreset);
            this.Controls.Add(this.listMods);
            this.Controls.Add(this.cmdModsBrowse);
            this.Controls.Add(this.txtMods);
            this.Controls.Add(this.lblMods);
            this.Controls.Add(this.txtConanPath);
            this.Controls.Add(this.lblConanBrowse);
            this.Controls.Add(this.cmdConanPathBrowse);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Conan Mod Selector";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button cmdWriteModlist;
        private System.Windows.Forms.ColumnHeader clmPath;
        private System.Windows.Forms.ColumnHeader clmID;
        private System.Windows.Forms.ColumnHeader clmFilename;
        private System.Windows.Forms.ListView listMods;
    }
}

