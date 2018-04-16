using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentApi.Linq
{
    class Program
    {
        static List<Order> _orders = new List<Order>()
        {
            new Order {Id=1, Description="Order 1",Total=100.00},
            new Order {Id=2, Description="Order 2",Total=200.00},
            new Order {Id=3, Description="Order 3",Total=300.00, IsShipped=true},
            new Order {Id=4, Description="Order 4",Total=400.00},
            new Order {Id=5, Description="Order 5",Total=500.00, IsShipped=true},
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        #region Standard
        static IEnumerable<Order> GetShippedOrdersGreaterOrEqual(int total)
        {
            var orders = new List<Order>();
            foreach (var order in _orders)
            {
                if (order.Total >= total && order.IsShipped)
                {
                    orders.Add(order);
                }
            }
            orders.Sort(Comparison);
            return orders;
        }

        static int Comparison(Order x, Order y)
        {
            if (x == null)
            {
                if (y == null)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                if (y == null)
                {
                    return 1;
                }
                else
                {
                    int retval = x.Id.CompareTo(y.Id);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return x.Id.CompareTo(y.Id);
                    }
                }
            }
        }
            
        #endregion

        #region Linq
        static IEnumerable<Order> GetShippedOrdersGreaterOrEqualLinq(int total)
        {
            return _orders.Where(o => o.Total >= total && o.IsShipped).OrderBy(orderBy => orderBy.Id);
        }
        #endregion

    }
}
