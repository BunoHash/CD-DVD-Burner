using System;
using System.ComponentModel;

namespace BurnMedia
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.devicesComboBox = new System.Windows.Forms.ComboBox();
            this.backgroundBurnWorker = new System.ComponentModel.BackgroundWorker();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundFormatWorker = new System.ComponentModel.BackgroundWorker();
            this.tabPageBurn = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFormatStatusText = new System.Windows.Forms.Label();
            this.formatProgressBar = new System.Windows.Forms.ProgressBar();
            this.labelStatusText = new System.Windows.Forms.Label();
            this.checkBoxEject = new System.Windows.Forms.CheckBox();
            this.statusProgressBar = new System.Windows.Forms.ProgressBar();
            this.buttonBurn = new System.Windows.Forms.Button();
            this.textBoxLabel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddFolders = new System.Windows.Forms.Button();
            this.buttonAddFiles = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageBurn.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesComboBox
            // 
            this.devicesComboBox.FormattingEnabled = true;
            this.devicesComboBox.Location = new System.Drawing.Point(430, 12);
            this.devicesComboBox.Name = "devicesComboBox";
            this.devicesComboBox.Size = new System.Drawing.Size(196, 21);
            this.devicesComboBox.TabIndex = 1;
            this.devicesComboBox.SelectedIndexChanged += new System.EventHandler(this.devicesComboBox_SelectedIndexChanged);
            this.devicesComboBox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.devicesComboBox_Format);
            // 
            // backgroundBurnWorker
            // 
            this.backgroundBurnWorker.WorkerReportsProgress = true;
            this.backgroundBurnWorker.WorkerSupportsCancellation = true;
            this.backgroundBurnWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundBurnWorker_DoWork);
            this.backgroundBurnWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundBurnWorker_ProgressChanged);
            this.backgroundBurnWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundBurnWorker_RunWorkerCompleted);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "All Files (*.*)|*.*";
            // 
            // backgroundFormatWorker
            // 
            this.backgroundFormatWorker.WorkerReportsProgress = true;
            this.backgroundFormatWorker.WorkerSupportsCancellation = true;
            this.backgroundFormatWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundFormatWorker_DoWork);
            this.backgroundFormatWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundFormatWorker_ProgressChanged);
            this.backgroundFormatWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundFormatWorker_RunWorkerCompleted);
            // 
            // tabPageBurn
            // 
            this.tabPageBurn.Controls.Add(this.groupBox2);
            this.tabPageBurn.Controls.Add(this.groupBox1);
            this.tabPageBurn.Location = new System.Drawing.Point(4, 22);
            this.tabPageBurn.Name = "tabPageBurn";
            this.tabPageBurn.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBurn.Size = new System.Drawing.Size(610, 294);
            this.tabPageBurn.TabIndex = 0;
            this.tabPageBurn.Text = "Burn Files";
            this.tabPageBurn.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFormatStatusText);
            this.groupBox2.Controls.Add(this.formatProgressBar);
            this.groupBox2.Controls.Add(this.labelStatusText);
            this.groupBox2.Controls.Add(this.checkBoxEject);
            this.groupBox2.Controls.Add(this.statusProgressBar);
            this.groupBox2.Controls.Add(this.buttonBurn);
            this.groupBox2.Controls.Add(this.textBoxLabel);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(359, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 288);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Burning";
            // 
            // labelFormatStatusText
            // 
            this.labelFormatStatusText.Location = new System.Drawing.Point(6, 164);
            this.labelFormatStatusText.Name = "labelFormatStatusText";
            this.labelFormatStatusText.Size = new System.Drawing.Size(233, 27);
            this.labelFormatStatusText.TabIndex = 16;
            this.labelFormatStatusText.Text = "status";
            this.labelFormatStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // formatProgressBar
            // 
            this.formatProgressBar.Location = new System.Drawing.Point(9, 208);
            this.formatProgressBar.Name = "formatProgressBar";
            this.formatProgressBar.Size = new System.Drawing.Size(230, 16);
            this.formatProgressBar.TabIndex = 14;
            // 
            // labelStatusText
            // 
            this.labelStatusText.Location = new System.Drawing.Point(12, 227);
            this.labelStatusText.Name = "labelStatusText";
            this.labelStatusText.Size = new System.Drawing.Size(227, 24);
            this.labelStatusText.TabIndex = 7;
            this.labelStatusText.Text = "status";
            this.labelStatusText.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // checkBoxEject
            // 
            this.checkBoxEject.AutoSize = true;
            this.checkBoxEject.Checked = true;
            this.checkBoxEject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEject.Location = new System.Drawing.Point(108, 70);
            this.checkBoxEject.Name = "checkBoxEject";
            this.checkBoxEject.Size = new System.Drawing.Size(118, 17);
            this.checkBoxEject.TabIndex = 7;
            this.checkBoxEject.Text = "Eject when finished";
            this.checkBoxEject.UseVisualStyleBackColor = true;
            // 
            // statusProgressBar
            // 
            this.statusProgressBar.Location = new System.Drawing.Point(9, 266);
            this.statusProgressBar.Name = "statusProgressBar";
            this.statusProgressBar.Size = new System.Drawing.Size(230, 16);
            this.statusProgressBar.TabIndex = 8;
            // 
            // buttonBurn
            // 
            this.buttonBurn.Location = new System.Drawing.Point(9, 62);
            this.buttonBurn.Name = "buttonBurn";
            this.buttonBurn.Size = new System.Drawing.Size(88, 30);
            this.buttonBurn.TabIndex = 6;
            this.buttonBurn.Text = "&Burn";
            this.buttonBurn.UseVisualStyleBackColor = true;
            this.buttonBurn.Click += new System.EventHandler(this.buttonBurn_Click);
            // 
            // textBoxLabel
            // 
            this.textBoxLabel.Location = new System.Drawing.Point(108, 31);
            this.textBoxLabel.Name = "textBoxLabel";
            this.textBoxLabel.Size = new System.Drawing.Size(128, 20);
            this.textBoxLabel.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Volume Label:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddFolders);
            this.groupBox1.Controls.Add(this.buttonAddFiles);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.listBoxFiles);
            this.groupBox1.Location = new System.Drawing.Point(11, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 293);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Files to burn";
            // 
            // buttonAddFolders
            // 
            this.buttonAddFolders.Location = new System.Drawing.Point(100, 208);
            this.buttonAddFolders.Name = "buttonAddFolders";
            this.buttonAddFolders.Size = new System.Drawing.Size(98, 27);
            this.buttonAddFolders.TabIndex = 16;
            this.buttonAddFolders.Text = "Add Folders...";
            this.buttonAddFolders.UseVisualStyleBackColor = true;
            this.buttonAddFolders.Click += new System.EventHandler(this.buttonAddFolders_Click);
            // 
            // buttonAddFiles
            // 
            this.buttonAddFiles.Location = new System.Drawing.Point(10, 208);
            this.buttonAddFiles.Name = "buttonAddFiles";
            this.buttonAddFiles.Size = new System.Drawing.Size(84, 27);
            this.buttonAddFiles.TabIndex = 15;
            this.buttonAddFiles.Text = "Add Files...";
            this.buttonAddFiles.UseVisualStyleBackColor = true;
            this.buttonAddFiles.Click += new System.EventHandler(this.buttonAddFiles_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(201, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Clear Burn Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.ItemHeight = 24;
            this.listBoxFiles.Location = new System.Drawing.Point(10, 19);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(315, 172);
            this.listBoxFiles.TabIndex = 0;
            this.listBoxFiles.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.listBoxFiles_DrawItem);
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxFiles_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBurn);
            this.tabControl1.Location = new System.Drawing.Point(12, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(618, 320);
            this.tabControl1.TabIndex = 11;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select Drive : ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 401);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.devicesComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "CD / DVD Burner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPageBurn.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void completedFormatting(object sender, AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ComboBox devicesComboBox;
        private System.ComponentModel.BackgroundWorker backgroundBurnWorker;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundFormatWorker;
        private System.Windows.Forms.TabPage tabPageBurn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFormatStatusText;
        private System.Windows.Forms.ProgressBar formatProgressBar;
        private System.Windows.Forms.Label labelStatusText;
        private System.Windows.Forms.ProgressBar statusProgressBar;
        private System.Windows.Forms.Button buttonBurn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBoxEject;
        private System.Windows.Forms.TextBox textBoxLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button buttonAddFolders;
        private System.Windows.Forms.Button buttonAddFiles;
        private System.Windows.Forms.Label label1;
    }
}

