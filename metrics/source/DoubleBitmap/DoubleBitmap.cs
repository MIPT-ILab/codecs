using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace DoubleBitmap
{
    sealed public partial class DoubleBitmap
    {
        //
        private const int Color = 3;
        private const int Byte = 255;

        // Изображения
        private byte[] _original;
        private byte[] _modified;

        // Размеры
        private int _width;
        private int _height;
        private int _square;

        // Координаты
        private int _leftCornerX;
        private int _leftCornerY;
        private int _rightCornerX;
        private int _rightCornerY;

        // Некоторые полезные геометрические свойства
        private int _xSize;
        private int _ySize;

        // Установка области, в которой будет производиться операция
        public void SetCorners()
        {
            _leftCornerX = 0;
            _leftCornerY = 0;
            _rightCornerX = _width;
            _rightCornerY = _height;
            _xSize = _rightCornerX - _leftCornerX;
            _ySize = _rightCornerY - _leftCornerY;
            _square = _xSize * _ySize;
        }

        public void SetCorners(int x1, int y1, int x2, int y2)
        {
            if ((x1 < 0) || (x1 > _width))
            {
                throw new Exception(@"Left top corner X coordinate isn't correct");
            }
            _leftCornerX = x1;

            if ((x2 > _width) || (x2 < 0))
            {
                throw new Exception(@"Right bottom corner X coordinate isn't correct.");
            }
            if (x2 < x1)
            {
                throw new Exception("Right corner is more left than left.");
            }
            _rightCornerX = x2;

            if ((y1 < 0) || (y1 > _width))
            {
                throw new Exception(@"Left top corner X coordinate isn't correct");
            }
            _leftCornerY = y1;

            if ((y2 > _width) || (y2 < 0))
            {
                throw new Exception(@"Right bottom corner X coordinate isn't correct.");
            }
            if (y2 < y1)
            {
                throw new Exception("Right corner is more left than left.");
            }
            _rightCornerY = y2;

            _xSize = _rightCornerX - _leftCornerX;
            _ySize = _rightCornerY - _leftCornerY;
            _square = _xSize * _ySize;
        }

        // Загрузка изображений
        public void LoadImages(Image image1, Image image2)
        {
            if (image1 != null)
            {
                if (image2 != null)
                {
                    if ((image1.Height != image2.Height) || (image1.Width != image2.Width))
                    {
                        throw new Exception(@"Images have different size");
                    }

                    _width = image1.Width;
                    _height = image2.Height;

                    var origStream = new MemoryStream();
                    image1.Save(origStream, ImageFormat.Bmp);
                    _original = origStream.ToArray();

                    var modfStream = new MemoryStream();
                    image2.Save(modfStream, ImageFormat.Bmp);
                    _modified = modfStream.ToArray();

                    return;
                }
                throw new Exception(@"Modified image isn't loaded");
            }
            throw new Exception(@"Original image isn't loaded");
        }

        // Номер рабочего алгоритма вычитания
        public int SubstrNum;

        //Substraction
        public Bitmap Substract()
        {
            var result = new byte[_square * Color];
            var fulloffset = Color * (_height * _width + _leftCornerX - _leftCornerY * _width);
            for (var y = 0; y < _ySize; y++)
            {
                var offset = fulloffset - Color * (y + 1) * _width;
                var finish = offset + _xSize * Color;
                var x = 0;
                var halfoffsetRes = Color * y * _xSize;
                for (var b = offset; b < finish; b = b + Color)
                {
                    var offsetRes = halfoffsetRes + Color * x++;
                    for (var i = 0; i < Color; i++)
                    {
                        var buffer = _original[b + i] - _modified[b + i];
                        switch (SubstrNum)
                        {
                            case 0:
                                result[offsetRes + i] = (byte) (buffer > 0 ? buffer : -buffer);
                                break;
                            case 1:
                                result[offsetRes + i] = (byte)(Byte - (buffer > 0 ? buffer : -buffer));
                                break;
                            case 2:
                                result[offsetRes + i] = (byte)(Byte / 2 + buffer / 2);
                                break;
                            default:
                                goto case 0;
                        }
                    }
                }
            }
            var bmp = new Bitmap(_xSize, _ySize, PixelFormat.Format24bppRgb);
            var bmpData = bmp.LockBits(
                     new Rectangle(0, 0, bmp.Width, bmp.Height),
                     ImageLockMode.WriteOnly, bmp.PixelFormat);
            System.Runtime.InteropServices.Marshal.Copy(result, 0, bmpData.Scan0, result.Length);
            bmp.UnlockBits(bmpData);
            return bmp;
        }
    }
}