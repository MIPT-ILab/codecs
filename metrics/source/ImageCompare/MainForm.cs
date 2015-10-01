using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ImageCompare
{
    public partial class MainForm : Form
    {
        private Stream _original;
        private Stream _modified;

        private readonly DoubleBitmap.DoubleBitmap _programCore = new DoubleBitmap.DoubleBitmap();

        static private readonly OpenFileDialog OpenFileDialog = new OpenFileDialog
                                                               {
                                                                   InitialDirectory = @"c:\",
                                                                   Filter =
                                                                       @"Image files (*.bmp; *.jpg; *.gif; *.png; *.tiff)|*.bmp; *.jpg; *.gif; *.png; *.tiff|All files (*.*)|*.*",
                                                                   FilterIndex = 1,
                                                                   RestoreDirectory = true,

                                                               };

        public MainForm()
        {
            InitializeComponent();
            metricHelp.Text = @"Infinity is the best result.
80 dB is typical for JPEG";
        }

        private int MetricChoose
        {
            get
            {
                if (metricChooseMSE.Checked)
                    return 0;
                if (metricChoosePSNR.Checked)
                    return 1;
                if (metricChooseSSIM.Checked)
                    return 2;
                return metricChooseDSSIM.Checked ? 3 : 0;
            }               
        }

        private int SubstrChoose
        {
            get
            {
                if (substrChooseRGB.Checked)
                    return 0;
                if (substrChooseIRGB.Checked)
                    return 1;
                return substrChooseAv.Checked ? 2 : 0;
            }
        }

        private void SetCorners()
        {
            if (!sizeCheck.Checked)
            {
                _programCore.SetCorners();
            }
            else
            {
                _programCore.SetCorners(
                    int.Parse(sizeLX.Text),
                    int.Parse(sizeLY.Text),
                    int.Parse(sizeRX.Text),
                    int.Parse(sizeRY.Text)
                    );
            }
        }

        public void ImportCorners(int x1, int y1, int x2, int y2)
        {
            sizeCheck.Checked = true;
            sizeLX.Text = x1.ToString();
            sizeLY.Text = y1.ToString();
            sizeRX.Text = x2.ToString();
            sizeRY.Text = y2.ToString();            
        }

        private void Open()
        {

            sizeErrorLabel.Text = "";
            try
            {
                _programCore.LoadImages(leftImage.Image, rightImage.Image);
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, @"Error");
                throw new Exception();
            }

            try
            {
                SetCorners();
            }
            catch (Exception exp)
            {
                sizeErrorLabel.Text = exp.Message;
                throw new Exception();
            }
        }

        // Кнопки, кнопки, кнопки
        private void MetricButtonClick(object sender, EventArgs e)
        {
            metricText.Clear();

            try
            {
                Open();
            }
            catch (Exception)
            {
                return;
            }
 
            _programCore.MetricNum = MetricChoose;
            metricText.Text = _programCore.Metric().ToString();
        }

        private void SubstractClick(object sender, EventArgs e)
        {
            sizeErrorLabel.Text = "";
            try
            {
                Open();
            }
            catch (Exception)
            {
                return;
            } 
            
            _programCore.SubstrNum = SubstrChoose;
            var imageWindow = new ShowImage(_programCore.Substract(), "Substracted image");
            imageWindow.Show();
        }

        private void SelectAreaChecked(object sender, EventArgs e)
        {
            sizeLX.Enabled = sizeCheck.Checked;
            sizeLY.Enabled = sizeCheck.Checked;
            sizeRX.Enabled = sizeCheck.Checked;
            sizeRY.Enabled = sizeCheck.Checked;
            sizeLL.Enabled = sizeCheck.Checked;
            sizeRL.Enabled = sizeCheck.Checked;
            sizeErrorLabel.Enabled = sizeCheck.Checked;
        }

        private void LeftOpenButtonClick(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;
            _original = OpenFileDialog.OpenFile();
            var bitmap = new Bitmap(_original);
            leftImage.Image = bitmap;
            leftSizeLabel.Text = string.Format(@"{0} x {1}", bitmap.Width, bitmap.Height);
        }

        private void RightOpenButtonClick(object sender, EventArgs e)
        {
            if (OpenFileDialog.ShowDialog() != DialogResult.OK) return;
            _modified = OpenFileDialog.OpenFile();
            var bitmap = new Bitmap(_modified);
            rightImage.Image = bitmap;
            rightSizeLabel.Text = string.Format(@"{0} x {1}", bitmap.Width, bitmap.Height);
        }

        private void LeftIncClick(object sender, EventArgs e)
        {
            if (_original == null) return;
            var imageWindow = new CutImage(_original, "Original image", this);
            imageWindow.Show();
        }

        private void RightIncClick(object sender, EventArgs e)
        {
            if (_modified == null) return;
            var imageWindow = new CutImage(_modified, "Modified image", this);
            imageWindow.Show();
        }


        private void MetricCheckedChanged(object sender, EventArgs e)
        {
            switch (MetricChoose)
            {
                case 0: metricHelp.Text = @"0 is the best result (no noise)"; break;
                case 1: metricHelp.Text = @"Infinity is the best result.
80 dB is typical for JPEG"; break;
                case 2: metricHelp.Text = @"1 means that images are equal.
-1 is the worst result"; break;
                case 3: metricHelp.Text = @"Infinity is the best result.
0.5 is the worst"; break;
            }
        }

        static private readonly MIPTAboutBox AboutBox = new MIPTAboutBox();

        private static void AboutButtonClick(object sender, EventArgs e)
        {
            AboutBox.Show();
        }

        // изменитель размеров
        private void Sized(object sender, EventArgs e)
        {
            leftBox.Width = Width - panelPanel.Width - 24;
            rightBox.Width = leftBox.Width;
            leftImage.Width = leftBox.Width - 100;
            rightImage.Width = rightBox.Width - 100;
            leftBox.Height = (Height - 44) / 2;
            rightBox.Height = leftBox.Height;
            rightBox.Top = leftBox.Height;
        }
    }
}
