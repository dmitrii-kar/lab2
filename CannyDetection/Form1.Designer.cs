namespace CannyDetection
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaussianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.preProcessingToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(575, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // LoadItem
            // 
            this.LoadItem.Name = "LoadItem";
            this.LoadItem.Size = new System.Drawing.Size(117, 26);
            this.LoadItem.Text = "Load";
            this.LoadItem.Click += new System.EventHandler(this.LoadItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveItem);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitItem);
            // 
            // preProcessingToolStripMenuItem
            // 
            this.preProcessingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.grayScaleToolStripMenuItem});
            this.preProcessingToolStripMenuItem.Name = "preProcessingToolStripMenuItem";
            this.preProcessingToolStripMenuItem.Size = new System.Drawing.Size(118, 24);
            this.preProcessingToolStripMenuItem.Text = "Pre-Processing";
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.GrayScaleItem);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gaussianToolStripMenuItem,
            this.sobleToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.filterToolStripMenuItem.Text = "Canny";
            this.filterToolStripMenuItem.Click += new System.EventHandler(this.filterToolStripMenuItem_Click);
            // 
            // gaussianToolStripMenuItem
            // 
            this.gaussianToolStripMenuItem.Name = "gaussianToolStripMenuItem";
            this.gaussianToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.gaussianToolStripMenuItem.Text = "Gaussian";
            this.gaussianToolStripMenuItem.Click += new System.EventHandler(this.GaussianItem);
            // 
            // sobleToolStripMenuItem
            // 
            this.sobleToolStripMenuItem.Name = "sobleToolStripMenuItem";
            this.sobleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.sobleToolStripMenuItem.Text = "Canny";
            this.sobleToolStripMenuItem.Click += new System.EventHandler(this.sobleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 517);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaussianToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobleToolStripMenuItem;
    }
}

