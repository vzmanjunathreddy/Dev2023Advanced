using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStatic
{
    public static class Orders
    {
        static int maxOrders;
        static Orders()
        {
            maxOrders = 10;
        }

        public static int GetMaxOrders()
        {
            return maxOrders;
        }
    }
}
