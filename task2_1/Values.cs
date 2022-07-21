using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    internal class Values
    {
		public static int PersentOfGrade(Grade grade)
		{
			return (int)grade;
		}

		public static int PersentOfMeatType(MeatType meatType)
		{
			switch (meatType)
			{
				case MeatType.Beef:
					return 5;

				case MeatType.Pork:
					return 4;

				case MeatType.Mutton:
					return 3;

				case MeatType.Chicken:
					return 2;
			}
			return 1;

		}

		public static int PersentOfTerm(Term term)
		{
			switch (term)
			{
				case Term.Year:
					return 5;
				case Term.Month:
					return 4;
				case Term.Week:
					return 3;
			}
			return 1;

		}

	}
}
