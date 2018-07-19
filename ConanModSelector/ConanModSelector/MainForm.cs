using Newtonsoft.Json;
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
        List<Mod> _mods = new List<Mod>();

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

        private void cmdWriteModlist_Click(object sender, EventArgs e)
        {
            listMods.Items.Clear();

            if (_mods.Count == 0)
            {
                MessageBox.Show("No presets loaded!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMods.Text.Length == 0)
            {
                MessageBox.Show("Enter a mod path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var modListFile = Path.Combine(txtConanPath.Text, "ConanSandbox", "Mods", "modlist.txt");
            var modListData = "";
            var selectedMod = _mods.Find((mod) => mod.Name == selectedPreset.Text);
            if (selectedMod == null)
            {
                MessageBox.Show($"Did not find mod information for preset named {selectedPreset.Text}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var modPath = "";
            var modName = "";
            foreach (var rawModId in selectedMod.Mods)
            {
                var modId = rawModId.ToString();
                var installed = true;
                modPath = Path.Combine(txtMods.Text, modId);
                if (!Directory.Exists(modPath))
                {
                    installed = false;
                    modName = "Unknown";
                    MessageBox.Show($"Mod {modId} not downloaded!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var files = Directory.EnumerateFiles(modPath, "*.pak");
                    if (files.Count() > 1)
                    {
                        MessageBox.Show($"Warning: More than one .pak in {modPath}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    modPath = files.First();
                    modName = Path.GetFileName(modPath);
                    modListData += $"*{modPath}\r\n";
                }

                listMods.Items.Add(new ListViewItem(new string[] { modPath, modId, modName, (installed) ? "Yes" : "No" }));
            }
            File.WriteAllText(modListFile, modListData);
            MessageBox.Show($"Wrote {selectedMod.Mods.Count} mods to {modListFile}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtConanPath_TextChanged(object sender, EventArgs e)
        {
            cmdWriteModlist.Enabled = txtConanPath.Text.Length > 0;
        }

        private void txtMods_TextChanged(object sender, EventArgs e)
        {
            cmdWriteModlist.Enabled = txtMods.Text.Length > 0;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var client = new WebClient();
            var modData = client.DownloadString("http://survivalmod.com/mods.json");
            var mods = JArray.Parse(modData);
            foreach (var mod in mods)
            {
                var modObj = new Mod();
                modObj.Name = mod["name"].ToString();
                var ids = mod["mods"];
                foreach (var id in ids)
                {
                    modObj.Mods.Add(int.Parse(id.ToString()));
                }
                selectedPreset.Items.Add(modObj.Name);
                _mods.Add(modObj);
            }
        }
    }
}
