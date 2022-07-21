using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Product
    {
		private string _description;
		public float Price { get; set; }
		public float Wight { get; set; }

		public Product(string description, float price = 0, float wight = 0)
		{
			_description = description;
			this.Price = price;
			this.Wight = wight;

		}

		public string description
		{
			get { return _description; }
		}
	}
}
