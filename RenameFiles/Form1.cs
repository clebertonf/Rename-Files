namespace RenameFiles
{
    public partial class Form1 : Form
    {
        private string sourceFolder = "";
        private string destinationFolder = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectSourceFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    sourceFolder = fbd.SelectedPath;
                    lblSourceFolder.Text = "Folder: " + sourceFolder;
                }
            }
        }

        private void btnSelectDestinationFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    destinationFolder = fbd.SelectedPath;
                    lblDestinationFolder.Text = "Destination: " + destinationFolder;
                }
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubstring.Text))
            {
                MessageBox.Show("Please enter the substring to remove!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (rbtnCurrentFolder.Checked)
            {
                sourceFolder = Directory.GetCurrentDirectory();
                destinationFolder = sourceFolder;
            }
            else if (rbtnSelectFolder.Checked)
            {
                if (string.IsNullOrWhiteSpace(sourceFolder) || string.IsNullOrWhiteSpace(destinationFolder))
                {
                    MessageBox.Show("Please select both source and destination folders!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            try
            {
                string substringToRemove = txtSubstring.Text;
                var files = Directory.GetFiles(sourceFolder)
                                     .Where(f => Path.GetFileName(f).Contains(substringToRemove))
                                     .ToList();

                if (files.Count == 0)
                {
                    MessageBox.Show("No files found with the given substring.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                foreach (var file in files)
                {
                    string originalName = Path.GetFileName(file);
                    string newName = originalName.Replace(substringToRemove, "").Trim();
                    string newPath = Path.Combine(destinationFolder, newName);

                    File.Move(file, newPath);
                }

                MessageBox.Show("Files renamed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error renaming files: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
