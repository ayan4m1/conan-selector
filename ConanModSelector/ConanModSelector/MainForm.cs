using AngleSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ConanModSelector
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void cmdConanPathBrowse_Click(object sender, EventArgs e)
        {
            if (fbdConanPath.ShowDialog() == DialogResult.OK)
            {
                txtConanPath.Text = fbdConanPath.SelectedPath;
            }
        }

        private void cmdModsBrowse_Click(object sender, EventArgs e)
        {
            if (fbdModPath.ShowDialog() == DialogResult.OK)
            {
                txtMods.Text = fbdModPath.SelectedPath;
            }
        }

        private async void cmdReadMods_Click(object sender, EventArgs e)
        {
            var modListFile = Path.Combine(txtConanPath.Text, "ConanSandbox", "Mods", "modlist.txt");
            var config = Configuration.Default.WithDefaultLoader();
            cmdReadMods.Enabled = false;
            var doc = await BrowsingContext.New(config).OpenAsync(txtCollectionURL.Text);
            cmdReadMods.Enabled = true;
            var items = doc.QuerySelectorAll(".collectionItemDetails");

            if (items.Length == 0)
            {
                MessageBox.Show("No items found in collection!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var modName = "";
            var modListData = "";
            foreach (var item in items)
            {
                var title = item.QuerySelector(".workshopItemTitle").TextContent;
                var url = item.QuerySelector("a").Attributes["href"].Value;
                var id = url.Substring(url.LastIndexOf("=") + 1);
                var modPath = Path.Combine(txtMods.Text, id);
                var installed = Directory.Exists(modPath);

                var files = Directory.EnumerateFiles(modPath, "*.pak");
                if (files.Count() > 1)
                {
                    MessageBox.Show($"Warning: More than one .pak in {modPath}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                modPath = files.First();
                modName = Path.GetFileName(modPath);
                modListData += $"*{modPath}\r\n";

                listMods.Items.Add(new ListViewItem(new string[] { modPath, title, id, (installed) ? "Yes" : "No" }));
            }

            File.WriteAllText(modListFile, modListData);
            MessageBox.Show($"Wrote {listMods.Items.Count} mods to {modListFile}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
