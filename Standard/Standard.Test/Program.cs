using System;
using System.Drawing;
using System.Drawing.Imaging;
using BarcodeLib;

namespace Standard.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Barcode b = new Barcode();
            Image img = b.Encode(TYPE.UPCA, "038000356216", Color.Black, Color.White, 290, 120);
            img.Save("example.png", ImageFormat.Png);
        }
    }
}
