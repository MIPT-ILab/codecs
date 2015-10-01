using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageCompare
{
    public sealed partial class CutImage : Form
    {
        private readonly MainForm _owner;

        private bool _firstSelected;
        private bool _cornerNum = true;

        private int StatHeight
        {
            get { return statusStrip1.Height; }
        }

        private int _x1;
        private int _x2;
        private int _y1;
        private int _y2;

        public CutImage(Stream what, string title, MainForm who)
        {
            InitializeComponent();
            picture.Image = new Bitmap(what);
            Text = title + @" (left click to choose area)";
            _owner = who;
            Width = 600;
            Height = 600 * picture.Image.Height / picture.Image.Width + StatHeight;
        }

        private void OKbuttonClick(object sender, EventArgs e)
        {
            if (_firstSelected)
            {
                if (_cornerNum)
                {
                    _owner.ImportCorners(_x1, _y1, _x2, _y2);
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        private void PictureClick(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                if (_cornerNum)
                {
                    _x1 = e.X * picture.Image.Width / Width;
                    _y1 = e.Y * picture.Image.Height / Height;
                    _x2 = 0;
                    _y2 = 0;
                    label1.Text = string.Format("({0}; {1})", _x1, _y1);
                    label2.Text = @"undefined";
                    _firstSelected = true;
                    _cornerNum = false;
                }
                else
                {
                    if ((e.X * picture.Image.Width / Width > _x1) && (e.Y * picture.Image.Height / Height > _y1))
                    {
                        _x2 = e.X * picture.Image.Width / Width;
                        _y2 = e.Y * picture.Image.Height / Height;
                        label2.Text = string.Format("({0}; {1})", _x2, _y2);
                        _cornerNum = true;
                    }
                }
            }
            else
            {
                _x1 = 0;
                _y1 = 0;
                _x2 = 0;
                _y2 = 0;
                label1.Text = @"undefined";
                label2.Text = @"undefined";
                _firstSelected = false;
                _cornerNum = true;
            }
        }

        private void Sized(object sender, EventArgs e)
        {
            picture.Width = Width - 44;
            Height = Width * picture.Image.Height / picture.Image.Width + StatHeight;
            picture.Height = Height - 44 - StatHeight;
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
