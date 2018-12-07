// https://codegolf.stackexchange.com/questions/177020/color-of-a-pixel
// 5.12.2018 TKa
using System;
using System.Drawing;
namespace CG_ColorOfPixel
{
    class P
    {
        static void Main(string[] args)
        {
            var s=Console.ReadLine().Split(',');
            var i=new Bitmap("p.png");
            var c=i.GetPixel(Convert.ToInt32(s[0]),Convert.ToInt32(s[1]));
            Console.WriteLine((.1f/255)*c.R+" , "+(.1f/255)*c.G+" , "+(.1f/255)*c.B);
        }
    }
}