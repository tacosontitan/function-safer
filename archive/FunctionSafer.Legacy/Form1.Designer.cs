namespace Function_Safer_v2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.resultLabel = new System.Windows.Forms.Label();
            this.resultBox = new System.Windows.Forms.RichTextBox();
            this.functionInfoContainer = new System.Windows.Forms.GroupBox();
            this.codesLabel = new System.Windows.Forms.Label();
            this.codeList = new System.Windows.Forms.ListBox();
            this.functionList = new System.Windows.Forms.ListBox();
            this.sizeLabel = new System.Windows.Forms.Label();
            this.jrRa8Label = new System.Windows.Forms.Label();
            this.functionTopLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.submitFunctionButton = new System.Windows.Forms.Button();
            this.functionNameLabel = new System.Windows.Forms.Label();
            this.functionNameBox = new System.Windows.Forms.TextBox();
            this.functionTopBox = new System.Windows.Forms.TextBox();
            this.functionTopLabel2 = new System.Windows.Forms.Label();
            this.jrRa8Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.codeAddressBox = new System.Windows.Forms.TextBox();
            this.codeAddressLabel = new System.Windows.Forms.Label();
            this.submitCodeButton = new System.Windows.Forms.Button();
            this.copyViewButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.numberOfFunctionsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.codesInFunctionLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.codeDistanceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.languageModifier = new System.Windows.Forms.Timer(this.components);
            this.functionInfoContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.BackColor = System.Drawing.Color.Transparent;
            this.resultLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLabel.ForeColor = System.Drawing.Color.White;
            this.resultLabel.Location = new System.Drawing.Point(577, 27);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(47, 12);
            this.resultLabel.TabIndex = 0;
            this.resultLabel.Text = "Result";
            // 
            // resultBox
            // 
            this.resultBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resultBox.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.ForeColor = System.Drawing.Color.White;
            this.resultBox.Location = new System.Drawing.Point(520, 43);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(165, 489);
            this.resultBox.TabIndex = 2;
            this.resultBox.Text = "";
            // 
            // functionInfoContainer
            // 
            this.functionInfoContainer.BackColor = System.Drawing.Color.Transparent;
            this.functionInfoContainer.Controls.Add(this.codesLabel);
            this.functionInfoContainer.Controls.Add(this.codeList);
            this.functionInfoContainer.Controls.Add(this.functionList);
            this.functionInfoContainer.Controls.Add(this.sizeLabel);
            this.functionInfoContainer.Controls.Add(this.jrRa8Label);
            this.functionInfoContainer.Controls.Add(this.functionTopLabel);
            this.functionInfoContainer.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionInfoContainer.ForeColor = System.Drawing.Color.White;
            this.functionInfoContainer.Location = new System.Drawing.Point(12, 147);
            this.functionInfoContainer.Name = "functionInfoContainer";
            this.functionInfoContainer.Size = new System.Drawing.Size(502, 300);
            this.functionInfoContainer.TabIndex = 3;
            this.functionInfoContainer.TabStop = false;
            this.functionInfoContainer.Text = "Function View";
            // 
            // codesLabel
            // 
            this.codesLabel.AutoSize = true;
            this.codesLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codesLabel.Location = new System.Drawing.Point(404, 19);
            this.codesLabel.Name = "codesLabel";
            this.codesLabel.Size = new System.Drawing.Size(40, 12);
            this.codesLabel.TabIndex = 6;
            this.codesLabel.Text = "Codes";
            // 
            // codeList
            // 
            this.codeList.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeList.FormattingEnabled = true;
            this.codeList.ItemHeight = 12;
            this.codeList.Location = new System.Drawing.Point(356, 32);
            this.codeList.Name = "codeList";
            this.codeList.Size = new System.Drawing.Size(140, 244);
            this.codeList.TabIndex = 5;
            this.codeList.SelectedIndexChanged += new System.EventHandler(this.UpdateCodeInfo);
            // 
            // functionList
            // 
            this.functionList.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionList.FormattingEnabled = true;
            this.functionList.ItemHeight = 12;
            this.functionList.Location = new System.Drawing.Point(6, 19);
            this.functionList.Name = "functionList";
            this.functionList.Size = new System.Drawing.Size(153, 256);
            this.functionList.TabIndex = 4;
            this.functionList.SelectedIndexChanged += new System.EventHandler(this.ViewFunction);
            // 
            // sizeLabel
            // 
            this.sizeLabel.AutoSize = true;
            this.sizeLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizeLabel.Location = new System.Drawing.Point(165, 143);
            this.sizeLabel.Name = "sizeLabel";
            this.sizeLabel.Size = new System.Drawing.Size(96, 12);
            this.sizeLabel.TabIndex = 3;
            this.sizeLabel.Text = "Size: 0 Bytes";
            // 
            // jrRa8Label
            // 
            this.jrRa8Label.AutoSize = true;
            this.jrRa8Label.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jrRa8Label.Location = new System.Drawing.Point(165, 130);
            this.jrRa8Label.Name = "jrRa8Label";
            this.jrRa8Label.Size = new System.Drawing.Size(138, 12);
            this.jrRa8Label.TabIndex = 2;
            this.jrRa8Label.Text = "Jr Ra + 8: 00000000";
            // 
            // functionTopLabel
            // 
            this.functionTopLabel.AutoSize = true;
            this.functionTopLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTopLabel.Location = new System.Drawing.Point(165, 117);
            this.functionTopLabel.Name = "functionTopLabel";
            this.functionTopLabel.Size = new System.Drawing.Size(159, 12);
            this.functionTopLabel.TabIndex = 1;
            this.functionTopLabel.Text = "Function Top: 00000000";
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.BackgroundImage = global::Function_Safer_v2.Properties.Resources.Studio_41;
            this.logoPicture.Location = new System.Drawing.Point(12, 482);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(502, 50);
            this.logoPicture.TabIndex = 4;
            this.logoPicture.TabStop = false;
            this.logoPicture.Click += new System.EventHandler(this.VisitUs);
            // 
            // submitFunctionButton
            // 
            this.submitFunctionButton.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitFunctionButton.Location = new System.Drawing.Point(114, 118);
            this.submitFunctionButton.Name = "submitFunctionButton";
            this.submitFunctionButton.Size = new System.Drawing.Size(146, 23);
            this.submitFunctionButton.TabIndex = 5;
            this.submitFunctionButton.Text = "Submit Function";
            this.submitFunctionButton.UseVisualStyleBackColor = true;
            this.submitFunctionButton.Click += new System.EventHandler(this.SubmitFunction);
            // 
            // functionNameLabel
            // 
            this.functionNameLabel.AutoSize = true;
            this.functionNameLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionNameLabel.ForeColor = System.Drawing.Color.White;
            this.functionNameLabel.Location = new System.Drawing.Point(5, 43);
            this.functionNameLabel.Name = "functionNameLabel";
            this.functionNameLabel.Size = new System.Drawing.Size(103, 12);
            this.functionNameLabel.TabIndex = 6;
            this.functionNameLabel.Text = "Function Name:";
            // 
            // functionNameBox
            // 
            this.functionNameBox.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionNameBox.Location = new System.Drawing.Point(114, 40);
            this.functionNameBox.MaxLength = 16;
            this.functionNameBox.Name = "functionNameBox";
            this.functionNameBox.Size = new System.Drawing.Size(146, 19);
            this.functionNameBox.TabIndex = 7;
            // 
            // functionTopBox
            // 
            this.functionTopBox.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTopBox.Location = new System.Drawing.Point(114, 66);
            this.functionTopBox.MaxLength = 8;
            this.functionTopBox.Name = "functionTopBox";
            this.functionTopBox.Size = new System.Drawing.Size(146, 19);
            this.functionTopBox.TabIndex = 9;
            // 
            // functionTopLabel2
            // 
            this.functionTopLabel2.AutoSize = true;
            this.functionTopLabel2.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.functionTopLabel2.ForeColor = System.Drawing.Color.White;
            this.functionTopLabel2.Location = new System.Drawing.Point(12, 69);
            this.functionTopLabel2.Name = "functionTopLabel2";
            this.functionTopLabel2.Size = new System.Drawing.Size(96, 12);
            this.functionTopLabel2.TabIndex = 8;
            this.functionTopLabel2.Text = "Function Top:";
            // 
            // jrRa8Box
            // 
            this.jrRa8Box.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jrRa8Box.Location = new System.Drawing.Point(114, 92);
            this.jrRa8Box.MaxLength = 8;
            this.jrRa8Box.Name = "jrRa8Box";
            this.jrRa8Box.Size = new System.Drawing.Size(146, 19);
            this.jrRa8Box.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(33, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jr Ra + 8:";
            // 
            // codeAddressBox
            // 
            this.codeAddressBox.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeAddressBox.Location = new System.Drawing.Point(368, 43);
            this.codeAddressBox.MaxLength = 8;
            this.codeAddressBox.Name = "codeAddressBox";
            this.codeAddressBox.Size = new System.Drawing.Size(146, 19);
            this.codeAddressBox.TabIndex = 13;
            // 
            // codeAddressLabel
            // 
            this.codeAddressLabel.AutoSize = true;
            this.codeAddressLabel.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeAddressLabel.ForeColor = System.Drawing.Color.White;
            this.codeAddressLabel.Location = new System.Drawing.Point(266, 47);
            this.codeAddressLabel.Name = "codeAddressLabel";
            this.codeAddressLabel.Size = new System.Drawing.Size(96, 12);
            this.codeAddressLabel.TabIndex = 12;
            this.codeAddressLabel.Text = "Code Address:";
            // 
            // submitCodeButton
            // 
            this.submitCodeButton.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitCodeButton.Location = new System.Drawing.Point(289, 69);
            this.submitCodeButton.Name = "submitCodeButton";
            this.submitCodeButton.Size = new System.Drawing.Size(225, 23);
            this.submitCodeButton.TabIndex = 14;
            this.submitCodeButton.Text = "Submit Code To: F(0)";
            this.submitCodeButton.UseVisualStyleBackColor = true;
            this.submitCodeButton.Click += new System.EventHandler(this.SubmitCode);
            // 
            // copyViewButton
            // 
            this.copyViewButton.Font = new System.Drawing.Font("OCR A Extended", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyViewButton.Location = new System.Drawing.Point(12, 453);
            this.copyViewButton.Name = "copyViewButton";
            this.copyViewButton.Size = new System.Drawing.Size(502, 23);
            this.copyViewButton.TabIndex = 15;
            this.copyViewButton.Text = "Copy and View";
            this.copyViewButton.UseVisualStyleBackColor = true;
            this.copyViewButton.Click += new System.EventHandler(this.CopyAndView);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpMeToolStripMenuItem,
            this.languagesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(697, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpMeToolStripMenuItem
            // 
            this.helpMeToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.helpMeToolStripMenuItem.Name = "helpMeToolStripMenuItem";
            this.helpMeToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.helpMeToolStripMenuItem.Text = "Help Me";
            // 
            // languagesToolStripMenuItem
            // 
            this.languagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languagesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.languagesToolStripMenuItem.Name = "languagesToolStripMenuItem";
            this.languagesToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.languagesToolStripMenuItem.Text = "Languages";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.SwitchToEnglish);
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            this.polishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.polishToolStripMenuItem.Text = "Polski";
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.SwitchToPolish);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfFunctionsLabel,
            this.toolStripStatusLabel5,
            this.codesInFunctionLabel,
            this.toolStripStatusLabel9,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel6,
            this.codeDistanceLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 551);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(697, 22);
            this.statusStrip1.TabIndex = 17;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // numberOfFunctionsLabel
            // 
            this.numberOfFunctionsLabel.ForeColor = System.Drawing.Color.White;
            this.numberOfFunctionsLabel.Name = "numberOfFunctionsLabel";
            this.numberOfFunctionsLabel.Size = new System.Drawing.Size(208, 17);
            this.numberOfFunctionsLabel.Text = "Number Of Functions To Be Copied: 0";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel5.Text = "    ";
            // 
            // codesInFunctionLabel
            // 
            this.codesInFunctionLabel.ForeColor = System.Drawing.Color.White;
            this.codesInFunctionLabel.Name = "codesInFunctionLabel";
            this.codesInFunctionLabel.Size = new System.Drawing.Size(162, 17);
            this.codesInFunctionLabel.Text = "Codes In Selected Function: 0";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel9.Text = "    ";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel8.Text = "    ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel7.Text = "    ";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel6.Text = "    ";
            // 
            // codeDistanceLabel
            // 
            this.codeDistanceLabel.ForeColor = System.Drawing.Color.White;
            this.codeDistanceLabel.Name = "codeDistanceLabel";
            this.codeDistanceLabel.Size = new System.Drawing.Size(126, 17);
            this.codeDistanceLabel.Text = "Code Distance: 0 Bytes";
            // 
            // languageModifier
            // 
            this.languageModifier.Interval = 1000;
            this.languageModifier.Tick += new System.EventHandler(this.UpdateLanguages);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(697, 573);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.copyViewButton);
            this.Controls.Add(this.submitCodeButton);
            this.Controls.Add(this.codeAddressBox);
            this.Controls.Add(this.codeAddressLabel);
            this.Controls.Add(this.jrRa8Box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.functionTopBox);
            this.Controls.Add(this.functionTopLabel2);
            this.Controls.Add(this.functionNameBox);
            this.Controls.Add(this.functionNameLabel);
            this.Controls.Add(this.submitFunctionButton);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.functionInfoContainer);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(713, 611);
            this.MinimumSize = new System.Drawing.Size(713, 611);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FunctionSafer.Legacy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ShowThanks);
            this.Load += new System.EventHandler(this.ApplicationStart);
            this.functionInfoContainer.ResumeLayout(false);
            this.functionInfoContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.RichTextBox resultBox;
        private System.Windows.Forms.GroupBox functionInfoContainer;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label sizeLabel;
        private System.Windows.Forms.Label jrRa8Label;
        private System.Windows.Forms.Label functionTopLabel;
        private System.Windows.Forms.Button submitFunctionButton;
        private System.Windows.Forms.Label functionNameLabel;
        private System.Windows.Forms.TextBox functionNameBox;
        private System.Windows.Forms.TextBox functionTopBox;
        private System.Windows.Forms.Label functionTopLabel2;
        private System.Windows.Forms.TextBox jrRa8Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox codeAddressBox;
        private System.Windows.Forms.Label codeAddressLabel;
        private System.Windows.Forms.Button submitCodeButton;
        private System.Windows.Forms.Label codesLabel;
        private System.Windows.Forms.ListBox codeList;
        private System.Windows.Forms.ListBox functionList;
        private System.Windows.Forms.Button copyViewButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpMeToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel numberOfFunctionsLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel codesInFunctionLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel codeDistanceLabel;
        private System.Windows.Forms.ToolStripMenuItem languagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.Timer languageModifier;
    }
}

