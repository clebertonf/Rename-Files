using System.Text.RegularExpressions;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSelectSource_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtSourcePath.Text = dialog.SelectedPath;
                }
            }
        }
        
        private void btnSelectDestination_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    txtDestinationPath.Text = dialog.SelectedPath;
                }
            }
        }
        
        private void btnRenameFiles_Click(object sender, EventArgs e)
        {
            string sourcePath = txtSourcePath.Text;
            string destinationPath = txtDestinationPath.Text;
            string textToRemove = txtTextToRemove.Text;

            if (string.IsNullOrWhiteSpace(sourcePath) ||
                string.IsNullOrWhiteSpace(destinationPath) ||
                string.IsNullOrWhiteSpace(textToRemove))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(sourcePath) || !Directory.Exists(destinationPath))
            {
                MessageBox.Show("Uma ou ambas as pastas selecionadas não existem.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(sourcePath);
                int countChanged = 0;

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string newFileName = Regex.Replace(fileName, Regex.Escape(textToRemove), "", RegexOptions.IgnoreCase);
                    
                    if (string.Equals(fileName, newFileName, StringComparison.Ordinal))
                        continue;
                    
                    string newFilePath = Path.Combine(destinationPath, newFileName);
                    File.Copy(file, newFilePath);
                    countChanged++;
                }

                if (countChanged == 0)
                {
                    MessageBox.Show("Nenhum arquivo foi alterado. Verifique se a string informada existe nos nomes dos arquivos.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{countChanged} arquivos renomeados com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar arquivos: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnRenameBetween_Click(object sender, EventArgs e)
        {
            string sourcePath = txtSourcePath.Text;
            string destinationPath = txtDestinationPath.Text;
            string initialStr = txtInitialString.Text;
            string finalStr = txtFinalString.Text;

            if (string.IsNullOrWhiteSpace(sourcePath) ||
                string.IsNullOrWhiteSpace(destinationPath) ||
                string.IsNullOrWhiteSpace(initialStr) ||
                string.IsNullOrWhiteSpace(finalStr))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(sourcePath) || !Directory.Exists(destinationPath))
            {
                MessageBox.Show("Uma ou ambas as pastas selecionadas não existem.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(sourcePath);
                int countChanged = 0;
                string pattern = Regex.Escape(initialStr) + ".*?" + Regex.Escape(finalStr);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string newFileName = Regex.Replace(fileName, pattern, "", RegexOptions.IgnoreCase);
                    
                    if (string.Equals(fileName, newFileName, StringComparison.Ordinal))
                        continue;
                    
                    string newFilePath = Path.Combine(destinationPath, newFileName);
                    File.Copy(file, newFilePath);
                    countChanged++;
                }
                if (countChanged == 0)
                {
                    MessageBox.Show("Nenhum arquivo foi alterado. Verifique se as strings informadas existem nos nomes dos arquivos.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show($"{countChanged} arquivos renomeados com sucesso!", "Sucesso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar arquivos: " + ex.Message, "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}