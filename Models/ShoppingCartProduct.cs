﻿using System.ComponentModel.DataAnnotations;

namespace AngularProject.Models
{
    public class ShoppingCartProduct
    {
        [Key]
        public int Id { get; set; }
        public  Product Product { get; set; }
        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
