using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Check
    {
        private Buy[] arr;
        public Check()
        {
            arr = new Buy[0];
        }

        public void Add(Buy buy)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = (buy);
        }

        public void Print()
        {
            double weight = 0;
            double cost = 0;

            Console.WriteLine("Cart: ");
            for (int i = 0; i < arr.Length; i++)
            {
                weight += arr[i].Wight();
                cost = cost + arr[i].Cost();
                Console.WriteLine(arr[i].Cost().ToString());
                Console.WriteLine(arr[i].Position() + " - " + arr[i].Count().ToString());
                Console.WriteLine(arr[i].Cost().ToString());

            }

            Console.WriteLine("Повна вартiсть: " + cost.ToString());
            Console.WriteLine("Сумарна вага: " + weight.ToString());


        }
    }
}
