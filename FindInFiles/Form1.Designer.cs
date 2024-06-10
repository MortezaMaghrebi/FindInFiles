namespace FindInFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tBrowse = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tFind = new System.Windows.Forms.TextBox();
            this.tReplace = new System.Windows.Forms.TextBox();
            this.bFindAll = new System.Windows.Forms.Button();
            this.bReplaceAll = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFileTypes = new System.Windows.Forms.TextBox();
            this.lStatus = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.bReplaceAllThisFile = new System.Windows.Forms.Button();
            this.bSaveThisFile = new System.Windows.Forms.Button();
            this.lItemsFound = new System.Windows.Forms.Label();
            this.lSelectedFile = new System.Windows.Forms.Label();
            this.pThisFile = new System.Windows.Forms.Panel();
            this.bReplaceThis = new System.Windows.Forms.Button();
            this.bFindNext = new System.Windows.Forms.Button();
            this.bChange = new System.Windows.Forms.Button();
            this.bpaste2 = new System.Windows.Forms.Button();
            this.bpaste1 = new System.Windows.Forms.Button();
            this.cMatchWholeWord = new System.Windows.Forms.CheckBox();
            this.cMatchCase = new System.Windows.Forms.CheckBox();
            this.pThisFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // tBrowse
            // 
            this.tBrowse.Location = new System.Drawing.Point(19, 15);
            this.tBrowse.Name = "tBrowse";
            this.tBrowse.Size = new System.Drawing.Size(426, 20);
            this.tBrowse.TabIndex = 0;
            // 
            // bBrowse
            // 
            this.bBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bBrowse.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bBrowse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bBrowse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBrowse.Location = new System.Drawing.Point(451, 15);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(75, 23);
            this.bBrowse.TabIndex = 1;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(20, 155);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(536, 316);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Find:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Replace:";
            // 
            // tFind
            // 
            this.tFind.Location = new System.Drawing.Point(73, 56);
            this.tFind.Name = "tFind";
            this.tFind.Size = new System.Drawing.Size(124, 20);
            this.tFind.TabIndex = 5;
            this.tFind.Text = "FALSE";
            this.tFind.TextChanged += new System.EventHandler(this.tFind_TextChanged);
            // 
            // tReplace
            // 
            this.tReplace.Location = new System.Drawing.Point(73, 87);
            this.tReplace.Name = "tReplace";
            this.tReplace.Size = new System.Drawing.Size(124, 20);
            this.tReplace.TabIndex = 6;
            this.tReplace.TextChanged += new System.EventHandler(this.tReplace_TextChanged);
            // 
            // bFindAll
            // 
            this.bFindAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFindAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bFindAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bFindAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bFindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFindAll.Location = new System.Drawing.Point(227, 54);
            this.bFindAll.Name = "bFindAll";
            this.bFindAll.Size = new System.Drawing.Size(188, 23);
            this.bFindAll.TabIndex = 7;
            this.bFindAll.Text = "Find All In Files";
            this.bFindAll.UseVisualStyleBackColor = true;
            this.bFindAll.Click += new System.EventHandler(this.bFindAll_Click);
            // 
            // bReplaceAll
            // 
            this.bReplaceAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bReplaceAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bReplaceAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bReplaceAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bReplaceAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReplaceAll.Location = new System.Drawing.Point(227, 85);
            this.bReplaceAll.Name = "bReplaceAll";
            this.bReplaceAll.Size = new System.Drawing.Size(188, 23);
            this.bReplaceAll.TabIndex = 8;
            this.bReplaceAll.Text = "Replace All In All Files With Save";
            this.bReplaceAll.UseVisualStyleBackColor = true;
            this.bReplaceAll.Click += new System.EventHandler(this.bReplaceAll_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "File types:";
            // 
            // txtFileTypes
            // 
            this.txtFileTypes.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileTypes.Location = new System.Drawing.Point(609, 14);
            this.txtFileTypes.Name = "txtFileTypes";
            this.txtFileTypes.Size = new System.Drawing.Size(271, 25);
            this.txtFileTypes.TabIndex = 9;
            this.txtFileTypes.Text = "*.c,*.h,*.cs,*.txt";
            this.txtFileTypes.TextChanged += new System.EventHandler(this.txtFileTypes_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lStatus.Location = new System.Drawing.Point(0, 485);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(1108, 13);
            this.lStatus.TabIndex = 11;
            this.lStatus.Text = "Status";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(563, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(532, 315);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // bReplaceAllThisFile
            // 
            this.bReplaceAllThisFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bReplaceAllThisFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bReplaceAllThisFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bReplaceAllThisFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bReplaceAllThisFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReplaceAllThisFile.Location = new System.Drawing.Point(3, 3);
            this.bReplaceAllThisFile.Name = "bReplaceAllThisFile";
            this.bReplaceAllThisFile.Size = new System.Drawing.Size(273, 23);
            this.bReplaceAllThisFile.TabIndex = 13;
            this.bReplaceAllThisFile.Text = "Replace All In This File With Save";
            this.bReplaceAllThisFile.UseVisualStyleBackColor = true;
            this.bReplaceAllThisFile.Click += new System.EventHandler(this.bReplaceAllThisFile_Click);
            // 
            // bSaveThisFile
            // 
            this.bSaveThisFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bSaveThisFile.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSaveThisFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bSaveThisFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bSaveThisFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSaveThisFile.Location = new System.Drawing.Point(432, 3);
            this.bSaveThisFile.Name = "bSaveThisFile";
            this.bSaveThisFile.Size = new System.Drawing.Size(97, 23);
            this.bSaveThisFile.TabIndex = 14;
            this.bSaveThisFile.Text = "Save This File";
            this.bSaveThisFile.UseVisualStyleBackColor = true;
            this.bSaveThisFile.Click += new System.EventHandler(this.bSaveThisFile_Click);
            // 
            // lItemsFound
            // 
            this.lItemsFound.AutoSize = true;
            this.lItemsFound.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lItemsFound.Location = new System.Drawing.Point(18, 130);
            this.lItemsFound.Name = "lItemsFound";
            this.lItemsFound.Size = new System.Drawing.Size(89, 18);
            this.lItemsFound.TabIndex = 17;
            this.lItemsFound.Text = "Items Found:";
            // 
            // lSelectedFile
            // 
            this.lSelectedFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSelectedFile.ForeColor = System.Drawing.Color.Gray;
            this.lSelectedFile.Location = new System.Drawing.Point(3, 29);
            this.lSelectedFile.Name = "lSelectedFile";
            this.lSelectedFile.Size = new System.Drawing.Size(528, 38);
            this.lSelectedFile.TabIndex = 18;
            this.lSelectedFile.Text = "Selected File:";
            this.lSelectedFile.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // pThisFile
            // 
            this.pThisFile.Controls.Add(this.bReplaceThis);
            this.pThisFile.Controls.Add(this.bFindNext);
            this.pThisFile.Controls.Add(this.bReplaceAllThisFile);
            this.pThisFile.Controls.Add(this.lSelectedFile);
            this.pThisFile.Controls.Add(this.bSaveThisFile);
            this.pThisFile.Location = new System.Drawing.Point(565, 81);
            this.pThisFile.Name = "pThisFile";
            this.pThisFile.Size = new System.Drawing.Size(532, 74);
            this.pThisFile.TabIndex = 19;
            // 
            // bReplaceThis
            // 
            this.bReplaceThis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bReplaceThis.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bReplaceThis.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bReplaceThis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bReplaceThis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReplaceThis.Location = new System.Drawing.Point(357, 3);
            this.bReplaceThis.Name = "bReplaceThis";
            this.bReplaceThis.Size = new System.Drawing.Size(71, 23);
            this.bReplaceThis.TabIndex = 20;
            this.bReplaceThis.Text = "Replace";
            this.bReplaceThis.UseVisualStyleBackColor = true;
            this.bReplaceThis.Click += new System.EventHandler(this.bReplaceThis_Click);
            // 
            // bFindNext
            // 
            this.bFindNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bFindNext.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bFindNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bFindNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(240)))), ((int)(((byte)(53)))), ((int)(((byte)(8)))));
            this.bFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bFindNext.Location = new System.Drawing.Point(282, 3);
            this.bFindNext.Name = "bFindNext";
            this.bFindNext.Size = new System.Drawing.Size(71, 23);
            this.bFindNext.TabIndex = 19;
            this.bFindNext.Text = "Find Next";
            this.bFindNext.UseVisualStyleBackColor = true;
            this.bFindNext.Click += new System.EventHandler(this.bFindNext_Click);
            // 
            // bChange
            // 
            this.bChange.BackgroundImage = global::FindInFiles.Properties.Resources.icons8_change_32;
            this.bChange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bChange.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bChange.FlatAppearance.BorderSize = 0;
            this.bChange.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bChange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bChange.Location = new System.Drawing.Point(46, 69);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(21, 20);
            this.bChange.TabIndex = 20;
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.bChange_Click);
            // 
            // bpaste2
            // 
            this.bpaste2.BackgroundImage = global::FindInFiles.Properties.Resources.icons8_paste_32;
            this.bpaste2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bpaste2.FlatAppearance.BorderSize = 0;
            this.bpaste2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bpaste2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bpaste2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bpaste2.Location = new System.Drawing.Point(200, 86);
            this.bpaste2.Name = "bpaste2";
            this.bpaste2.Size = new System.Drawing.Size(21, 20);
            this.bpaste2.TabIndex = 16;
            this.bpaste2.UseVisualStyleBackColor = true;
            this.bpaste2.Click += new System.EventHandler(this.bpaste2_Click);
            // 
            // bpaste1
            // 
            this.bpaste1.BackgroundImage = global::FindInFiles.Properties.Resources.icons8_paste_32;
            this.bpaste1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bpaste1.FlatAppearance.BorderSize = 0;
            this.bpaste1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bpaste1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bpaste1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bpaste1.Location = new System.Drawing.Point(200, 56);
            this.bpaste1.Name = "bpaste1";
            this.bpaste1.Size = new System.Drawing.Size(21, 20);
            this.bpaste1.TabIndex = 15;
            this.bpaste1.UseVisualStyleBackColor = true;
            this.bpaste1.Click += new System.EventHandler(this.bpaste1_Click);
            // 
            // cMatchWholeWord
            // 
            this.cMatchWholeWord.AutoSize = true;
            this.cMatchWholeWord.Location = new System.Drawing.Point(421, 60);
            this.cMatchWholeWord.Name = "cMatchWholeWord";
            this.cMatchWholeWord.Size = new System.Drawing.Size(119, 17);
            this.cMatchWholeWord.TabIndex = 21;
            this.cMatchWholeWord.Text = "Match Whole Word";
            this.cMatchWholeWord.UseVisualStyleBackColor = true;
            // 
            // cMatchCase
            // 
            this.cMatchCase.AutoSize = true;
            this.cMatchCase.Checked = true;
            this.cMatchCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMatchCase.Location = new System.Drawing.Point(421, 83);
            this.cMatchCase.Name = "cMatchCase";
            this.cMatchCase.Size = new System.Drawing.Size(83, 17);
            this.cMatchCase.TabIndex = 22;
            this.cMatchCase.Text = "Match Case";
            this.cMatchCase.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 498);
            this.Controls.Add(this.cMatchCase);
            this.Controls.Add(this.cMatchWholeWord);
            this.Controls.Add(this.pThisFile);
            this.Controls.Add(this.lItemsFound);
            this.Controls.Add(this.bpaste2);
            this.Controls.Add(this.bpaste1);
            this.Controls.Add(this.lStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFileTypes);
            this.Controls.Add(this.bReplaceAll);
            this.Controls.Add(this.bFindAll);
            this.Controls.Add(this.tReplace);
            this.Controls.Add(this.tFind);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tBrowse);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.bChange);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1124, 315);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find In Files";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.pThisFile.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBrowse;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tFind;
        private System.Windows.Forms.TextBox tReplace;
        private System.Windows.Forms.Button bFindAll;
        private System.Windows.Forms.Button bReplaceAll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFileTypes;
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button bReplaceAllThisFile;
        private System.Windows.Forms.Button bSaveThisFile;
        private System.Windows.Forms.Button bpaste1;
        private System.Windows.Forms.Button bpaste2;
        private System.Windows.Forms.Label lItemsFound;
        private System.Windows.Forms.Label lSelectedFile;
        private System.Windows.Forms.Panel pThisFile;
        private System.Windows.Forms.Button bReplaceThis;
        private System.Windows.Forms.Button bFindNext;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.CheckBox cMatchWholeWord;
        private System.Windows.Forms.CheckBox cMatchCase;
    }
}

