﻿namespace Analogy.LogViewer.Serilog
{
    partial class SerilogUCSettings
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExportSettings = new System.Windows.Forms.Button();
            this.lblLayout = new System.Windows.Forms.Label();
            this.txtNLogExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.txtbDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.rbtnCLEF = new System.Windows.Forms.RadioButton();
            this.rbJson = new System.Windows.Forms.RadioButton();
            this.rbSimpleTextFile = new System.Windows.Forms.RadioButton();
            this.tcSetttings = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txtbGuidFormat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lstbRegularExpressions = new System.Windows.Forms.ListBox();
            this.gbresult = new System.Windows.Forms.GroupBox();
            this.lblResultMessage = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtbTest = new System.Windows.Forms.TextBox();
            this.lblLogTest = new System.Windows.Forms.Label();
            this.txtbDateTimeFormat = new System.Windows.Forms.TextBox();
            this.txtbRegEx = new System.Windows.Forms.TextBox();
            this.lblDateTimeFormat = new System.Windows.Forms.Label();
            this.lblRegex = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.tcSetttings.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.gbresult.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(964, 707);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 47);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExportSettings
            // 
            this.btnExportSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExportSettings.Location = new System.Drawing.Point(825, 707);
            this.btnExportSettings.Name = "btnExportSettings";
            this.btnExportSettings.Size = new System.Drawing.Size(133, 47);
            this.btnExportSettings.TabIndex = 2;
            this.btnExportSettings.Text = "Export Settings";
            this.btnExportSettings.UseVisualStyleBackColor = true;
            this.btnExportSettings.Click += new System.EventHandler(this.btnExportSettings_Click);
            // 
            // lblLayout
            // 
            this.lblLayout.AutoSize = true;
            this.lblLayout.Location = new System.Drawing.Point(3, 6);
            this.lblLayout.Name = "lblLayout";
            this.lblLayout.Size = new System.Drawing.Size(49, 14);
            this.lblLayout.TabIndex = 3;
            this.lblLayout.Text = "Format:";
            // 
            // txtNLogExtension
            // 
            this.txtNLogExtension.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNLogExtension.Location = new System.Drawing.Point(197, 129);
            this.txtNLogExtension.Name = "txtNLogExtension";
            this.txtNLogExtension.Size = new System.Drawing.Size(899, 22);
            this.txtNLogExtension.TabIndex = 9;
            this.txtNLogExtension.Text = "*.Clef";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.Location = new System.Drawing.Point(3, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "Supported Log Formats (use ; as separator):";
            // 
            // btnImport
            // 
            this.btnImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImport.Location = new System.Drawing.Point(682, 707);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(137, 47);
            this.btnImport.TabIndex = 10;
            this.btnImport.Text = "Import settings";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // txtbDirectory
            // 
            this.txtbDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDirectory.Location = new System.Drawing.Point(197, 98);
            this.txtbDirectory.Name = "txtbDirectory";
            this.txtbDirectory.Size = new System.Drawing.Size(858, 22);
            this.txtbDirectory.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 14);
            this.label3.TabIndex = 11;
            this.label3.Text = "Default Logs Location:";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFolder.Location = new System.Drawing.Point(1063, 96);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(33, 29);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "..";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // rbtnCLEF
            // 
            this.rbtnCLEF.AutoSize = true;
            this.rbtnCLEF.Checked = true;
            this.rbtnCLEF.Location = new System.Drawing.Point(87, 3);
            this.rbtnCLEF.Name = "rbtnCLEF";
            this.rbtnCLEF.Size = new System.Drawing.Size(194, 18);
            this.rbtnCLEF.TabIndex = 14;
            this.rbtnCLEF.TabStop = true;
            this.rbtnCLEF.Text = "Compact Log Event File (CLEF)";
            this.rbtnCLEF.UseVisualStyleBackColor = true;
            // 
            // rbJson
            // 
            this.rbJson.AutoSize = true;
            this.rbJson.Enabled = false;
            this.rbJson.Location = new System.Drawing.Point(87, 51);
            this.rbJson.Name = "rbJson";
            this.rbJson.Size = new System.Drawing.Size(130, 18);
            this.rbJson.TabIndex = 15;
            this.rbJson.Text = "Json Log Event File";
            this.rbJson.UseVisualStyleBackColor = true;
            // 
            // rbSimpleTextFile
            // 
            this.rbSimpleTextFile.AutoSize = true;
            this.rbSimpleTextFile.Location = new System.Drawing.Point(87, 27);
            this.rbSimpleTextFile.Name = "rbSimpleTextFile";
            this.rbSimpleTextFile.Size = new System.Drawing.Size(240, 18);
            this.rbSimpleTextFile.TabIndex = 16;
            this.rbSimpleTextFile.Text = "Text file - use regular expression parser";
            this.rbSimpleTextFile.UseVisualStyleBackColor = true;
            // 
            // tcSetttings
            // 
            this.tcSetttings.Controls.Add(this.tabPage2);
            this.tcSetttings.Location = new System.Drawing.Point(6, 172);
            this.tcSetttings.Name = "tcSetttings";
            this.tcSetttings.SelectedIndex = 0;
            this.tcSetttings.Size = new System.Drawing.Size(1090, 529);
            this.tcSetttings.TabIndex = 45;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtbGuidFormat);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnDelete);
            this.tabPage2.Controls.Add(this.btnAdd);
            this.tabPage2.Controls.Add(this.lstbRegularExpressions);
            this.tabPage2.Controls.Add(this.gbresult);
            this.tabPage2.Controls.Add(this.txtbTest);
            this.tabPage2.Controls.Add(this.lblLogTest);
            this.tabPage2.Controls.Add(this.txtbDateTimeFormat);
            this.tabPage2.Controls.Add(this.txtbRegEx);
            this.tabPage2.Controls.Add(this.lblDateTimeFormat);
            this.tabPage2.Controls.Add(this.lblRegex);
            this.tabPage2.Controls.Add(this.btnTest);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1082, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Text file - Regular Expression Parser";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtbGuidFormat
            // 
            this.txtbGuidFormat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbGuidFormat.Location = new System.Drawing.Point(652, 58);
            this.txtbGuidFormat.Name = "txtbGuidFormat";
            this.txtbGuidFormat.Size = new System.Drawing.Size(360, 22);
            this.txtbGuidFormat.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AccessibleDescription = "";
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoEllipsis = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 47);
            this.label1.TabIndex = 57;
            this.label1.Text = "Guid Format (The format parameter can be \"N\", \"D\", \"B\", \"P\", or \"X\". If format is" +
    " null or an empty string (\"\"), \"D\" is used):";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(986, 167);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 25);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(1029, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 25);
            this.btnAdd.TabIndex = 55;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstbRegularExpressions
            // 
            this.lstbRegularExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstbRegularExpressions.FormattingEnabled = true;
            this.lstbRegularExpressions.ItemHeight = 14;
            this.lstbRegularExpressions.Location = new System.Drawing.Point(9, 113);
            this.lstbRegularExpressions.Name = "lstbRegularExpressions";
            this.lstbRegularExpressions.Size = new System.Drawing.Size(965, 144);
            this.lstbRegularExpressions.TabIndex = 54;
            // 
            // gbresult
            // 
            this.gbresult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbresult.Controls.Add(this.lblResultMessage);
            this.gbresult.Controls.Add(this.lblResult);
            this.gbresult.Location = new System.Drawing.Point(9, 294);
            this.gbresult.Name = "gbresult";
            this.gbresult.Size = new System.Drawing.Size(965, 192);
            this.gbresult.TabIndex = 52;
            this.gbresult.TabStop = false;
            this.gbresult.Text = "Result";
            // 
            // lblResultMessage
            // 
            this.lblResultMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResultMessage.Location = new System.Drawing.Point(3, 37);
            this.lblResultMessage.Name = "lblResultMessage";
            this.lblResultMessage.Size = new System.Drawing.Size(959, 152);
            this.lblResultMessage.TabIndex = 31;
            // 
            // lblResult
            // 
            this.lblResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblResult.Location = new System.Drawing.Point(3, 18);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(959, 19);
            this.lblResult.TabIndex = 30;
            // 
            // txtbTest
            // 
            this.txtbTest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbTest.Location = new System.Drawing.Point(119, 266);
            this.txtbTest.Name = "txtbTest";
            this.txtbTest.Size = new System.Drawing.Size(855, 22);
            this.txtbTest.TabIndex = 51;
            // 
            // lblLogTest
            // 
            this.lblLogTest.AccessibleDescription = "";
            this.lblLogTest.AutoSize = true;
            this.lblLogTest.Location = new System.Drawing.Point(6, 269);
            this.lblLogTest.Name = "lblLogTest";
            this.lblLogTest.Size = new System.Drawing.Size(95, 14);
            this.lblLogTest.TabIndex = 50;
            this.lblLogTest.Text = "Log line to test:";
            // 
            // txtbDateTimeFormat
            // 
            this.txtbDateTimeFormat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDateTimeFormat.Location = new System.Drawing.Point(188, 29);
            this.txtbDateTimeFormat.Name = "txtbDateTimeFormat";
            this.txtbDateTimeFormat.Size = new System.Drawing.Size(888, 22);
            this.txtbDateTimeFormat.TabIndex = 48;
            this.txtbDateTimeFormat.Text = "yyyy-MM-dd HH:mm:ss,fff";
            // 
            // txtbRegEx
            // 
            this.txtbRegEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbRegEx.Location = new System.Drawing.Point(188, 6);
            this.txtbRegEx.Name = "txtbRegEx";
            this.txtbRegEx.Size = new System.Drawing.Size(888, 22);
            this.txtbRegEx.TabIndex = 49;
            // 
            // lblDateTimeFormat
            // 
            this.lblDateTimeFormat.AccessibleDescription = "";
            this.lblDateTimeFormat.AutoSize = true;
            this.lblDateTimeFormat.Location = new System.Drawing.Point(6, 37);
            this.lblDateTimeFormat.Name = "lblDateTimeFormat";
            this.lblDateTimeFormat.Size = new System.Drawing.Size(124, 14);
            this.lblDateTimeFormat.TabIndex = 46;
            this.lblDateTimeFormat.Text = "DateTime log format:";
            // 
            // lblRegex
            // 
            this.lblRegex.AccessibleDescription = "";
            this.lblRegex.AutoSize = true;
            this.lblRegex.Location = new System.Drawing.Point(6, 10);
            this.lblRegex.Name = "lblRegex";
            this.lblRegex.Size = new System.Drawing.Size(136, 14);
            this.lblRegex.TabIndex = 47;
            this.lblRegex.Text = "Log Regular Expression:";
            // 
            // btnTest
            // 
            this.btnTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTest.Location = new System.Drawing.Point(1029, 266);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(47, 25);
            this.btnTest.TabIndex = 44;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // SerilogUCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcSetttings);
            this.Controls.Add(this.rbSimpleTextFile);
            this.Controls.Add(this.rbJson);
            this.Controls.Add(this.rbtnCLEF);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.txtbDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.txtNLogExtension);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLayout);
            this.Controls.Add(this.btnExportSettings);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "SerilogUCSettings";
            this.Size = new System.Drawing.Size(1100, 757);
            this.Load += new System.EventHandler(this.NLogSettings_Load);
            this.tcSetttings.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.gbresult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExportSettings;
        private System.Windows.Forms.Label lblLayout;
        private System.Windows.Forms.TextBox txtNLogExtension;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.TextBox txtbDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.RadioButton rbtnCLEF;
        private System.Windows.Forms.RadioButton rbJson;
        private System.Windows.Forms.RadioButton rbSimpleTextFile;
        private System.Windows.Forms.TabControl tcSetttings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtbGuidFormat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListBox lstbRegularExpressions;
        private System.Windows.Forms.GroupBox gbresult;
        private System.Windows.Forms.Label lblResultMessage;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtbTest;
        private System.Windows.Forms.Label lblLogTest;
        private System.Windows.Forms.TextBox txtbDateTimeFormat;
        private System.Windows.Forms.TextBox txtbRegEx;
        private System.Windows.Forms.Label lblDateTimeFormat;
        private System.Windows.Forms.Label lblRegex;
        private System.Windows.Forms.Button btnTest;
    }
}
