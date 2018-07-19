using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConanModSelector
{
    public partial class MainForm : Form
    {
        List<int> modIds;

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
            if (modIds == null)
            {
                MessageBox.Show("Select a preset!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtMods.Text.Length == 0)
            {
                MessageBox.Show("Enter a mod path!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var modListFile = Path.Combine(txtConanPath.Text, "ConanSandbox", "Mods", "modlist.txt");
            var modListData = "";
            foreach (var modId in modIds)
            {
                var modGlob = Path.Combine(txtMods.Text, modId.ToString());
                var files = Directory.EnumerateFiles(modGlob, "*.pak");
                if (files.Count() > 1)
                {
                    Console.WriteLine($"WARN: More than one .pak in {modGlob}");
                }

                var file = files.First();
                modListData += $"*{file}\r\n";
            }
            File.WriteAllText(modListFile, modListData);
            MessageBox.Show($"Wrote {modIds.Count} mods to {modListFile}", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtConanPath_TextChanged(object sender, EventArgs e)
        {
            cmdWriteModlist.Enabled = txtConanPath.Text.Length > 0;
        }

        private void txtMods_TextChanged(object sender, EventArgs e)
        {
            cmdWriteModlist.Enabled = txtMods.Text.Length > 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Softcore")
            {
                modIds = new List<int>(new int[]
                {
                    864199675,
                    1108556675,
                    1183199682,
                    1211904989,
                    913496068,
                    1369743238,
                    1159180273,
                    880177231,
                    925197087,
                    1437712973,
                    862889805
                });
            }
            else if (comboBox1.Text == "Hardcore")
            {
                modIds = new List<int>(new int[] {
                    880454836,
                    864199675,
                    1183199682,
                    1211904989,
                    1108556675,
                    1389681165,
                    897947497,
                    1159180273,
                    1369743238,
                    913496068,
                    1417350098,
                    925197087,
                    862889805,
                    1390768358,
                    1315595341
                });
            }
        }
    }
}
