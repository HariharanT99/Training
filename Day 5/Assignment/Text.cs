using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Text
    {
        public static void Break()
        {
            //var Txt = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard";
            var Txt = "Lorem ipsum test art Lines, Test string splits        test2 training";
            var LCount = 0;
            var i = 0;

            //for removing "."
            Char[] SplitTxt = new Char[] { ' ', '.'};
            
            // For removing empty entries
            var FinalTxt = Txt.Split(SplitTxt, StringSplitOptions.RemoveEmptyEntries);
            var FinalString = new List<string>();

            while (LCount < 45)
            {
                LCount += FinalTxt[i].Length;
                FinalString.Add(FinalTxt[i]);
                i++;
            }
            
            foreach (var n in FinalString)
            {
                Console.WriteLine($"{n} ");
            }
        }
    }
}
