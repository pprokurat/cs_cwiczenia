namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PortNr = new System.Windows.Forms.TextBox();
            this.RunButton = new System.Windows.Forms.Button();
            this.FolderPath = new System.Windows.Forms.TextBox();
            this.FolderPathLabel = new System.Windows.Forms.Label();
            this.PortNrLabel = new System.Windows.Forms.Label();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PortNr
            // 
            this.PortNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PortNr.Location = new System.Drawing.Point(26, 43);
            this.PortNr.Name = "PortNr";
            this.PortNr.Size = new System.Drawing.Size(103, 24);
            this.PortNr.TabIndex = 0;
            this.PortNr.TextChanged += new System.EventHandler(this.PortNr_TextChanged);
            // 
            // RunButton
            // 
            this.RunButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.RunButton.Location = new System.Drawing.Point(26, 146);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(103, 52);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // FolderPath
            // 
            this.FolderPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FolderPath.Location = new System.Drawing.Point(26, 102);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(384, 24);
            this.FolderPath.TabIndex = 2;
            this.FolderPath.TextChanged += new System.EventHandler(this.FolderPath_TextChanged);
            // 
            // FolderPathLabel
            // 
            this.FolderPathLabel.AutoSize = true;
            this.FolderPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.FolderPathLabel.Location = new System.Drawing.Point(23, 81);
            this.FolderPathLabel.Name = "FolderPathLabel";
            this.FolderPathLabel.Size = new System.Drawing.Size(82, 18);
            this.FolderPathLabel.TabIndex = 3;
            this.FolderPathLabel.Text = "Folder path";
            // 
            // PortNrLabel
            // 
            this.PortNrLabel.AutoSize = true;
            this.PortNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.PortNrLabel.Location = new System.Drawing.Point(23, 22);
            this.PortNrLabel.Name = "PortNrLabel";
            this.PortNrLabel.Size = new System.Drawing.Size(90, 18);
            this.PortNrLabel.TabIndex = 4;
            this.PortNrLabel.Text = "Port number";
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.StopButton.Location = new System.Drawing.Point(164, 146);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(103, 52);
            this.StopButton.TabIndex = 5;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 227);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.PortNrLabel);
            this.Controls.Add(this.FolderPathLabel);
            this.Controls.Add(this.FolderPath);
            this.Controls.Add(this.RunButton);
            this.Controls.Add(this.PortNr);
            this.Name = "Form1";
            this.Text = "WebServer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PortNr;
        private System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.TextBox FolderPath;
        private System.Windows.Forms.Label FolderPathLabel;
        private System.Windows.Forms.Label PortNrLabel;
        private System.Windows.Forms.Button StopButton;
    }
}

