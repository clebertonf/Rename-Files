namespace FileRenamer
{
    public partial class Form1 : Form
    {
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

            if (string.IsNullOrWhiteSpace(sourcePath) || string.IsNullOrWhiteSpace(destinationPath) || string.IsNullOrWhiteSpace(textToRemove))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Directory.Exists(sourcePath) || !Directory.Exists(destinationPath))
            {
                MessageBox.Show("Uma ou ambas as pastas selecionadas não existem.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] files = Directory.GetFiles(sourcePath);
                int count = 0;

                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string newFileName = fileName.Replace(textToRemove, "", StringComparison.OrdinalIgnoreCase);
                    string newFilePath = Path.Combine(destinationPath, newFileName);
                    File.Copy(file, newFilePath);
                    count++;
                }

                MessageBox.Show($"{count} arquivos renomeados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao processar arquivos: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
