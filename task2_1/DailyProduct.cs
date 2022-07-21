using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    internal class DailyProduct : Product
    {
		private Term term;

		public DailyProduct() : this(default, default, default) { }

		public DailyProduct(string name, decimal price, Term term) : base(name, price)
		{
			this.term = term;

		}


		public override void IncrisePrice(int percent)
		{
			Price = Math.Round(Price * (100 + percent + Values.PersentOfTerm(term)) / 100, 2);
		}

		public override string ToString()
		{
			return term.ToString() + ' ' + base.ToString();
		}
	}
}
