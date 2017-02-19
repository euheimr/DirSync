namespace DirSync
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.okButton = new System.Windows.Forms.Button();
            this.fromDirBox = new System.Windows.Forms.TextBox();
            this.toDirBox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
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
            this.fromDirBox.Text = "from";
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
            this.toDirBox.Text = "to";
            this.toDirBox.WordWrap = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 146);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(389, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 6;
            this.progressBar1.UseWaitCursor = true;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Form
            // 
            this.ClientSize = new System.Drawing.Size(498, 223);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.toDirBox);
            this.Controls.Add(this.fromDirBox);
            this.Controls.Add(this.okButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form";
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


    }
}

