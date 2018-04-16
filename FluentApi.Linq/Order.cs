using System;
namespace FluentApi.Linq
{
    public class Order
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Total { get; set; }
        public bool IsShipped { get; set; }
    }
}
