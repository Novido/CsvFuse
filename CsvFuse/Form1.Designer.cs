namespace CsvFuse
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.addCsvButton = new System.Windows.Forms.ToolStripButton();
            this.removeFileButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.generatedFileNameTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.generateCsvButtton = new System.Windows.Forms.ToolStripButton();
            this.listViewCsvFiles = new System.Windows.Forms.ListView();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listViewCsvFiles, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCsvButton,
            this.removeFileButton,
            this.toolStripSeparator1,
            this.generatedFileNameTextBox,
            this.generateCsvButtton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // addCsvButton
            // 
            this.addCsvButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addCsvButton.Image = global::CsvFuse.Properties.Resources._021_plus;
            this.addCsvButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCsvButton.Name = "addCsvButton";
            this.addCsvButton.Size = new System.Drawing.Size(23, 22);
            this.addCsvButton.Text = "Add csv files";
            this.addCsvButton.Click += new System.EventHandler(this.AddCsvButtton_Click);
            // 
            // removeFileButton
            // 
            this.removeFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeFileButton.Image = global::CsvFuse.Properties.Resources._026_error;
            this.removeFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeFileButton.Name = "removeFileButton";
            this.removeFileButton.Size = new System.Drawing.Size(23, 22);
            this.removeFileButton.Text = "Remove selected file";
            this.removeFileButton.Click += new System.EventHandler(this.RemoveFileButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // generatedFileNameTextBox
            // 
            this.generatedFileNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.generatedFileNameTextBox.Name = "generatedFileNameTextBox";
            this.generatedFileNameTextBox.Size = new System.Drawing.Size(425, 25);
            this.generatedFileNameTextBox.Text = "filename.csv";
            // 
            // generateCsvButtton
            // 
            this.generateCsvButtton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.generateCsvButtton.Image = global::CsvFuse.Properties.Resources.checked_1;
            this.generateCsvButtton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.generateCsvButtton.Name = "generateCsvButtton";
            this.generateCsvButtton.Size = new System.Drawing.Size(23, 22);
            this.generateCsvButtton.Text = "Merge Files";
            this.generateCsvButtton.Click += new System.EventHandler(this.GenerateCsvButtton_Click);
            // 
            // listViewCsvFiles
            // 
            this.listViewCsvFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCsvFiles.Location = new System.Drawing.Point(3, 52);
            this.listViewCsvFiles.Name = "listViewCsvFiles";
            this.listViewCsvFiles.Size = new System.Drawing.Size(794, 395);
            this.listViewCsvFiles.TabIndex = 2;
            this.listViewCsvFiles.UseCompatibleStateImageBehavior = false;
            this.listViewCsvFiles.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CsvFuse";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton addCsvButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripTextBox generatedFileNameTextBox;
        private System.Windows.Forms.ToolStripButton removeFileButton;
        private System.Windows.Forms.ToolStripButton generateCsvButtton;
        private System.Windows.Forms.ListView listViewCsvFiles;
    }
}

