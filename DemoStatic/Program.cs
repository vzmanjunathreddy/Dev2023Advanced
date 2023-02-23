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

            AddItems<string> addItems = new AddItems<string>();
            var result1 = addItems.Addresult("Welcome to generics");

            AddItems<int> addItems1 = new AddItems<int>();
            var result2 = addItems1.Addresult(10);

            AddItems<double> addItems3 = new AddItems<double>();
            var result3 = addItems3.Addresult(1000.56);


            //delegateOrdersCount dobj = new delegateOrdersCount(Orders.GetMaxOrders);

            //var result = dobj.Invoke();


            //Console.WriteLine(result);
            //string article = "asdfasdf sadf@ asdfasdf;asdf!asdfasdf a#";


            //Console.WriteLine($"Count of Words {article.ADVStringExtesion()}" );
            //Console.Read();
        }
    }
}
