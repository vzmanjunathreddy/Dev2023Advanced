using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DemoStatic
{
    internal class Program
    {
        public delegate int delegateOrdersCount();
        static void Main(string[] args)
        {


            delegateOrdersCount dobj = new delegateOrdersCount(Orders.GetMaxOrders);

            var result = dobj.Invoke();

           
            Console.WriteLine(result);
            string article = "asdfasdf sadf@ asdfasdf;asdf!asdfasdf a#";

       
            Console.WriteLine($"Count of Words {article.ADVStringExtesion()}" );
            Console.Read();
        }
    }
}
