using System;
using YUV.YUV420;

namespace YUVCompare
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args.Length != 5)
            {
                Console.WriteLine(@"Syntax error");
                return -1;
            }
            var width = Int32.Parse(args[2]);
            var height = Int32.Parse(args[3]);
            YUV420Compare comparer;
            try
            {
                comparer = new YUV420Compare(args[0], args[1], width, height);
            }
                catch (Exception)
                {
                    Console.WriteLine(@"Invalid filename.");
                    return -1;
                }
            comparer.MetricName = args[4];
            var frames = comparer.Frames;
            for (var i = 0; i < frames; i++)
            {
                Console.WriteLine("{0} frame {2} is {1}", i, comparer.Metric(i), args[4]);
            }
            return 0;
        }
    }
}
