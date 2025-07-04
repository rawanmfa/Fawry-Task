using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fawry_Chalenge
{
	public interface IShippingService
	{
		string GetName(Product product);
		double GetWeight(Product product);
	}
}
