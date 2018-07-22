using AngleSharp;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
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

        private void txtCollectionURL_Leave(object sender, EventArgs e)
        {
            var validUri = Uri.IsWellFormedUriString(txtCollectionURL.Text, UriKind.Absolute);
            if (!validUri)
            {
                MessageBox.Show("Steam Collection URL is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCollectionURL.Focus();
                return;
            }

            var uri = new Uri(txtCollectionURL.Text);
            var queryString = HttpUtility.ParseQueryString(uri.Query);
            try
            {
                var collectionId = int.Parse(queryString["id"]);
            }
            catch (Exception)
            {
                MessageBox.Show("Steam Collection ID is not valid!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            populateModItems();
        }

        private async void populateModItems()
        {
            var config = Configuration.Default.WithDefaultLoader();
            var doc = await BrowsingContext.New(config).OpenAsync(txtCollectionURL.Text);
            var items = doc.QuerySelectorAll(".collectionItemDetails");
            var uninstalled = false;

            var modName = "";
            foreach (var item in items)
            {
                var title = item.QuerySelector(".workshopItemTitle").TextContent;
                var url = item.QuerySelector("a").Attributes["href"].Value;
                var id = url.Substring(url.LastIndexOf("=") + 1);
                var modPath = Path.Combine(txtMods.Text, id);
                var installed = Directory.Exists(modPath);
                if (!installed)
                {
                    uninstalled = true;
                }

                var files = Directory.EnumerateFiles(modPath, "*.pak");
                if (files.Count() > 1)
                {
                    MessageBox.Show($"Warning: More than one .pak in {modPath}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                modPath = files.First();
                modName = Path.GetFileName(modPath);

                listMods.Items.Add(new ListViewItem(new string[] { modPath, title, id, (installed) ? "Yes" : "No" }));
            }

            if (uninstalled)
            {
                cmdDownload.Enabled = true;
            }
        }

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            var modListFile = Path.Combine(txtConanPath.Text, "ConanSandbox", "Mods", "modlist.txt");
            var modListData = "";

            foreach (var item in listMods.Items)
            {
                var listItem = item as ListViewItem;
                var modPath = Path.Combine(txtMods.Text, listItem.SubItems[2].Text);
                var files = Directory.EnumerateFiles(modPath, "*.pak");
                if (files.Count() > 1)
                {
                    MessageBox.Show($"Warning: More than one .pak in {modPath}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                modPath = files.First();
                modListData += $"*{modPath}\r\n";
            }

            File.WriteAllText(modListFile, modListData);
            MessageBox.Show($"Wrote {listMods.Items.Count} mods to {modListFile}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
