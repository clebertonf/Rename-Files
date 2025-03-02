namespace FileRenamer
{
    partial class Form1
    {
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageSpecific;
        private System.Windows.Forms.TabPage tabPageBetween;
        
        private System.Windows.Forms.TextBox txtTextToRemove;
        private System.Windows.Forms.Label lblTextToRemove;
        private System.Windows.Forms.Button btnRenameFiles;
        
        private System.Windows.Forms.TextBox txtInitialString;
        private System.Windows.Forms.TextBox txtFinalString;
        private System.Windows.Forms.Label lblInitialString;
        private System.Windows.Forms.Label lblFinalString;
        private System.Windows.Forms.Button btnRenameBetween;
        
        private void InitializeComponent()
        {
            this.lblSource = new System.Windows.Forms.Label();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSpecific = new System.Windows.Forms.TabPage();
            this.tabPageBetween = new System.Windows.Forms.TabPage();
            
            this.lblTextToRemove = new System.Windows.Forms.Label();
            this.txtTextToRemove = new System.Windows.Forms.TextBox();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            
            this.lblInitialString = new System.Windows.Forms.Label();
            this.txtInitialString = new System.Windows.Forms.TextBox();
            this.lblFinalString = new System.Windows.Forms.Label();
            this.txtFinalString = new System.Windows.Forms.TextBox();
            this.btnRenameBetween = new System.Windows.Forms.Button();

            this.tabControl1.SuspendLayout();
            this.tabPageSpecific.SuspendLayout();
            this.tabPageBetween.SuspendLayout();
            this.SuspendLayout();

            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(93, 15);
            this.lblSource.Text = "Pasta de Origem:";

            this.txtSourcePath.Location = new System.Drawing.Point(120, 12);
            this.txtSourcePath.Size = new System.Drawing.Size(300, 23);

            this.btnSelectSource.Location = new System.Drawing.Point(430, 12);
            this.btnSelectSource.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSource.Text = "Selecionar";
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);

            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 45);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 15);
            this.lblDestination.Text = "Pasta de Destino:";

            this.txtDestinationPath.Location = new System.Drawing.Point(120, 42);
            this.txtDestinationPath.Size = new System.Drawing.Size(300, 23);

            this.btnSelectDestination.Location = new System.Drawing.Point(430, 42);
            this.btnSelectDestination.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDestination.Text = "Selecionar";
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);

            this.tabControl1.Controls.Add(this.tabPageSpecific);
            this.tabControl1.Controls.Add(this.tabPageBetween);
            this.tabControl1.Location = new System.Drawing.Point(12, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(540, 220);

            this.tabPageSpecific.Controls.Add(this.lblTextToRemove);
            this.tabPageSpecific.Controls.Add(this.txtTextToRemove);
            this.tabPageSpecific.Controls.Add(this.btnRenameFiles);
            this.tabPageSpecific.Location = new System.Drawing.Point(4, 24);
            this.tabPageSpecific.Name = "tabPageSpecific";
            this.tabPageSpecific.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpecific.Size = new System.Drawing.Size(532, 192);
            this.tabPageSpecific.Text = "Remover Texto Específico";
            this.tabPageSpecific.UseVisualStyleBackColor = true;

            this.lblTextToRemove.AutoSize = true;
            this.lblTextToRemove.Location = new System.Drawing.Point(10, 15);
            this.lblTextToRemove.Name = "lblTextToRemove";
            this.lblTextToRemove.Size = new System.Drawing.Size(105, 15);
            this.lblTextToRemove.Text = "Remover texto:";

            this.txtTextToRemove.Location = new System.Drawing.Point(120, 12);
            this.txtTextToRemove.Size = new System.Drawing.Size(300, 23);

            this.btnRenameFiles.Location = new System.Drawing.Point(10, 50);
            this.btnRenameFiles.Size = new System.Drawing.Size(495, 30);
            this.btnRenameFiles.Text = "Renomear Arquivos";
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);

            this.tabPageBetween.Controls.Add(this.lblInitialString);
            this.tabPageBetween.Controls.Add(this.txtInitialString);
            this.tabPageBetween.Controls.Add(this.lblFinalString);
            this.tabPageBetween.Controls.Add(this.txtFinalString);
            this.tabPageBetween.Controls.Add(this.btnRenameBetween);
            this.tabPageBetween.Location = new System.Drawing.Point(4, 24);
            this.tabPageBetween.Name = "tabPageBetween";
            this.tabPageBetween.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBetween.Size = new System.Drawing.Size(532, 192);
            this.tabPageBetween.Text = "Remover Entre Strings";
            this.tabPageBetween.UseVisualStyleBackColor = true;

            this.lblInitialString.AutoSize = true;
            this.lblInitialString.Location = new System.Drawing.Point(10, 15);
            this.lblInitialString.Name = "lblInitialString";
            this.lblInitialString.Size = new System.Drawing.Size(83, 15);
            this.lblInitialString.Text = "String Inicial:";

            this.txtInitialString.Location = new System.Drawing.Point(120, 12);
            this.txtInitialString.Size = new System.Drawing.Size(300, 23);

            this.lblFinalString.AutoSize = true;
            this.lblFinalString.Location = new System.Drawing.Point(10, 45);
            this.lblFinalString.Name = "lblFinalString";
            this.lblFinalString.Size = new System.Drawing.Size(70, 15);
            this.lblFinalString.Text = "String Final:";

            this.txtFinalString.Location = new System.Drawing.Point(120, 42);
            this.txtFinalString.Size = new System.Drawing.Size(300, 23);

            this.btnRenameBetween.Location = new System.Drawing.Point(10, 80);
            this.btnRenameBetween.Size = new System.Drawing.Size(495, 30);
            this.btnRenameBetween.Text = "Renomear Arquivos";
            this.btnRenameBetween.Click += new System.EventHandler(this.btnRenameBetween_Click);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 250);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.btnSelectDestination);
            this.Name = "Form1";
            this.Text = "Renomeador de Arquivos";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSpecific.ResumeLayout(false);
            this.tabPageSpecific.PerformLayout();
            this.tabPageBetween.ResumeLayout(false);
            this.tabPageBetween.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
