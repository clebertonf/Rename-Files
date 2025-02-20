namespace RenameFiles
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnSelectSourceFolder;
        private System.Windows.Forms.Label lblSourceFolder;
        private System.Windows.Forms.Button btnSelectDestinationFolder;
        private System.Windows.Forms.Label lblDestinationFolder;
        private System.Windows.Forms.TextBox txtSubstring;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnCurrentFolder;
        private System.Windows.Forms.RadioButton rbtnSelectFolder;
        private System.Windows.Forms.Button btnRename;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnSelectSourceFolder = new System.Windows.Forms.Button();
            this.lblSourceFolder = new System.Windows.Forms.Label();
            this.btnSelectDestinationFolder = new System.Windows.Forms.Button();
            this.lblDestinationFolder = new System.Windows.Forms.Label();
            this.txtSubstring = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnCurrentFolder = new System.Windows.Forms.RadioButton();
            this.rbtnSelectFolder = new System.Windows.Forms.RadioButton();
            this.btnRename = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            this.btnSelectSourceFolder.Location = new System.Drawing.Point(12, 15);
            this.btnSelectSourceFolder.Name = "btnSelectSourceFolder";
            this.btnSelectSourceFolder.Size = new System.Drawing.Size(100, 30);
            this.btnSelectSourceFolder.TabIndex = 0;
            this.btnSelectSourceFolder.Text = "Select";
            this.btnSelectSourceFolder.UseVisualStyleBackColor = true;
            this.btnSelectSourceFolder.Click += new System.EventHandler(this.btnSelectSourceFolder_Click);
            
            this.lblSourceFolder.AutoSize = true;
            this.lblSourceFolder.Location = new System.Drawing.Point(120, 22);
            this.lblSourceFolder.Name = "lblSourceFolder";
            this.lblSourceFolder.Size = new System.Drawing.Size(170, 20);
            this.lblSourceFolder.TabIndex = 1;
            this.lblSourceFolder.Text = "Folder: No folder selected";
            
            this.btnSelectDestinationFolder.Location = new System.Drawing.Point(12, 55);
            this.btnSelectDestinationFolder.Name = "btnSelectDestinationFolder";
            this.btnSelectDestinationFolder.Size = new System.Drawing.Size(100, 30);
            this.btnSelectDestinationFolder.TabIndex = 2;
            this.btnSelectDestinationFolder.Text = "Select";
            this.btnSelectDestinationFolder.UseVisualStyleBackColor = true;
            this.btnSelectDestinationFolder.Click += new System.EventHandler(this.btnSelectDestinationFolder_Click);
            
            this.lblDestinationFolder.AutoSize = true;
            this.lblDestinationFolder.Location = new System.Drawing.Point(120, 62);
            this.lblDestinationFolder.Name = "lblDestinationFolder";
            this.lblDestinationFolder.Size = new System.Drawing.Size(180, 20);
            this.lblDestinationFolder.TabIndex = 3;
            this.lblDestinationFolder.Text = "Destination: No folder selected";
            
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Substring to remove:";
            
            this.txtSubstring.Location = new System.Drawing.Point(12, 125);
            this.txtSubstring.Name = "txtSubstring";
            this.txtSubstring.Size = new System.Drawing.Size(280, 27);
            this.txtSubstring.TabIndex = 5;
            
            this.rbtnCurrentFolder.AutoSize = true;
            this.rbtnCurrentFolder.Location = new System.Drawing.Point(12, 165);
            this.rbtnCurrentFolder.Name = "rbtnCurrentFolder";
            this.rbtnCurrentFolder.Size = new System.Drawing.Size(140, 35);
            this.rbtnCurrentFolder.TabIndex = 6;
            this.rbtnCurrentFolder.TabStop = true;
            this.rbtnCurrentFolder.Text = "Rename all files in the folder";
            this.rbtnCurrentFolder.UseVisualStyleBackColor = true;
            
            this.rbtnSelectFolder.AutoSize = true;
            this.rbtnSelectFolder.Location = new System.Drawing.Point(250, 165);
            this.rbtnSelectFolder.Name = "rbtnSelectFolder";
            this.rbtnSelectFolder.Size = new System.Drawing.Size(95, 30);
            this.rbtnSelectFolder.TabIndex = 7;
            this.rbtnSelectFolder.TabStop = true;
            this.rbtnSelectFolder.Text = "Rename Selected Folder";
            this.rbtnSelectFolder.UseVisualStyleBackColor = true;

            this.btnRename.Location = new System.Drawing.Point(12, 200);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(120, 35);
            this.btnRename.TabIndex = 8;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.rbtnSelectFolder);
            this.Controls.Add(this.rbtnCurrentFolder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubstring);
            this.Controls.Add(this.lblDestinationFolder);
            this.Controls.Add(this.btnSelectDestinationFolder);
            this.Controls.Add(this.lblSourceFolder);
            this.Controls.Add(this.btnSelectSourceFolder);
            this.Name = "Form1";
            this.Text = "File Renamer";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
