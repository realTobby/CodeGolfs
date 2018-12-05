// https://codegolf.stackexchange.com/questions/177020/color-of-a-pixel
// 5.12.2018 TKa

using System;
using System.Drawing;

namespace CG_ColorOfPixel
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]splitInput=Console.ReadLine().Split(',');
            Bitmap img=new Bitmap("p.png");
            Color rgb=img.GetPixel(Convert.ToInt32(splitInput[0]),Convert.ToInt32(splitInput[1]));
            Console.WriteLine(Math.Round((.1f/255)*rgb.R,3)+" , "+Math.Round((.1f/255)*rgb.G, 3)+" , "+Math.Round((.1f/255)*rgb.B, 3));
        }
    }
}
