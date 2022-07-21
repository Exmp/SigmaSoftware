using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Buy
    {
		private Product product;
		private int count;

		public Buy(Product product, int count = 1)
		{
			this.product = product;
			this.count = count;
		}

		public int Count()
		{ 
			return this.count; 
		}

		public void SetCount(int count)
		{
			if (count< 1)
			{
				this.count = 1;
			}
			else
			{ 
				this.count = count;
			}
		}

		public double Wight()
		{
			return product.Wight * count;
		}

		public string Position()
		{ 
			return product.Description;
		}


		public double Cost()
		{
			return product.Price * count;
		}

	}
}
