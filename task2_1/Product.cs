using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    internal class Product
    {
		public string Name { get; set; }
		public decimal Price { get; set; }
		public decimal Weight { get; set; }


		public Product(string name, decimal price = 1)
		{
			this.Name = name;
			this.Price = price;
		}

		public virtual void IncrisePrice(int percent)
		{
			if (percent > -1 & percent <= 100)
			{
				Price = Math.Round(Price * (100 + percent) / 100, 2);
			}
		}

		public void Parse(string str)
		{
			string[] arr = str.Split(' ');
			if (arr.Length > 2)
				Weight = int.Parse(arr[2]);
			if (arr.Length > 1)
				Price = int.Parse(arr[1]);
			if (arr.Length > 0)
				Name = arr[0];

		}

		public override string ToString()
		{
			return Name + " " + Price.ToString();
		}
	}
}
