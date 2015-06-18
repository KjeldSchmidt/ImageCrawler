namespace WindowsFormsApplication1
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
			this.URLInput = new System.Windows.Forms.TextBox();
			this.URLLabel = new System.Windows.Forms.Label();
			this.crawlButton = new System.Windows.Forms.Button();
			this.debugBox = new System.Windows.Forms.RichTextBox();
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.targetFolderInput = new System.Windows.Forms.TextBox();
			this.stopCrawl = new System.Windows.Forms.Button();
			this.destnationLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// URLInput
			// 
			this.URLInput.AccessibleDescription = "Input the URL to crawl here";
			this.URLInput.AccessibleName = "URL Input";
			this.URLInput.Location = new System.Drawing.Point(12, 12);
			this.URLInput.Name = "URLInput";
			this.URLInput.Size = new System.Drawing.Size(448, 20);
			this.URLInput.TabIndex = 0;
			this.URLInput.Text = "http://www.reddit.com/r/ProgrammerHumor/";
			// 
			// URLLabel
			// 
			this.URLLabel.AccessibleDescription = "Put the URL to crawl here";
			this.URLLabel.AccessibleName = "URL Input";
			this.URLLabel.AutoSize = true;
			this.URLLabel.Location = new System.Drawing.Point(466, 15);
			this.URLLabel.Name = "URLLabel";
			this.URLLabel.Size = new System.Drawing.Size(29, 13);
			this.URLLabel.TabIndex = 1;
			this.URLLabel.Text = "URL";
			// 
			// crawlButton
			// 
			this.crawlButton.AccessibleDescription = "Clicking here will start the crawling process";
			this.crawlButton.AccessibleName = "Start Crawl Button";
			this.crawlButton.Location = new System.Drawing.Point(12, 64);
			this.crawlButton.Name = "crawlButton";
			this.crawlButton.Size = new System.Drawing.Size(75, 23);
			this.crawlButton.TabIndex = 2;
			this.crawlButton.Text = "Crawl!";
			this.crawlButton.UseVisualStyleBackColor = true;
			this.crawlButton.Click += new System.EventHandler(this.beginCrawl);
			// 
			// debugBox
			// 
			this.debugBox.AccessibleDescription = "Outputs stuff for debugging needs";
			this.debugBox.AccessibleName = "Console Window?";
			this.debugBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.debugBox.Location = new System.Drawing.Point(0, 214);
			this.debugBox.Name = "debugBox";
			this.debugBox.Size = new System.Drawing.Size(701, 354);
			this.debugBox.TabIndex = 3;
			this.debugBox.Text = "";
			this.debugBox.TextChanged += new System.EventHandler(this.debugBox_TextChanged);
			// 
			// targetFolderInput
			// 
			this.targetFolderInput.AccessibleDescription = "Select the folder to save crawled images";
			this.targetFolderInput.AccessibleName = "Target Folder Selection";
			this.targetFolderInput.Location = new System.Drawing.Point(12, 38);
			this.targetFolderInput.Name = "targetFolderInput";
			this.targetFolderInput.Size = new System.Drawing.Size(448, 20);
			this.targetFolderInput.TabIndex = 5;
			this.targetFolderInput.Text = "C:\\Users\\Kjeld\\Desktop\\CrawledImages";
			this.targetFolderInput.Click += new System.EventHandler(this.selectFolderButton_Click);
			// 
			// stopCrawl
			// 
			this.stopCrawl.AccessibleDescription = "Clicking here will stop the crawling process";
			this.stopCrawl.AccessibleName = "Stop Crawl Button";
			this.stopCrawl.Location = new System.Drawing.Point(93, 64);
			this.stopCrawl.Name = "stopCrawl";
			this.stopCrawl.Size = new System.Drawing.Size(75, 23);
			this.stopCrawl.TabIndex = 6;
			this.stopCrawl.Text = "Stop!";
			this.stopCrawl.UseVisualStyleBackColor = true;
			this.stopCrawl.Click += new System.EventHandler(this.stopCrawl_Click);
			// 
			// destnationLabel
			// 
			this.destnationLabel.AccessibleDescription = "Crawled Images will be saved here";
			this.destnationLabel.AccessibleName = "Destination Input";
			this.destnationLabel.AutoSize = true;
			this.destnationLabel.Location = new System.Drawing.Point(466, 41);
			this.destnationLabel.Name = "destnationLabel";
			this.destnationLabel.Size = new System.Drawing.Size(60, 13);
			this.destnationLabel.TabIndex = 7;
			this.destnationLabel.Text = "Destination";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(701, 568);
			this.Controls.Add(this.destnationLabel);
			this.Controls.Add(this.stopCrawl);
			this.Controls.Add(this.targetFolderInput);
			this.Controls.Add(this.debugBox);
			this.Controls.Add(this.crawlButton);
			this.Controls.Add(this.URLLabel);
			this.Controls.Add(this.URLInput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLInput;
        private System.Windows.Forms.Label URLLabel;
        private System.Windows.Forms.Button crawlButton;
        private System.Windows.Forms.RichTextBox debugBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox targetFolderInput;
		private System.Windows.Forms.Button stopCrawl;
		private System.Windows.Forms.Label destnationLabel;
    }
}

