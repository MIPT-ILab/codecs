namespace YUV.YUV420
{
    public class YUV420Compare : YUVCompare
    {
       public YUV420Compare(string path1, string path2, int width, int height) :
           base(path1, path2, width, height) 
        {
            FrameLength = Square * 3 / 2;
            Frames = ((Original.Length < Modified.Length) ? Original.Length : Modified.Length) / FrameLength;
        }
    }
}
