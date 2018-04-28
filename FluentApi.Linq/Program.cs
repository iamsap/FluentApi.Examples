using System;
using System.Collections.Generic;
using System.Linq;

namespace FluentApi.Linq
{
    class Program
    {
        #region Fake data
        static List<Order> _orders = new List<Order>()
        {
            new Order {Id=1, Description="Order 1",Total=100.00},
            new Order {Id=2, Description="Order 2",Total=200.00},
            new Order {Id=3, Description="Order 3",Total=300.00, IsShipped=true},
            new Order {Id=4, Description="Order 4",Total=400.00},
            new Order {Id=5, Description="Order 5",Total=500.00, IsShipped=true},
        };
        #endregion

        const int MaxTotal = 300;

        static void Main(string[] args)
        {
            GetShippedOrdersGreaterOrEqual(MaxTotal);
            GetShippedOrdersGreaterOrEqualLinq(MaxTotal);
        }

        #region Standard (47 lines w/bugs)
        static IEnumerable<Order> GetShippedOrdersGreaterOrEqual(int total)
        {
            var orders = new List<Order>();
            foreach (var order in _orders)
            {
                if (order.Total >= total)
                {
                    if(order.IsShipped) 
                    {
                        orders.Add(order);    
                    }

                }
            }
            orders.Sort(Comparison);
            return orders;
        }

        static int Comparison(Order order1, Order order2)
        {
            if (order1 == null)
            {
                if (order2 == null)
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
                if (order2 == null)
                {
                    return 1;
                }
                else
                {
                    int retval = order1.Id.CompareTo(order2.Id);

                    if (retval != 0)
                    {
                        return retval;
                    }
                    else
                    {
                        return order1.Id.CompareTo(order1.Id);
                    }
                }
            }
        }
            
        #endregion

        #region Linq (1 line)
        static IEnumerable<Order> GetShippedOrdersGreaterOrEqualLinq(int total)
        {
            return _orders
                    .Where(o => o.Total >= total && o.IsShipped)
                    .OrderBy(orderBy => orderBy.Id);
        }
        #endregion

    }
}
