﻿using System.Collections.Generic;
using System.Linq;

namespace Edura.Entity.Models
{
    public class Cart
    {
        private List<CartLine> products = new List<CartLine>();
        public List<CartLine> Products => products;

        public void AddProduct(Product product, int quantity)
        {
            var prd = products
                .Where(m => m.Product.ProductId == product.ProductId)
                .FirstOrDefault();

            if (prd == null)
            {
                products.Add(new CartLine()
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                prd.Quantity += quantity;
            }
        }

        public void RemoveProduct(Product product)
        {
            products.RemoveAll(m => m.Product.ProductId == product.ProductId);
        }

        public double TotalPrice()
        {
            return products.Sum(m => m.Product.Price * m.Quantity);
        }

        public void ClearAll()
        {
            products.Clear();
        }
    }

    public class CartLine
    {
        public int CartLineId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
