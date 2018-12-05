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
            var splitInput=Console.ReadLine().Split(',');
            var img=new Bitmap("p.png");
            var rgb=img.GetPixel(Convert.ToInt32(splitInput[0]),Convert.ToInt32(splitInput[1]));
            Console.WriteLine((.1f/255)*rgb.R+" , "+(.1f/255)*rgb.G+" , "+(.1f/255)*rgb.B);
        }
    }
}
