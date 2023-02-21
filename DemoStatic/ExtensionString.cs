using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStatic
{
    public static class ExtensionString
    {
        public static int ADVStringExtesion(this string str)
        {
            int countOfWords=0;

            if (str == null)
            {
                return countOfWords;
            }
            else
            {
                var stringSplit=str.Split(new char[] { ' ', ',', '@', '*', '!', '&' }).ToArray();
                return stringSplit.Count();
            }
            
        }
    }
}
