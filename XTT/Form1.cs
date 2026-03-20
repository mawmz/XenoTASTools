using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace XTT
{
    public partial class mainPanel : Form
    {
        public mainPanel()
        {
            InitializeComponent();

            // Hook events
            btnBrowse.Click += BtnBrowse_Click;
            btnLoad.Click += BtnLoad_Click;
            txtDirectory.TextChanged += TxtDirectory_TextChanged;
            btnRefresh.Click += BtnRefresh_Click;

            // ComboBox settings
            txtLoad.DropDownStyle = ComboBoxStyle.DropDownList;

            // Save config when the app closes
            this.FormClosing += (s, e) => SaveConfig();

            // Load config when the app opens
            LoadConfig();

            // Backup button
            btnBackupSave.Click += BtnBackupSave_Click;


        }

        private void Log(string message)
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            string line = "[" + time + "] " + message;

            lstLog.Items.Add(line);

            // Auto-scroll to newest item
            lstLog.TopIndex = lstLog.Items.Count - 1;
        }

        private void BtnBackupSave_Click(object sender, EventArgs e)
        {
            string folder = (txtDirectory.Text ?? "").Trim();

            if (!Directory.Exists(folder))
            {
                MessageBox.Show(this, "That folder doesn't exist.", "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string backupName = (txtBackupName.Text ?? "").Trim();
            if (string.IsNullOrWhiteSpace(backupName))
            {
                MessageBox.Show(this, "Type a backup name first.", "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Replace invalid filename characters so Windows doesn't reject it
            foreach (char bad in Path.GetInvalidFileNameChars())
                backupName = backupName.Replace(bad.ToString(), "");

            if (string.IsNullOrWhiteSpace(backupName))
            {
                MessageBox.Show(this, "That backup name isn't valid.", "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string src = Path.Combine(folder, "bf2savefile.sav");
            string dest = Path.Combine(folder, "bf2savefile " + backupName + ".sav");

            try
            {
                if (!File.Exists(src))
                {
                    MessageBox.Show(this, "bf2savefile.sav was not found in that folder.", "XC2 TAS Tools",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // If the backup already exists, ask before overwriting
                if (File.Exists(dest))
                {
                    var result = MessageBox.Show(this,
                        "That backup file already exists.\nOverwrite it?",
                        "XC2 TAS Tools",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result != DialogResult.Yes)
                        return;
                }

                File.Copy(src, dest, true);
                Log("Backup created: " + Path.GetFileName(dest));

                // Refresh dropdown so it appears immediately
                RefreshSaveList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to create backup:\n" + ex.Message, "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            RefreshSaveList();
        }

        private void TxtDirectory_TextChanged(object sender, EventArgs e)
        {
            RefreshSaveList();
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (var dlg = new CommonOpenFileDialog())
            {
                dlg.Title = "Select your XC2 save directory";
                dlg.IsFolderPicker = true;

                if (Directory.Exists(txtDirectory.Text))
                    dlg.InitialDirectory = txtDirectory.Text;

                if (dlg.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    txtDirectory.Text = dlg.FileName;
                    RefreshSaveList();
                }
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            string folder = (txtDirectory.Text ?? "").Trim();

            if (!Directory.Exists(folder))
            {
                MessageBox.Show(this, "That folder doesn't exist.", "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedName = txtLoad.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selectedName))
            {
                MessageBox.Show(this, "Pick a file in the dropdown first.", "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string src = Path.Combine(folder, selectedName);
            string dest = Path.Combine(folder, "bf2savefile.sav");

            try
            {
                if (!File.Exists(src))
                {
                    MessageBox.Show(this, "That selected file no longer exists.", "XC2 TAS Tools",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    RefreshSaveList();
                    return;
                }

                // Overwrite bf2savefile.sav with the selected file
                File.Copy(src, dest, true);
                Log("Loaded: " + selectedName + " -> bf2savefile.sav");

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Failed to load save:\n" + ex.Message, "XC2 TAS Tools",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshSaveList()
        {
            string folder = (txtDirectory.Text ?? "").Trim();
            string previous = txtLoad.SelectedItem as string;

            txtLoad.BeginUpdate();
            try
            {
                txtLoad.Items.Clear();

                if (!Directory.Exists(folder))
                    return;

                List<string> files = Directory.EnumerateFiles(folder, "bf2savefile*")
                    .Select(Path.GetFileName)
                    .Where(n => !string.IsNullOrWhiteSpace(n))
                    .ToList();

                files.Sort(NaturalCompare);

                for (int i = 0; i < files.Count; i++)
                    txtLoad.Items.Add(files[i]);

                // Restore previous selection if possible
                if (!string.IsNullOrWhiteSpace(previous))
                {
                    int idx = txtLoad.FindStringExact(previous);
                    if (idx >= 0) txtLoad.SelectedIndex = idx;
                }

                // Otherwise pick the first entry
                if (txtLoad.SelectedIndex < 0 && txtLoad.Items.Count > 0)
                    txtLoad.SelectedIndex = 0;
            }
            finally
            {
                txtLoad.EndUpdate();
            }
        }

        // Natural sort so "2" comes before "10"
        private static int NaturalCompare(string a, string b)
        {
            if (a == null) a = "";
            if (b == null) b = "";

            int ia = 0, ib = 0;

            while (ia < a.Length && ib < b.Length)
            {
                char ca = a[ia];
                char cb = b[ib];

                bool da = char.IsDigit(ca);
                bool db = char.IsDigit(cb);

                if (da && db)
                {
                    long va = 0, vb = 0;

                    int sa = ia;
                    while (ia < a.Length && char.IsDigit(a[ia]))
                    {
                        va = va * 10 + (a[ia] - '0');
                        ia++;
                    }

                    int sb = ib;
                    while (ib < b.Length && char.IsDigit(b[ib]))
                    {
                        vb = vb * 10 + (b[ib] - '0');
                        ib++;
                    }

                    if (va != vb) return va.CompareTo(vb);

                    int lena = ia - sa;
                    int lenb = ib - sb;
                    if (lena != lenb) return lena.CompareTo(lenb);

                    continue;
                }

                int cmp = char.ToLowerInvariant(ca).CompareTo(char.ToLowerInvariant(cb));
                if (cmp != 0) return cmp;

                ia++;
                ib++;
            }

            return (a.Length - ia).CompareTo(b.Length - ib);
        }

        private string ConfigPath
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.txt"); }
        }

        private void SaveConfig()
        {
            try
            {
                string dir = (txtDirectory.Text ?? "").Trim();
                string file = txtLoad.SelectedItem as string;
                if (file == null) file = "";

                string[] lines =
                {
            "directory=" + dir,
            "file=" + file
        };

                File.WriteAllLines(ConfigPath, lines);
            }
            catch
            {
                // ignore config errors
            }
        }

        private void LoadConfig()
        {
            try
            {
                if (!File.Exists(ConfigPath))
                    return;

                string[] lines = File.ReadAllLines(ConfigPath);

                string savedDir = "";
                string savedFile = "";

                foreach (string line in lines)
                {
                    if (line.StartsWith("directory="))
                        savedDir = line.Substring("directory=".Length).Trim();

                    if (line.StartsWith("file="))
                        savedFile = line.Substring("file=".Length).Trim();
                }

                // Set directory first
                if (!string.IsNullOrWhiteSpace(savedDir))
                    txtDirectory.Text = savedDir;

                // Refresh dropdown using the directory
                RefreshSaveList();

                // Select saved file if it exists
                if (!string.IsNullOrWhiteSpace(savedFile))
                {
                    int idx = txtLoad.FindStringExact(savedFile);
                    if (idx >= 0)
                        txtLoad.SelectedIndex = idx;
                }
            }
            catch
            {
                // ignore config errors
            }
        }

        // --- Old designer event handlers (safe to leave empty) ---
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void pageResources_Click(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
