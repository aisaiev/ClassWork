using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EF_Core_Code_First_02_08.Model
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int ItemsTotal { get; set; }

        public string Phone { get; set; }

        public string DeliveryState { get; set; }

        public string DeliveryCity { get; set; }

        public string DeliveryZip { get; set; }


        public OrderStatus OrderStatus { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
    }
}
