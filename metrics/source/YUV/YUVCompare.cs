using System;
using System.IO;

namespace YUV
{
    public abstract class YUVCompare
    {
        public delegate double MetricDel(int frameNum);
        public MetricDel Metric;
        public string MetricName
        {
            set
            {
                switch (value)
                {
                    case "MSE": Metric = new MetricDel(MSE); break;
                    case "PSNR": Metric = new MetricDel(PSNR); break;
                    case "SSIM": Metric = new MetricDel(SSIM); break;
                    case "DSSIM": Metric = new MetricDel(DSSIM); break;
                    default: Metric = new MetricDel(PSNR); break;
                }
            }
        }

        internal readonly FileStream Original;
        internal readonly FileStream Modified;

        internal readonly Int32 Square;

        internal Int32 FrameLength;

        public long Frames;

        protected YUVCompare(string path1, string path2, Int32 width, Int32 height)
        {
            Original = File.Open(path1,FileMode.Open);
            Modified = File.Open(path2, FileMode.Open);
            Square = width * height;
        }

        private double Average(Stream file, int frameNum)
        {
            var buffer = new byte[FrameLength];
            file.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            file.Read(buffer, 0, FrameLength);
            long sum = 0;
            for (var x = 0; x < FrameLength; x++)
            {
                sum = sum + buffer[x];
            }
            return (double)sum / Square;
        }

        private double Variance(Stream file, double av, int frameNum)
        {
            double sum = 0;
            var buffer = new byte[FrameLength];
            file.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            file.Read(buffer, 0, FrameLength);
            for (var x = 0; x < FrameLength; x++)
            {
                 var distance = buffer[x] - av;
                 sum += distance * distance;
            }
            return sum / Square;
        }

        private double Covariance(double originalAv, double modifiedAv, int frameNum)
        {
            double sum = 0;
            var buffer1 = new byte[FrameLength];
            Original.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            Original.Read(buffer1, 0, FrameLength);
            
            var buffer2 = new byte[FrameLength];
            Modified.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            Modified.Read(buffer2, 0, FrameLength);

            for (var x = 0; x < FrameLength; x++)
            {
                sum += (buffer1[x] - originalAv)*(buffer2[x] - modifiedAv);
            }

            return sum / Square;
        }

        private double MSE(int frameNum)
        {
            double sum = 0;
            var buffer1 = new byte[FrameLength];
            Original.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            Original.Read(buffer1, 0, FrameLength);
            
            var buffer2 = new byte[FrameLength];
            Modified.Seek(frameNum * FrameLength, SeekOrigin.Begin);
            Modified.Read(buffer2, 0, FrameLength);

            for (var x = 0; x < FrameLength; x++)
            {
                sum += (buffer1[x] - buffer2[x])*(buffer1[x] - buffer2[x]);
            }

            return sum / Square;
        }

        private double PSNR(int frameNum)
        {
            double thing = 255 * 255;
            thing = thing / MSE(frameNum);
            thing = Math.Log(thing);
            return thing * 10;
        }

        private double SSIM(int frameNum)
        {
            var oAv = Average(Original, frameNum);
            var mAv = Average(Modified, frameNum);
            var oVr = Variance(Original, oAv, frameNum);
            var mVr = Variance(Modified, mAv, frameNum);
            var cov = Covariance(oAv, mAv, frameNum);
            const double c1 = (0.01 * 255) * (0.01 * 255);
            const double c2 = (0.03 * 255) * (0.03 * 255);
            var result = (2 * oAv * mAv + c1) * (2 * cov + c2);
            result = result / ((oAv * oAv + mAv * mAv + c1) * (oVr + mVr + c2));
            return result;
        }

        private double DSSIM(int frameNum)
        {
            var oAv = Average(Original, frameNum);
            var mAv = Average(Modified, frameNum);
            var oVr = Variance(Original, oAv, frameNum);
            var mVr = Variance(Modified, mAv, frameNum);
            var cov = Covariance(oAv, mAv, frameNum);
            const double c1 = (0.01 * 255) * (0.01 * 255);
            const double c2 = (0.03 * 255) * (0.03 * 255);
            var result = (2 * oAv * mAv + c1) * (2 * cov + c2);
            result = result / ((oAv * oAv + mAv * mAv + c1) * (oVr + mVr + c2));
            result = 1 / (1 - result);
            return result;
        }

    }
}
