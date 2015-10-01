using System;
using System.Windows.Forms;
using YUV.YUV420;

namespace YUVPlayer
{
    public partial class Player : Form
    {
        YUV420File _original;

        private void FrameInc()
        {
            if (frameTrack.Value < frameTrack.Maximum)
            {
                frameTrack.Value++;
            }
        }

        private int Mode
        {
            get
            {
                if (chooseAll.Checked)
                {
                    return 0;
                }
                if (chooseFull.Checked)
                {
                    return 1;
                }
                return -1;
            }
        }

        private void ShowFrame(int num)
        {
            switch (Mode)
            {
                case 0: pictureBox.Image = _original.Frame(num); break;
                case 1:
                    goto case 0;
//                case 1: pictureBox.Image = _original.FrameFull(num); break;
            }
        }

        public Player()
        {
            InitializeComponent();
        }

        private void Open()
        {
            _original = new YUV420File(name.Text, int.Parse(width.Text), int.Parse(height.Text));
            frameTrack.Maximum = (int)_original.Frames;
        }

        private void Play(object sender, EventArgs e)
        {
            fps.Enabled = true;
        }

        private void Stop(object sender, EventArgs e)
        {
            fps.Enabled = false;
        }

        private void FpsTick(object sender, EventArgs e)
        {
            ShowFrame(frameTrack.Value);
            FrameInc();
            frameNum.Text = frameTrack.Value.ToString();
            if (frameTrack.Value == _original.Frames)
            {
                fps.Enabled = false;
            }
        }

        private void FrameTrackScroll(object sender, EventArgs e)
        {
            frameNum.Text = frameTrack.Value.ToString();
            ShowFrame(frameTrack.Value);
        }

        private void Button1Click(object sender, EventArgs e)
        {
            try
            {
                Open();
            }
                catch (Exception)
                {
                    MessageBox.Show(@"Invalid path", @"Error");
                    return;
                }
            playerBox.Enabled = true;
            frameBox.Enabled = true;
            modeBox.Enabled = true;
        }

        private void TraceButttonClick(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < frameTrack.Maximum; i++)
            {
                _original.Frame(i).Save(string.Format(@"C:\Documents\Simpson\Simpson{0}.bmp", i));
            }
        }

        static private readonly MIPTAboutBox AboutBox = new MIPTAboutBox();

        private static void AboutButtonClick(object sender, EventArgs e)
        {
            AboutBox.Show();
        }

    }
}
