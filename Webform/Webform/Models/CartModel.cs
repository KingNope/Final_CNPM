using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Webform.Context;

namespace Webform.Models
{
    public class CartModel
    {
        public product Product { get; set; }
        public int quantity { get; set; }

        public product image { get; set; }
        public product Name_product { get; set; }
        public product price { get; set; }
        public float TotalPrice { get; set; }
        public User ID { get; set; }

        public User Ten { get; set; }
        public User DiaChi { get; set; }
        public User SDT { get; set; }
        public string PhuongThuc { get; set; }
    }
}