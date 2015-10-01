using System;
using System.Drawing;

namespace ImageCompareConsole
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 3)
            {
                Console.WriteLine(@"Syntax error");
                return -1;
            }

            var programCore = new DoubleBitmap.DoubleBitmap();
            Image original, modified;
            try
            {
                original = new Bitmap(args[0]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine(@"Original file wasn't found");
                return -1;
            }

            try
            {
                modified = new Bitmap(args[1]);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine(@"Modified file wasn't found");
                return -1;
            }

            try
            {
                programCore.LoadImages(original, modified);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return -2;
            }
            programCore.MetricName = args[2];
            programCore.SetCorners();
            Console.WriteLine(programCore.Metric().ToString());
            return 0;
        }
    }
}
