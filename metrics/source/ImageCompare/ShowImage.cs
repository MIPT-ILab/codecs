using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ImageCompare
{
    public sealed partial class ShowImage : Form
    {
        public ShowImage(Image what, string title)
        {
            InitializeComponent();
            picture.Image = what;
            Text = string.Format("{0} (right click to save image)", title);
        }

        private void PictureClick(object sender, EventArgs e)
        {
            var saveFileDialog1 = new SaveFileDialog
                                      {
                                          Filter = @"*.bmp (bitmap)|*.bmp",
                                          FilterIndex = 1,
                                          RestoreDirectory = true
                                      };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;
            var myStream = saveFileDialog1.OpenFile();
            picture.Image.Save(myStream, ImageFormat.Bmp);
            myStream.Close();
        }
    }
}
