using System;
using System.Windows.Forms;

namespace FileRenamer
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.TextBox txtSourcePath;
        private System.Windows.Forms.Button btnSelectSource;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.Button btnSelectDestination;
        private System.Windows.Forms.TextBox txtTextToRemove;
        private System.Windows.Forms.Button btnRenameFiles;
        private System.Windows.Forms.Label lblSource;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.Label lblTextToRemove;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.btnSelectSource = new System.Windows.Forms.Button();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.btnSelectDestination = new System.Windows.Forms.Button();
            this.txtTextToRemove = new System.Windows.Forms.TextBox();
            this.btnRenameFiles = new System.Windows.Forms.Button();
            this.lblSource = new System.Windows.Forms.Label();
            this.lblDestination = new System.Windows.Forms.Label();
            this.lblTextToRemove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // Label Source
            this.lblSource.AutoSize = true;
            this.lblSource.Location = new System.Drawing.Point(12, 15);
            this.lblSource.Name = "lblSource";
            this.lblSource.Size = new System.Drawing.Size(93, 15);
            this.lblSource.Text = "Pasta de Origem:";
            
            // txtSourcePath
            this.txtSourcePath.Location = new System.Drawing.Point(120, 12);
            this.txtSourcePath.Size = new System.Drawing.Size(300, 23);
            
            // btnSelectSource
            this.btnSelectSource.Location = new System.Drawing.Point(430, 12);
            this.btnSelectSource.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSource.Text = "Selecionar";
            this.btnSelectSource.Click += new System.EventHandler(this.btnSelectSource_Click);
            
            // Label Destination
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(12, 50);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(102, 15);
            this.lblDestination.Text = "Pasta de Destino:";
            
            // txtDestinationPath
            this.txtDestinationPath.Location = new System.Drawing.Point(120, 47);
            this.txtDestinationPath.Size = new System.Drawing.Size(300, 23);
            
            // btnSelectDestination
            this.btnSelectDestination.Location = new System.Drawing.Point(430, 47);
            this.btnSelectDestination.Size = new System.Drawing.Size(75, 23);
            this.btnSelectDestination.Text = "Selecionar";
            this.btnSelectDestination.Click += new System.EventHandler(this.btnSelectDestination_Click);
            
            // Label TextToRemove
            this.lblTextToRemove.AutoSize = true;
            this.lblTextToRemove.Location = new System.Drawing.Point(12, 85);
            this.lblTextToRemove.Name = "lblTextToRemove";
            this.lblTextToRemove.Size = new System.Drawing.Size(105, 15);
            this.lblTextToRemove.Text = "Remover texto:";
            
            // txtTextToRemove
            this.txtTextToRemove.Location = new System.Drawing.Point(120, 82);
            this.txtTextToRemove.Size = new System.Drawing.Size(300, 23);
            
            // btnRenameFiles
            this.btnRenameFiles.Location = new System.Drawing.Point(12, 120);
            this.btnRenameFiles.Size = new System.Drawing.Size(493, 30);
            this.btnRenameFiles.Text = "Renomear Arquivos";
            this.btnRenameFiles.Click += new System.EventHandler(this.btnRenameFiles_Click);
            
            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 170);
            this.Controls.Add(this.lblSource);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.btnSelectSource);
            this.Controls.Add(this.lblDestination);
            this.Controls.Add(this.txtDestinationPath);
            this.Controls.Add(this.btnSelectDestination);
            this.Controls.Add(this.lblTextToRemove);
            this.Controls.Add(this.txtTextToRemove);
            this.Controls.Add(this.btnRenameFiles);
            this.Name = "Form1";
            this.Text = "Renomeador de Arquivos";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
