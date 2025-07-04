namespace Fawry_Chalenge
{

	public class Program
	{
		static void Main(string[] args)
		{
			var Apple = new Product("Apple", 50, 10, true, 40);
			var Tv = new Product("Tv", 500, 5, false, 300);
			var ScratchCard = new Product("Scratch Card", 100, 20, false, 0);

			Customer customer = new Customer("Rawan", 1000);
			var cart = new Cart();
			cart.Add(Apple, 2);
			cart.Add(Tv, 1);
			cart.Add(ScratchCard, 3);
			cart.PrintCart();
			Checkout(cart, customer);
		}
		public static void Checkout(Cart cart, Customer customer)
		{
			ShippingService shippingService = new ShippingService();
			double SubTotal = 0;
			foreach (var item in cart.Items)
			{
				SubTotal += item.Product.Price * item.Quantity;
            }

			if (customer.Balance < SubTotal)
			{
				Console.WriteLine("Insufficient balance for checkout");
				return;
			}
			Console.WriteLine($"\nSubTotal = {SubTotal}");
			double shippingCost = 0;
			foreach (var item in cart.Items)
			{
				if(item.Product.Weight > 0)
				{
					shippingCost += 10;
				}
			}
			Console.WriteLine($"Shipping = {shippingCost}");
			double total = SubTotal + shippingCost;
			Console.WriteLine($"Total = {total}\n");
            customer.Balance -= total;
			Console.WriteLine($"Checkout successful! Remaining balance: {customer.Balance}");
            Console.WriteLine("------------------------------------------------\n");
            Console.WriteLine("*Shipping recipt*");
			foreach (var item in cart.Items)
			{
				if(item.Product.Weight >0)
					Console.WriteLine($"{item.Quantity}x{shippingService.GetName(item.Product)} - Weight: {shippingService.GetWeight(item.Product)} g");
			}
		}
	}
}
