using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    internal class Meat : Product
    {
		private readonly Grade grade;
		private readonly MeatType meatType;

		public Meat() : this(default, default, default, default) { }

		public Meat(string name, decimal price = 0, Grade grade = Grade.extra, MeatType meatTypem = MeatType.Beef) : base(name, price)
		{
			this.grade = grade;
			this.meatType = meatTypem;
		}


		public override void IncrisePrice(int Percent)
		{
			Price = Math.Round(Price + (100 + Percent + Values.PersentOfGrade(grade) + Values.PersentOfMeatType(meatType)) / 100, 2);
		}

		public override string ToString()
		{
			return grade.ToString() + ' ' + meatType.ToString() + ' ' + base.ToString();
		}
	}
}
