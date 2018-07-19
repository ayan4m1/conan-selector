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
            var selectedMod = _mods.Find((mod) => mod.Name == comboBox1.Text);
            foreach (var mod in selectedMod.Mods)
            {
                var modGlob = Path.Combine(txtMods.Text, mod.ToString());
                var files = Directory.EnumerateFiles(modGlob, "*.pak");
                if (files.Count() > 1)
                {
                    Console.WriteLine($"WARN: More than one .pak in {modGlob}");
                }

                var file = files.First();
                var name = Path.GetFileName(file);
                var parts = file.Split(Path.DirectorySeparatorChar);
                var id = parts[parts.Length - 2];

                listMods.Items.Add(new ListViewItem(new string[] { file, id, name }));

                modListData += $"*{file}\r\n";
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
                comboBox1.Items.Add(modObj.Name);
                _mods.Add(modObj);
            }
        }
    }
}
