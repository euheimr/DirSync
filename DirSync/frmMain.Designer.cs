namespace DirSync
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.okButton = new System.Windows.Forms.Button();
            this.fromDirBox = new System.Windows.Forms.TextBox();
            this.toDirBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.AccessibleName = "okButton";
            this.okButton.Location = new System.Drawing.Point(384, 169);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // fromDirBox
            // 
            this.fromDirBox.AcceptsTab = true;
            this.fromDirBox.AccessibleName = "fromDirBox";
            this.fromDirBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromDirBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fromDirBox.Location = new System.Drawing.Point(70, 68);
            this.fromDirBox.Name = "fromDirBox";
            this.fromDirBox.Size = new System.Drawing.Size(389, 20);
            this.fromDirBox.TabIndex = 3;
            this.fromDirBox.TabStop = false;
            this.fromDirBox.WordWrap = false;
            // 
            // toDirBox
            // 
            this.toDirBox.AcceptsTab = true;
            this.toDirBox.AccessibleName = "toDirBox";
            this.toDirBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toDirBox.Location = new System.Drawing.Point(70, 108);
            this.toDirBox.Name = "toDirBox";
            this.toDirBox.Size = new System.Drawing.Size(389, 20);
            this.toDirBox.TabIndex = 4;
            this.toDirBox.TabStop = false;
            this.toDirBox.WordWrap = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar1.Location = new System.Drawing.Point(70, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.UseWaitCursor = true;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(13, 74);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(33, 13);
            this.fromLabel.TabIndex = 7;
            this.fromLabel.Text = "From:";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(13, 114);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(23, 13);
            this.toLabel.TabIndex = 8;
            this.toLabel.Text = "To:";
            // 
            // frmMain
            // 
            this.ClientSize = new System.Drawing.Size(498, 223);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toDirBox);
            this.Controls.Add(this.fromDirBox);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button okButton;
        public System.Windows.Forms.TextBox fromDirBox;
        public System.Windows.Forms.TextBox toDirBox;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        public System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
    }
}

