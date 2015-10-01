namespace ImageCompare
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
            this.leftBox = new System.Windows.Forms.GroupBox();
            this.leftArea = new System.Windows.Forms.Button();
            this.leftSizeLabel = new System.Windows.Forms.Label();
            this.leftOpenButton = new System.Windows.Forms.Button();
            this.leftImage = new System.Windows.Forms.PictureBox();
            this.rightBox = new System.Windows.Forms.GroupBox();
            this.rightArea = new System.Windows.Forms.Button();
            this.rightSizeLabel = new System.Windows.Forms.Label();
            this.rightOpenButton = new System.Windows.Forms.Button();
            this.rightImage = new System.Windows.Forms.PictureBox();
            this.metricBox = new System.Windows.Forms.GroupBox();
            this.metricHelp = new System.Windows.Forms.Label();
            this.metricChooseMSE = new System.Windows.Forms.RadioButton();
            this.metricChooseDSSIM = new System.Windows.Forms.RadioButton();
            this.metricChooseSSIM = new System.Windows.Forms.RadioButton();
            this.metricText = new System.Windows.Forms.TextBox();
            this.metricButton = new System.Windows.Forms.Button();
            this.metricChoosePSNR = new System.Windows.Forms.RadioButton();
            this.sizeBox = new System.Windows.Forms.GroupBox();
            this.sizeErrorLabel = new System.Windows.Forms.Label();
            this.sizeRY = new System.Windows.Forms.TextBox();
            this.sizeLY = new System.Windows.Forms.TextBox();
            this.sizeRL = new System.Windows.Forms.Label();
            this.sizeCheck = new System.Windows.Forms.CheckBox();
            this.sizeLL = new System.Windows.Forms.Label();
            this.sizeRX = new System.Windows.Forms.TextBox();
            this.sizeLX = new System.Windows.Forms.TextBox();
            this.substrButton = new System.Windows.Forms.Button();
            this.substrBox = new System.Windows.Forms.GroupBox();
            this.substrChooseAv = new System.Windows.Forms.RadioButton();
            this.substrChooseIRGB = new System.Windows.Forms.RadioButton();
            this.substrChooseRGB = new System.Windows.Forms.RadioButton();
            this.panelPanel = new System.Windows.Forms.Panel();
            this.helpBox = new System.Windows.Forms.GroupBox();
            this.helpAbout = new System.Windows.Forms.Button();
            this.leftBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftImage)).BeginInit();
            this.rightBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightImage)).BeginInit();
            this.metricBox.SuspendLayout();
            this.sizeBox.SuspendLayout();
            this.substrBox.SuspendLayout();
            this.panelPanel.SuspendLayout();
            this.helpBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftBox
            // 
            this.leftBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.leftBox.Controls.Add(this.leftArea);
            this.leftBox.Controls.Add(this.leftSizeLabel);
            this.leftBox.Controls.Add(this.leftOpenButton);
            this.leftBox.Controls.Add(this.leftImage);
            this.leftBox.Location = new System.Drawing.Point(0, 0);
            this.leftBox.Name = "leftBox";
            this.leftBox.Size = new System.Drawing.Size(579, 250);
            this.leftBox.TabIndex = 6;
            this.leftBox.TabStop = false;
            this.leftBox.Text = "Original Image";
            // 
            // leftArea
            // 
            this.leftArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leftArea.Location = new System.Drawing.Point(485, 215);
            this.leftArea.Name = "leftArea";
            this.leftArea.Size = new System.Drawing.Size(85, 29);
            this.leftArea.TabIndex = 12;
            this.leftArea.Text = "Area...";
            this.leftArea.UseVisualStyleBackColor = true;
            this.leftArea.Click += new System.EventHandler(this.LeftIncClick);
            // 
            // leftSizeLabel
            // 
            this.leftSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.leftSizeLabel.AutoSize = true;
            this.leftSizeLabel.Location = new System.Drawing.Point(482, 16);
            this.leftSizeLabel.MaximumSize = new System.Drawing.Size(170, 20);
            this.leftSizeLabel.MinimumSize = new System.Drawing.Size(70, 20);
            this.leftSizeLabel.Name = "leftSizeLabel";
            this.leftSizeLabel.Size = new System.Drawing.Size(70, 20);
            this.leftSizeLabel.TabIndex = 8;
            this.leftSizeLabel.Text = "nothing";
            // 
            // leftOpenButton
            // 
            this.leftOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leftOpenButton.Location = new System.Drawing.Point(485, 186);
            this.leftOpenButton.Name = "leftOpenButton";
            this.leftOpenButton.Size = new System.Drawing.Size(85, 29);
            this.leftOpenButton.TabIndex = 7;
            this.leftOpenButton.Text = "Open...";
            this.leftOpenButton.UseVisualStyleBackColor = true;
            this.leftOpenButton.Click += new System.EventHandler(this.LeftOpenButtonClick);
            // 
            // leftImage
            // 
            this.leftImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.leftImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.leftImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.leftImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftImage.Location = new System.Drawing.Point(3, 16);
            this.leftImage.Name = "leftImage";
            this.leftImage.Size = new System.Drawing.Size(479, 231);
            this.leftImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.leftImage.TabIndex = 5;
            this.leftImage.TabStop = false;
            // 
            // rightBox
            // 
            this.rightBox.Controls.Add(this.rightArea);
            this.rightBox.Controls.Add(this.rightSizeLabel);
            this.rightBox.Controls.Add(this.rightOpenButton);
            this.rightBox.Controls.Add(this.rightImage);
            this.rightBox.Location = new System.Drawing.Point(0, 250);
            this.rightBox.Name = "rightBox";
            this.rightBox.Size = new System.Drawing.Size(578, 250);
            this.rightBox.TabIndex = 8;
            this.rightBox.TabStop = false;
            this.rightBox.Text = "Compressed Image";
            // 
            // rightArea
            // 
            this.rightArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightArea.Location = new System.Drawing.Point(482, 215);
            this.rightArea.Name = "rightArea";
            this.rightArea.Size = new System.Drawing.Size(87, 29);
            this.rightArea.TabIndex = 13;
            this.rightArea.Text = "Area...";
            this.rightArea.UseVisualStyleBackColor = true;
            this.rightArea.Click += new System.EventHandler(this.RightIncClick);
            // 
            // rightSizeLabel
            // 
            this.rightSizeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rightSizeLabel.AutoSize = true;
            this.rightSizeLabel.Location = new System.Drawing.Point(485, 16);
            this.rightSizeLabel.MaximumSize = new System.Drawing.Size(170, 20);
            this.rightSizeLabel.MinimumSize = new System.Drawing.Size(70, 20);
            this.rightSizeLabel.Name = "rightSizeLabel";
            this.rightSizeLabel.Size = new System.Drawing.Size(70, 20);
            this.rightSizeLabel.TabIndex = 9;
            this.rightSizeLabel.Text = "nothing";
            // 
            // rightOpenButton
            // 
            this.rightOpenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightOpenButton.Location = new System.Drawing.Point(481, 186);
            this.rightOpenButton.Name = "rightOpenButton";
            this.rightOpenButton.Size = new System.Drawing.Size(88, 29);
            this.rightOpenButton.TabIndex = 7;
            this.rightOpenButton.Text = "Open...";
            this.rightOpenButton.UseVisualStyleBackColor = true;
            this.rightOpenButton.Click += new System.EventHandler(this.RightOpenButtonClick);
            // 
            // rightImage
            // 
            this.rightImage.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rightImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rightImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.rightImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.rightImage.Location = new System.Drawing.Point(3, 16);
            this.rightImage.Name = "rightImage";
            this.rightImage.Size = new System.Drawing.Size(479, 231);
            this.rightImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.rightImage.TabIndex = 5;
            this.rightImage.TabStop = false;
            // 
            // metricBox
            // 
            this.metricBox.AutoSize = true;
            this.metricBox.Controls.Add(this.metricHelp);
            this.metricBox.Controls.Add(this.metricChooseMSE);
            this.metricBox.Controls.Add(this.metricChooseDSSIM);
            this.metricBox.Controls.Add(this.metricChooseSSIM);
            this.metricBox.Controls.Add(this.metricText);
            this.metricBox.Controls.Add(this.metricButton);
            this.metricBox.Controls.Add(this.metricChoosePSNR);
            this.metricBox.Location = new System.Drawing.Point(0, 162);
            this.metricBox.Name = "metricBox";
            this.metricBox.Size = new System.Drawing.Size(249, 137);
            this.metricBox.TabIndex = 9;
            this.metricBox.TabStop = false;
            this.metricBox.Text = "Metrics";
            // 
            // metricHelp
            // 
            this.metricHelp.AutoSize = true;
            this.metricHelp.Location = new System.Drawing.Point(94, 49);
            this.metricHelp.Name = "metricHelp";
            this.metricHelp.Size = new System.Drawing.Size(35, 13);
            this.metricHelp.TabIndex = 13;
            this.metricHelp.Text = "label1";
            // 
            // metricChooseMSE
            // 
            this.metricChooseMSE.AutoSize = true;
            this.metricChooseMSE.Location = new System.Drawing.Point(18, 26);
            this.metricChooseMSE.Name = "metricChooseMSE";
            this.metricChooseMSE.Size = new System.Drawing.Size(48, 17);
            this.metricChooseMSE.TabIndex = 12;
            this.metricChooseMSE.TabStop = true;
            this.metricChooseMSE.Text = "MSE";
            this.metricChooseMSE.UseVisualStyleBackColor = true;
            this.metricChooseMSE.CheckedChanged += new System.EventHandler(this.MetricCheckedChanged);
            // 
            // metricChooseDSSIM
            // 
            this.metricChooseDSSIM.AutoSize = true;
            this.metricChooseDSSIM.Location = new System.Drawing.Point(18, 95);
            this.metricChooseDSSIM.Name = "metricChooseDSSIM";
            this.metricChooseDSSIM.Size = new System.Drawing.Size(59, 17);
            this.metricChooseDSSIM.TabIndex = 2;
            this.metricChooseDSSIM.Text = "DSSIM";
            this.metricChooseDSSIM.UseVisualStyleBackColor = true;
            this.metricChooseDSSIM.CheckedChanged += new System.EventHandler(this.MetricCheckedChanged);
            // 
            // metricChooseSSIM
            // 
            this.metricChooseSSIM.AutoSize = true;
            this.metricChooseSSIM.Location = new System.Drawing.Point(18, 72);
            this.metricChooseSSIM.Name = "metricChooseSSIM";
            this.metricChooseSSIM.Size = new System.Drawing.Size(51, 17);
            this.metricChooseSSIM.TabIndex = 1;
            this.metricChooseSSIM.Text = "SSIM";
            this.metricChooseSSIM.UseVisualStyleBackColor = true;
            this.metricChooseSSIM.CheckedChanged += new System.EventHandler(this.MetricCheckedChanged);
            // 
            // metricText
            // 
            this.metricText.BackColor = System.Drawing.SystemColors.Info;
            this.metricText.Location = new System.Drawing.Point(97, 23);
            this.metricText.Name = "metricText";
            this.metricText.ReadOnly = true;
            this.metricText.Size = new System.Drawing.Size(146, 20);
            this.metricText.TabIndex = 8;
            // 
            // metricButton
            // 
            this.metricButton.Location = new System.Drawing.Point(179, 88);
            this.metricButton.Name = "metricButton";
            this.metricButton.Size = new System.Drawing.Size(64, 30);
            this.metricButton.TabIndex = 11;
            this.metricButton.Text = "Calculate";
            this.metricButton.UseVisualStyleBackColor = true;
            this.metricButton.Click += new System.EventHandler(this.MetricButtonClick);
            // 
            // metricChoosePSNR
            // 
            this.metricChoosePSNR.AutoSize = true;
            this.metricChoosePSNR.Checked = true;
            this.metricChoosePSNR.Location = new System.Drawing.Point(18, 49);
            this.metricChoosePSNR.Name = "metricChoosePSNR";
            this.metricChoosePSNR.Size = new System.Drawing.Size(55, 17);
            this.metricChoosePSNR.TabIndex = 0;
            this.metricChoosePSNR.TabStop = true;
            this.metricChoosePSNR.Text = "PSNR";
            this.metricChoosePSNR.UseVisualStyleBackColor = true;
            this.metricChoosePSNR.CheckedChanged += new System.EventHandler(this.MetricCheckedChanged);
            // 
            // sizeBox
            // 
            this.sizeBox.AutoSize = true;
            this.sizeBox.Controls.Add(this.sizeErrorLabel);
            this.sizeBox.Controls.Add(this.sizeRY);
            this.sizeBox.Controls.Add(this.sizeLY);
            this.sizeBox.Controls.Add(this.sizeRL);
            this.sizeBox.Controls.Add(this.sizeCheck);
            this.sizeBox.Controls.Add(this.sizeLL);
            this.sizeBox.Controls.Add(this.sizeRX);
            this.sizeBox.Controls.Add(this.sizeLX);
            this.sizeBox.Location = new System.Drawing.Point(0, 4);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(249, 158);
            this.sizeBox.TabIndex = 10;
            this.sizeBox.TabStop = false;
            this.sizeBox.Text = "Select Area";
            // 
            // sizeErrorLabel
            // 
            this.sizeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.sizeErrorLabel.Location = new System.Drawing.Point(9, 97);
            this.sizeErrorLabel.Name = "sizeErrorLabel";
            this.sizeErrorLabel.Size = new System.Drawing.Size(234, 44);
            this.sizeErrorLabel.TabIndex = 14;
            // 
            // sizeRY
            // 
            this.sizeRY.Enabled = false;
            this.sizeRY.Location = new System.Drawing.Point(170, 74);
            this.sizeRY.Name = "sizeRY";
            this.sizeRY.Size = new System.Drawing.Size(52, 20);
            this.sizeRY.TabIndex = 12;
            this.sizeRY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeRY.WordWrap = false;
            // 
            // sizeLY
            // 
            this.sizeLY.Enabled = false;
            this.sizeLY.Location = new System.Drawing.Point(170, 44);
            this.sizeLY.Name = "sizeLY";
            this.sizeLY.Size = new System.Drawing.Size(52, 20);
            this.sizeLY.TabIndex = 11;
            this.sizeLY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeLY.WordWrap = false;
            // 
            // sizeRL
            // 
            this.sizeRL.AutoSize = true;
            this.sizeRL.Enabled = false;
            this.sizeRL.Location = new System.Drawing.Point(6, 77);
            this.sizeRL.Name = "sizeRL";
            this.sizeRL.Size = new System.Drawing.Size(100, 13);
            this.sizeRL.TabIndex = 10;
            this.sizeRL.Text = "Right bottom corner";
            // 
            // sizeCheck
            // 
            this.sizeCheck.AutoSize = true;
            this.sizeCheck.Location = new System.Drawing.Point(18, 20);
            this.sizeCheck.Name = "sizeCheck";
            this.sizeCheck.Size = new System.Drawing.Size(80, 17);
            this.sizeCheck.TabIndex = 0;
            this.sizeCheck.Text = "Select area";
            this.sizeCheck.UseVisualStyleBackColor = true;
            this.sizeCheck.CheckedChanged += new System.EventHandler(this.SelectAreaChecked);
            // 
            // sizeLL
            // 
            this.sizeLL.AutoSize = true;
            this.sizeLL.Enabled = false;
            this.sizeLL.Location = new System.Drawing.Point(6, 47);
            this.sizeLL.Name = "sizeLL";
            this.sizeLL.Size = new System.Drawing.Size(88, 13);
            this.sizeLL.TabIndex = 9;
            this.sizeLL.Text = "Left upper corner";
            // 
            // sizeRX
            // 
            this.sizeRX.Enabled = false;
            this.sizeRX.Location = new System.Drawing.Point(112, 74);
            this.sizeRX.Name = "sizeRX";
            this.sizeRX.Size = new System.Drawing.Size(52, 20);
            this.sizeRX.TabIndex = 8;
            this.sizeRX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeRX.WordWrap = false;
            // 
            // sizeLX
            // 
            this.sizeLX.Enabled = false;
            this.sizeLX.Location = new System.Drawing.Point(112, 44);
            this.sizeLX.Name = "sizeLX";
            this.sizeLX.Size = new System.Drawing.Size(52, 20);
            this.sizeLX.TabIndex = 7;
            this.sizeLX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sizeLX.WordWrap = false;
            // 
            // substrButton
            // 
            this.substrButton.Location = new System.Drawing.Point(179, 63);
            this.substrButton.Name = "substrButton";
            this.substrButton.Size = new System.Drawing.Size(64, 29);
            this.substrButton.TabIndex = 15;
            this.substrButton.Text = "Substract";
            this.substrButton.UseVisualStyleBackColor = true;
            this.substrButton.Click += new System.EventHandler(this.SubstractClick);
            // 
            // substrBox
            // 
            this.substrBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.substrBox.AutoSize = true;
            this.substrBox.Controls.Add(this.substrChooseAv);
            this.substrBox.Controls.Add(this.substrChooseIRGB);
            this.substrBox.Controls.Add(this.substrChooseRGB);
            this.substrBox.Controls.Add(this.substrButton);
            this.substrBox.Location = new System.Drawing.Point(0, 297);
            this.substrBox.Name = "substrBox";
            this.substrBox.Size = new System.Drawing.Size(255, 111);
            this.substrBox.TabIndex = 16;
            this.substrBox.TabStop = false;
            this.substrBox.Text = "Substraction";
            // 
            // substrChooseAv
            // 
            this.substrChooseAv.AutoSize = true;
            this.substrChooseAv.Checked = true;
            this.substrChooseAv.Location = new System.Drawing.Point(18, 65);
            this.substrChooseAv.Name = "substrChooseAv";
            this.substrChooseAv.Size = new System.Drawing.Size(97, 17);
            this.substrChooseAv.TabIndex = 18;
            this.substrChooseAv.TabStop = true;
            this.substrChooseAv.Text = "Averaged RGB";
            this.substrChooseAv.UseVisualStyleBackColor = true;
            // 
            // substrChooseIRGB
            // 
            this.substrChooseIRGB.AutoSize = true;
            this.substrChooseIRGB.Location = new System.Drawing.Point(18, 42);
            this.substrChooseIRGB.Name = "substrChooseIRGB";
            this.substrChooseIRGB.Size = new System.Drawing.Size(133, 17);
            this.substrChooseIRGB.TabIndex = 17;
            this.substrChooseIRGB.Text = "Inverted RGB absolute";
            this.substrChooseIRGB.UseVisualStyleBackColor = true;
            // 
            // substrChooseRGB
            // 
            this.substrChooseRGB.AutoSize = true;
            this.substrChooseRGB.Location = new System.Drawing.Point(18, 19);
            this.substrChooseRGB.Name = "substrChooseRGB";
            this.substrChooseRGB.Size = new System.Drawing.Size(91, 17);
            this.substrChooseRGB.TabIndex = 16;
            this.substrChooseRGB.Text = "RGB absolute";
            this.substrChooseRGB.UseVisualStyleBackColor = true;
            // 
            // panelPanel
            // 
            this.panelPanel.AutoScroll = true;
            this.panelPanel.Controls.Add(this.helpBox);
            this.panelPanel.Controls.Add(this.substrBox);
            this.panelPanel.Controls.Add(this.sizeBox);
            this.panelPanel.Controls.Add(this.metricBox);
            this.panelPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPanel.Location = new System.Drawing.Point(595, 0);
            this.panelPanel.Name = "panelPanel";
            this.panelPanel.Size = new System.Drawing.Size(255, 504);
            this.panelPanel.TabIndex = 17;
            // 
            // helpBox
            // 
            this.helpBox.Controls.Add(this.helpAbout);
            this.helpBox.Location = new System.Drawing.Point(0, 408);
            this.helpBox.Name = "helpBox";
            this.helpBox.Size = new System.Drawing.Size(248, 92);
            this.helpBox.TabIndex = 17;
            this.helpBox.TabStop = false;
            this.helpBox.Text = "About";
            // 
            // helpAbout
            // 
            this.helpAbout.Location = new System.Drawing.Point(179, 57);
            this.helpAbout.Name = "helpAbout";
            this.helpAbout.Size = new System.Drawing.Size(64, 28);
            this.helpAbout.TabIndex = 0;
            this.helpAbout.Text = "About...";
            this.helpAbout.UseVisualStyleBackColor = true;
            this.helpAbout.Click += new System.EventHandler(MainForm.AboutButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.panelPanel);
            this.Controls.Add(this.rightBox);
            this.Controls.Add(this.leftBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainForm";
            this.Text = "MIPT Image Quality Comparer";
            this.SizeChanged += new System.EventHandler(this.Sized);
            this.leftBox.ResumeLayout(false);
            this.leftBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leftImage)).EndInit();
            this.rightBox.ResumeLayout(false);
            this.rightBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rightImage)).EndInit();
            this.metricBox.ResumeLayout(false);
            this.metricBox.PerformLayout();
            this.sizeBox.ResumeLayout(false);
            this.sizeBox.PerformLayout();
            this.substrBox.ResumeLayout(false);
            this.substrBox.PerformLayout();
            this.panelPanel.ResumeLayout(false);
            this.panelPanel.PerformLayout();
            this.helpBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox leftBox;
        private System.Windows.Forms.PictureBox leftImage;
        private System.Windows.Forms.Button leftOpenButton;
        private System.Windows.Forms.GroupBox rightBox;
        private System.Windows.Forms.Button rightOpenButton;
        private System.Windows.Forms.PictureBox rightImage;
        private System.Windows.Forms.GroupBox metricBox;
        private System.Windows.Forms.RadioButton metricChooseSSIM;
        private System.Windows.Forms.RadioButton metricChoosePSNR;
        private System.Windows.Forms.GroupBox sizeBox;
        private System.Windows.Forms.CheckBox sizeCheck;
        private System.Windows.Forms.Label sizeRL;
        private System.Windows.Forms.Label sizeLL;
        private System.Windows.Forms.TextBox sizeRX;
        private System.Windows.Forms.TextBox sizeLX;
        private System.Windows.Forms.TextBox sizeRY;
        private System.Windows.Forms.TextBox sizeLY;
        private System.Windows.Forms.RadioButton metricChooseDSSIM;
        private System.Windows.Forms.Button metricButton;
        private System.Windows.Forms.TextBox metricText;
        private System.Windows.Forms.RadioButton metricChooseMSE;
        private System.Windows.Forms.Label leftSizeLabel;
        private System.Windows.Forms.Label rightSizeLabel;
        private System.Windows.Forms.Button substrButton;
        private System.Windows.Forms.GroupBox substrBox;
        private System.Windows.Forms.Panel panelPanel;
        private System.Windows.Forms.RadioButton substrChooseRGB;
        private System.Windows.Forms.RadioButton substrChooseIRGB;
        private System.Windows.Forms.RadioButton substrChooseAv;
        private System.Windows.Forms.Label sizeErrorLabel;
        private System.Windows.Forms.Button leftArea;
        private System.Windows.Forms.Button rightArea;
        private System.Windows.Forms.Label metricHelp;
        private System.Windows.Forms.GroupBox helpBox;
        private System.Windows.Forms.Button helpAbout;
    }
}