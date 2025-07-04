using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Chalenge
{
	public class ShippingService : IShippingService
	{
		public string GetName(Product product)
		{
			return product.Name;
		}

		public double GetWeight(Product product)
		{
			return product.Weight;
		}
	}
}
