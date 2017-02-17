namespace DirSync
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
            this.okButton = new System.Windows.Forms.Button();
            this.fromDir = new System.Windows.Forms.TextBox();
            this.toDir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(384, 169);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            // 
            // fromDir
            // 
            this.fromDir.AcceptsTab = true;
            this.fromDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDir.Location = new System.Drawing.Point(70, 68);
            this.fromDir.Name = "fromDir";
            this.fromDir.Size = new System.Drawing.Size(389, 20);
            this.fromDir.TabIndex = 3;
            this.fromDir.TabStop = false;
            this.fromDir.Text = "Copy from..";
            // 
            // toDir
            // 
            this.toDir.AcceptsTab = true;
            this.toDir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDir.Location = new System.Drawing.Point(70, 119);
            this.toDir.Name = "toDir";
            this.toDir.Size = new System.Drawing.Size(389, 20);
            this.toDir.TabIndex = 4;
            this.toDir.TabStop = false;
            this.toDir.Text = "Copy to..";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(498, 417);
            this.Controls.Add(this.toDir);
            this.Controls.Add(this.fromDir);
            this.Controls.Add(this.okButton);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox fromDir;
        private System.Windows.Forms.TextBox toDir;
    }
}

