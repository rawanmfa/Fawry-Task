using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Chalenge
{
	public class CartItem
	{
		public Product Product { get; set; }
		public int Quantity { get; set; }

		public CartItem(Product product, int quantity)
		{
			Product = product;
			Quantity = quantity;
		}
	}
	public class Cart
	{
		public List<CartItem> Items { get; } = new List<CartItem>();
		public void Add (Product product, int quantity)
		{
			if ( quantity > product.Quantity)
			{
				Console.WriteLine($"Not enough stock for {product.Name}. Only Available: {product.Quantity}");
				return;
			}
			else
			{
				if (product.IsExpired)
				{
					Console.WriteLine($"Cannot add {product.Name} to cart. Product is expired.");
					return;
				}
				product.Quantity -= quantity;
				Items.Add(new CartItem(product, quantity));
			}
		}
		public void PrintCart()
		{
			Console.WriteLine("*Checkout recipt*");
			foreach (var item in Items)
			{
				Console.WriteLine($"{item.Quantity}x {item.Product.Name} = ${item.Product.Price * item.Quantity}");
			}
		}	
	}
}
