using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Chalenge
{
	public class Product
	{
		public string Name { get; set; }
		public double Price { get; set; }
		public int Quantity { get; set; }
		public bool IsExpired { get; set; }
		public double Weight { get; set; }
		public Product(string name, double price, int quantity , bool isExpired ,double weight)
		{
			Name = name;
			Price = price;
			Quantity = quantity;
			IsExpired = isExpired;
			Weight = weight;
		}
	}
}
