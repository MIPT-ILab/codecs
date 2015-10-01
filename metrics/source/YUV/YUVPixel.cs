using System.Collections.Generic;

namespace YUV
{
    internal class YUVPixel
    {
        public readonly byte Y;
        public readonly byte R;
        public readonly byte G;
        public readonly byte B;

        public YUVPixel(byte mY, byte mU, byte mV)
        {
            Y = mY;

            var val = (298 * (mY - 16) + 409 * (mV - 128) + 128) >> 8;
            if (val < 0)
            {
                R = 0;
            }
            else
            {
                R = (val > 255) ? R = 255 : R = (byte)val;
            }

            val = ((298 * (mY - 16) - 100 * (mU - 128) - 208 * (mV - 128) + 128) >> 8);
            if (val < 0)
            {
                G = 0;
            }
            else
            {
                G = (val > 255) ? G = 255 : G = (byte)val;
            }

            
            val = ((298 * (mY - 16) + 516 * (mU - 128) + 128) >> 8);
            if (val < 0)
            {
                B = 0;
            }
            else
            {
                B = (val > 255) ? B = 255 : B = (byte)val;
            }
        }
        
        public YUVPixel(IList<byte> value)
        {
            R = value[0];
            G = value[1];
            B = value[2];
        }

        public System.Drawing.Color RGB
        {
            get
            {
                return System.Drawing.Color.FromArgb(R, G, B); 
            }
        }

        public System.Drawing.Color BW
        {
            get
            {
                return System.Drawing.Color.FromArgb(Y, Y, Y);
            }
        }
    }
}
