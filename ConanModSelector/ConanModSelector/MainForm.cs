using AngleSharp;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
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

        private void cmdModsBrowse_Click(object sender, EventArgs e)
        {
            if (fbdModPath.ShowDialog() == DialogResult.OK)
            {
                txtSteamPath.Text = fbdModPath.SelectedPath;
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

            PopulateModItems();
        }

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            var modListFile = Path.Combine(txtSteamPath.Text, "common", "Conan Exiles", "ConanSandbox", "Mods", "modlist.txt");
            var modListData = "";

            foreach (var item in listMods.Items)
            {
                var listItem = item as ListViewItem;
                var modPath = Path.Combine(txtSteamPath.Text, "workshop", "content", "440900", listItem.SubItems[2].Text);
                modPath = FindPak(modPath);
                modListData += $"*{modPath}\r\n";
            }

            File.WriteAllText(modListFile, modListData);
            MessageBox.Show($"Wrote {listMods.Items.Count} mods to {modListFile}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdDownload_Click(object sender, EventArgs e)
        {
            var progressTick = 1 / (float)listMods.Items.Count;
            prgDownload.Enabled = true;
            prgDownload.Value = 0;

            foreach (var mod in listMods.Items)
            {
                var modItem = mod as ListViewItem;
                var installed = modItem.SubItems[3].Text;
                var modId = modItem.SubItems[2].Text;
                if (installed == "Yes")
                {
                    continue;
                }

                var steamAppsDir = txtSteamPath.Text;
                steamAppsDir = steamAppsDir.Substring(0, steamAppsDir.LastIndexOf(Path.DirectorySeparatorChar));
                var info = new ProcessStartInfo()
                {
                    FileName = "steamcmd.exe",
                    Arguments = $"+login anonymous +force_install_dir \"{steamAppsDir}\" +workshop_download_item 440900 {modId} +quit",
                    UseShellExecute = false
                };
                var process = Process.Start(info);
                prgDownload.Value += (int)(progressTick * prgDownload.Maximum);
            }

            prgDownload.Value = 0;
            prgDownload.Enabled = false;

            PopulateModItems();
        }

        private async void PopulateModItems()
        {
            listMods.Items.Clear();
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
                var modPath = Path.Combine(txtSteamPath.Text, "workshop", "content", "440900", id);
                var modPak = FindPak(modPath);
                var installed = File.Exists(modPak);
                if (!installed)
                {
                    uninstalled = true;
                }

                modPath = FindPak(modPath);
                modName = Path.GetFileName(modPath);

                listMods.Items.Add(new ListViewItem(new string[] { modPath, title, id, (installed) ? "Yes" : "No" }));
            }

            if (uninstalled)
            {
                cmdDownload.Enabled = true;
            }
        }

        private string FindPak(string directory)
        {
            var files = Directory.EnumerateFiles(directory, "*.pak");
            if (files.Count() > 1)
            {
                MessageBox.Show($"Warning: More than one .pak in {directory}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (files.Count() == 0)
            {
                return null;
            }

            return files.First();
        }
    }
}
