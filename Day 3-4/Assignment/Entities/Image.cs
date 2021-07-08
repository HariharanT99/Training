using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Entities
{
    class Image
    {
        enum ImageType { Landscape, Portrait}
        public void Frame()
        {
            //User Input
            Console.WriteLine("Enter the Height of the image");
            var Height = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Height of the image");
            var Width = Convert.ToInt32(Console.ReadLine());

            //Result
            var Result = (Height < Width) ? Convert.ToString(ImageType.Landscape) : Convert.ToString(ImageType.Portrait);
            Console.WriteLine($"The is a {Result} Image");
        }

    }
}
