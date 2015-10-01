# codecs
Solutions for MIPT-ILab Codecs project (2009/2011)

These projects were made by Pavel Kryukov as solutions for assignments of MIPT-ILab Codecs project led by Maxim Pokrovsky and Maxim Khlobystov

**Metrics**

Metrics is a set of MS Visual Studio C# projects:

**_ImageCompare_**

ImageCompare is a GUI tool that allows to compare two different images using common metrics like MSR or PSNR. It is useful to check quality loss which occurs on image processing e.g. by JPEG codec.

**_ImageCompareConsole_**

ImageCompareConsole is a CUI analog of ImageCompare used for debugging. It has following syntax:
`./ImageCompareConsole.exe <filename1> <filename2> <metric name>`

**_YUVPlayer_**
YUVPlayer is a simpliest player of YUV420 video files. Unfortunately, the probe sequences are lost.

**_YUVCompare_**
YUVCompare is a per-frame comparator of two YUV420 video files. The syntax is following:
`./YUVCompare.exe <filename1> <filename2> <width> <height> <metric name>`

**Filters**

Filters is a set of [AviSynth](http://avisynth.nl/index.php/Main_Page) filters. It can be loaded to AviSynth by the following directive:
`LoadPlugin("full/path/to/as_kryukov.dll")`

Then you are free to use 4 functions:

**_PepperNoise_**

Adds random pepper noise (black dots) to the video
`PepperNoiser(<source>)`

**_SaltNoise_**

Adds random salt noise (white dots) to the video
`SaltNoiser(<source>)`

**_DeNoiser_**

Attempts to remove noise from the pixel using median over 8 neighbourhood pixels, pixel from the previous from and pixel from the next frame.
`DeNoiser(<source>)`

**_DeInterlacer_**

Performes stream deinterlacing by averaging three neighbourhood rows.
`DeInterlacer(<source>)`
