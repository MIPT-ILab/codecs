using System;

namespace YUV
{
    public abstract class YUVFile
    {
        protected readonly System.IO.FileStream File;

        protected readonly Int32 Height;
        protected readonly Int32 Width;

        protected readonly Int32 Square;

        protected Int32 FrameLength;

        public long Frames;

        protected YUVFile(string path, Int32 width, Int32 height)
        {
            File = System.IO.File.OpenRead(path);
            Height = height;
            Width = width;
            Square = height * width;
        }

        public abstract System.Drawing.Bitmap Frame(int frameNum);
    }
}
