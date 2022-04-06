using System;
using System.Collections.Generic;
using System.Text;

namespace Serialize_and_Deserialize.Models
{
    class Order
    {
        public int Id { get; set; }

        public List <OrderItem> OrderItem { get; set; }
        public double TotalPrice { get; set; }
    }
}
