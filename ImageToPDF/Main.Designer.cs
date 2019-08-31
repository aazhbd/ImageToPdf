namespace ImageToPDF
{
    partial class Main
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
            this.sourcePath = new System.Windows.Forms.TextBox();
            this.sourceButton = new System.Windows.Forms.Button();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.destinationPath = new System.Windows.Forms.TextBox();
            this.destinationButton = new System.Windows.Forms.Button();
            this.convertButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.helpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sourcePath
            // 
            this.sourcePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sourcePath.Location = new System.Drawing.Point(136, 29);
            this.sourcePath.Name = "sourcePath";
            this.sourcePath.Size = new System.Drawing.Size(328, 24);
            this.sourcePath.TabIndex = 0;
            // 
            // sourceButton
            // 
            this.sourceButton.Location = new System.Drawing.Point(462, 28);
            this.sourceButton.Name = "sourceButton";
            this.sourceButton.Size = new System.Drawing.Size(110, 25);
            this.sourceButton.TabIndex = 1;
            this.sourceButton.Text = "Open File";
            this.sourceButton.UseVisualStyleBackColor = true;
            this.sourceButton.Click += new System.EventHandler(this.SourceButton_Click);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceLabel.Location = new System.Drawing.Point(12, 32);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(99, 18);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "Path to Image";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLabel.Location = new System.Drawing.Point(12, 76);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(93, 18);
            this.DestinationLabel.TabIndex = 3;
            this.DestinationLabel.Text = "Folder to Pdf";
            // 
            // destinationPath
            // 
            this.destinationPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destinationPath.Location = new System.Drawing.Point(136, 73);
            this.destinationPath.Name = "destinationPath";
            this.destinationPath.Size = new System.Drawing.Size(328, 24);
            this.destinationPath.TabIndex = 4;
            // 
            // destinationButton
            // 
            this.destinationButton.Location = new System.Drawing.Point(462, 73);
            this.destinationButton.Name = "destinationButton";
            this.destinationButton.Size = new System.Drawing.Size(110, 24);
            this.destinationButton.TabIndex = 5;
            this.destinationButton.Text = "Open Folder";
            this.destinationButton.UseVisualStyleBackColor = true;
            this.destinationButton.Click += new System.EventHandler(this.DestinationButton_Click);
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(362, 118);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(210, 31);
            this.convertButton.TabIndex = 6;
            this.convertButton.Text = "Convert To PDF";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(258, 118);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(98, 31);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset Path";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // helpLinkLabel
            // 
            this.helpLinkLabel.AutoSize = true;
            this.helpLinkLabel.Location = new System.Drawing.Point(12, 127);
            this.helpLinkLabel.Name = "helpLinkLabel";
            this.helpLinkLabel.Size = new System.Drawing.Size(137, 13);
            this.helpLinkLabel.TabIndex = 9;
            this.helpLinkLabel.TabStop = true;
            this.helpLinkLabel.Text = "http://articulatedlogic.com/";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 161);
            this.Controls.Add(this.helpLinkLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.destinationButton);
            this.Controls.Add(this.destinationPath);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.sourceButton);
            this.Controls.Add(this.sourcePath);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Image To PDF";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sourcePath;
        private System.Windows.Forms.Button sourceButton;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.TextBox destinationPath;
        private System.Windows.Forms.Button destinationButton;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.LinkLabel helpLinkLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

