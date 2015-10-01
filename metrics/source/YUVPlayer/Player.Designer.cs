namespace YUVPlayer
{
    partial class Player
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.width = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.fps = new System.Windows.Forms.Timer(this.components);
            this.playButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.frameNum = new System.Windows.Forms.Label();
            this.playerBox = new System.Windows.Forms.GroupBox();
            this.traceButtton = new System.Windows.Forms.Button();
            this.modeBox = new System.Windows.Forms.GroupBox();
            this.chooseAll = new System.Windows.Forms.RadioButton();
            this.chooseFull = new System.Windows.Forms.RadioButton();
            this.frameTrack = new System.Windows.Forms.TrackBar();
            this.frameBox = new System.Windows.Forms.GroupBox();
            this.openButton = new System.Windows.Forms.Button();
            this.openBox = new System.Windows.Forms.GroupBox();
            this.AboutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.playerBox.SuspendLayout();
            this.modeBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameTrack)).BeginInit();
            this.frameBox.SuspendLayout();
            this.openBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(720, 741);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // width
            // 
            this.width.Location = new System.Drawing.Point(9, 45);
            this.width.Name = "width";
            this.width.Size = new System.Drawing.Size(57, 20);
            this.width.TabIndex = 1;
            this.width.Text = "720";
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(9, 71);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(57, 20);
            this.height.TabIndex = 2;
            this.height.Text = "480";
            // 
            // fps
            // 
            this.fps.Interval = 40;
            this.fps.Tick += new System.EventHandler(this.FpsTick);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(48, 22);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(65, 26);
            this.playButton.TabIndex = 4;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.Play);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(6, 19);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(214, 20);
            this.name.TabIndex = 5;
            this.name.Text = "..\\YUVExamples\\simpson.yuv";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(49, 54);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(64, 26);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.Stop);
            // 
            // frameNum
            // 
            this.frameNum.AutoSize = true;
            this.frameNum.Location = new System.Drawing.Point(6, 16);
            this.frameNum.Name = "frameNum";
            this.frameNum.Size = new System.Drawing.Size(13, 13);
            this.frameNum.TabIndex = 7;
            this.frameNum.Text = "0";
            // 
            // playerBox
            // 
            this.playerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerBox.Controls.Add(this.traceButtton);
            this.playerBox.Controls.Add(this.playButton);
            this.playerBox.Controls.Add(this.stopButton);
            this.playerBox.Enabled = false;
            this.playerBox.Location = new System.Drawing.Point(782, 124);
            this.playerBox.Name = "playerBox";
            this.playerBox.Size = new System.Drawing.Size(146, 122);
            this.playerBox.TabIndex = 8;
            this.playerBox.TabStop = false;
            this.playerBox.Text = "Player";
            // 
            // traceButtton
            // 
            this.traceButtton.Location = new System.Drawing.Point(48, 86);
            this.traceButtton.Name = "traceButtton";
            this.traceButtton.Size = new System.Drawing.Size(64, 26);
            this.traceButtton.TabIndex = 7;
            this.traceButtton.Text = "Trace";
            this.traceButtton.UseVisualStyleBackColor = true;
            this.traceButtton.Click += new System.EventHandler(this.TraceButttonClick);
            // 
            // modeBox
            // 
            this.modeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.modeBox.Controls.Add(this.chooseAll);
            this.modeBox.Controls.Add(this.chooseFull);
            this.modeBox.Enabled = false;
            this.modeBox.Location = new System.Drawing.Point(934, 124);
            this.modeBox.Name = "modeBox";
            this.modeBox.Size = new System.Drawing.Size(74, 122);
            this.modeBox.TabIndex = 9;
            this.modeBox.TabStop = false;
            this.modeBox.Text = "Mode";
            // 
            // chooseAll
            // 
            this.chooseAll.AutoSize = true;
            this.chooseAll.Checked = true;
            this.chooseAll.Location = new System.Drawing.Point(12, 91);
            this.chooseAll.Name = "chooseAll";
            this.chooseAll.Size = new System.Drawing.Size(49, 17);
            this.chooseAll.TabIndex = 3;
            this.chooseAll.TabStop = true;
            this.chooseAll.Text = "Color";
            this.chooseAll.UseVisualStyleBackColor = true;
            // 
            // chooseFull
            // 
            this.chooseFull.AutoSize = true;
            this.chooseFull.Location = new System.Drawing.Point(12, 68);
            this.chooseFull.Name = "chooseFull";
            this.chooseFull.Size = new System.Drawing.Size(54, 17);
            this.chooseFull.TabIndex = 2;
            this.chooseFull.Text = "Frame";
            this.chooseFull.UseVisualStyleBackColor = true;
            // 
            // frameTrack
            // 
            this.frameTrack.Location = new System.Drawing.Point(0, 32);
            this.frameTrack.Maximum = 100;
            this.frameTrack.Name = "frameTrack";
            this.frameTrack.Size = new System.Drawing.Size(220, 45);
            this.frameTrack.TabIndex = 7;
            this.frameTrack.Scroll += new System.EventHandler(this.FrameTrackScroll);
            // 
            // frameBox
            // 
            this.frameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.frameBox.Controls.Add(this.frameTrack);
            this.frameBox.Controls.Add(this.frameNum);
            this.frameBox.Enabled = false;
            this.frameBox.Location = new System.Drawing.Point(782, 252);
            this.frameBox.Name = "frameBox";
            this.frameBox.Size = new System.Drawing.Size(226, 79);
            this.frameBox.TabIndex = 10;
            this.frameBox.TabStop = false;
            this.frameBox.Text = "Frames";
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(152, 60);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(52, 31);
            this.openButton.TabIndex = 11;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.Button1Click);
            // 
            // openBox
            // 
            this.openBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openBox.Controls.Add(this.openButton);
            this.openBox.Controls.Add(this.name);
            this.openBox.Controls.Add(this.height);
            this.openBox.Controls.Add(this.width);
            this.openBox.Location = new System.Drawing.Point(782, 12);
            this.openBox.Name = "openBox";
            this.openBox.Size = new System.Drawing.Size(226, 106);
            this.openBox.TabIndex = 12;
            this.openBox.TabStop = false;
            this.openBox.Text = "Open";
            // 
            // AboutButton
            // 
            this.AboutButton.Location = new System.Drawing.Point(944, 347);
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(64, 26);
            this.AboutButton.TabIndex = 8;
            this.AboutButton.Text = "About...";
            this.AboutButton.UseVisualStyleBackColor = true;
            this.AboutButton.Click += new System.EventHandler(AboutButtonClick);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 741);
            this.Controls.Add(this.AboutButton);
            this.Controls.Add(this.openBox);
            this.Controls.Add(this.frameBox);
            this.Controls.Add(this.modeBox);
            this.Controls.Add(this.playerBox);
            this.Controls.Add(this.pictureBox);
            this.Name = "Player";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.playerBox.ResumeLayout(false);
            this.modeBox.ResumeLayout(false);
            this.modeBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.frameTrack)).EndInit();
            this.frameBox.ResumeLayout(false);
            this.frameBox.PerformLayout();
            this.openBox.ResumeLayout(false);
            this.openBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.TextBox width;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Timer fps;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label frameNum;
        private System.Windows.Forms.GroupBox playerBox;
        private System.Windows.Forms.GroupBox modeBox;
        private System.Windows.Forms.RadioButton chooseFull;
        private System.Windows.Forms.RadioButton chooseAll;
        private System.Windows.Forms.TrackBar frameTrack;
        private System.Windows.Forms.GroupBox frameBox;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.GroupBox openBox;
        private System.Windows.Forms.Button traceButtton;
        private System.Windows.Forms.Button AboutButton;
    }
}

