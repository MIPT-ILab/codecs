using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace YUV.YUV420
{
    public class YUV420File : YUVFile
    {
        public YUV420File(string path, int width, int height) :
            base(path, width, height)
        {
            FrameLength = Square * 3 / 2;
            Frames = File.Length / FrameLength;
        }

        public override Bitmap Frame(int frameNum)
        {
            var input = new byte[FrameLength];
            File.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            File.Read(input, 0, FrameLength);

            var output = new byte[Square * 3];

            for (var i = 0; i < Height; i++)
            {
                var offsetY = i * Width;
                var offsetU = Square + (i / 2) * (Width / 2);
                var offsetV = Square * 5 / 4 + (i / 2) * (Width / 2);
                var halfoffset = 3 * i * Width;
                for (var j = 0; j < Width; j++)
                {
                    var pixel = new YUVPixel(
                        input[offsetY + j],
                        input[offsetU + j / 2],
                        input[offsetV + j / 2]
                        );
                    var offset = halfoffset + 3 * j;
                    output[offset + 0] = pixel.B;
                    output[offset + 1] = pixel.G;
                    output[offset + 2] = pixel.R;
                }
            }

            var bmp = new Bitmap(Width, Height, PixelFormat.Format24bppRgb);
            var bmpData = bmp.LockBits(
                     new Rectangle(0, 0, bmp.Width, bmp.Height),
                     ImageLockMode.WriteOnly, bmp.PixelFormat);
            Marshal.Copy(output, 0, bmpData.Scan0, output.Length);
            bmp.UnlockBits(bmpData);
            return bmp;
        }
    }
}