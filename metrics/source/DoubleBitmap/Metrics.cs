using System.Collections.Generic;

namespace DoubleBitmap
{
    sealed public partial class DoubleBitmap
    {
        // Делегат для выбора рабочей метрики
        public delegate double MetricDel();
        public MetricDel Metric;
        public int MetricNum
        {
            set
            {
                switch (value)
                {
                    case 0: Metric = new MetricDel(MSE); break;
                    case 1: Metric = new MetricDel(PSNR); break;
                    case 2: Metric = new MetricDel(SSIM); break;
                    case 3: Metric = new MetricDel(DSSIM); break;
                    default: Metric = new MetricDel(PSNR); break;
                }
            }
        }

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

        // Вычисление мат.ожидания по изображению
        private double Average(IList<byte> image)
        {
            long sum = 0;

            // Сдвиг на КОНЕЦ по оси Х рабочего окна.
            var fulloffset = Color * (_height * _width + _leftCornerX);
            for (var y = _leftCornerY; y < _rightCornerY; y++)
            {
                // Сдвиг по оси y на необходимую строку.
                var offset = fulloffset - Color * (y + 1) * _width;

                // Окончание строки изображения.
                var finish = offset + _xSize * Color;

                // Побайтовая итерация строки.
                for (var b = offset; b < finish; b++)
                {
                    sum += image[b];
                }
            }
            return (double)sum / _square;
        }

        // Вычисление дисперсии по изображению
        private double Variance(IList<byte> image, double av)
        {
            double sum = 0;
            var fulloffset = Color * (_height * _width + _leftCornerX); 
            for (var y = _leftCornerY; y < _rightCornerY; y++)
            {
                var offset = fulloffset - Color * (y + 1) * _width;
                var finish = offset + _xSize * Color; 
                for (var b = offset; b < finish; b++)
                {                    
                    // Optimized
                    var distance = image[b] - av;
                    sum += distance * distance;
                }
            }
            return sum / (_square);
        }

        // Вычисление ковариации по изображению
        private double Covariance(double originalAv, double modifiedAv)
        {
            double sum = 0;
            var fulloffset = Color * (_height * _width + _leftCornerX); 
            for (var y = _leftCornerY; y < _rightCornerY; y++)
            {
                var offset = fulloffset - Color * (y + 1) * _width;
                var finish = offset + _xSize * Color; 
                for (var b = offset; b < finish; b++)
                {   
                    sum += (_original[b] - originalAv) * (_modified[b] - modifiedAv);
                }
            }
            return sum / (_square);
        }

        // MSE
        private double MSE()
        {
            double sum = 0;
            var fulloffset = Color * (_height * _width +  _leftCornerX);
            for (var y = _leftCornerY; y < _rightCornerY; y++)
            {
                var offset = fulloffset - Color * (y + 1) * _width;
                var finish = offset + _xSize * Color; 
                for (var b = offset; b < finish; b++)
                {   
                    // Optimized!
                    var distance = _original[b] - _modified[b];
                    sum += distance * distance;
                }
            }
            return sum / (_square);
        }

        // Peaksignal to noise ratio
        private double PSNR()
        {
            double thing = Byte * Byte;
            thing = thing / MSE();
            thing = System.Math.Log(thing);
            return thing * 10;
        }

        // SSIM
        private double SSIM()
        {
            var oAv = Average(_original);
            var mAv = Average(_modified);
            var oVr = Variance(_original, oAv);
            var mVr = Variance(_modified, mAv);
            var cov = Covariance(oAv, mAv);
            const double c1 = (0.01 * Byte) * (0.01 * Byte);
            const double c2 = (0.03 * Byte) * (0.03 * Byte);
            var result = (2 * oAv * mAv + c1) * (2 * cov + c2);
            result = result / ((oAv * oAv + mAv * mAv + c1) * (oVr + mVr + c2));
            return result;
        }

        // DSSIM
        private double DSSIM()
        {
            return 1 / (1 - SSIM());
        }
    }
}
