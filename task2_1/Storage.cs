using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_1
{
    internal class Storage
    {
        private Product[] _data;
        public Storage()
        {
            _data = new Product[5];
        }
        public Product this[int index]
        {
            get
            {
                return _data[index];
            }
            set
            {
                _data[index] = value;
            }
        }
        public void PrintMeat()
        {
            foreach (Product product in _data)
            {
                if (product != null)
                {
                    if (product.GetType() == typeof(Meat))
                        Console.WriteLine(product);
                }
            }
        }

        public void Printall()
        {
            foreach (Product product in _data)
            {
                if (product != null)
                    Console.WriteLine(product);
            }
        }

        public void IncrisePrice(int Percent)
        {
            foreach (Product product in _data)
            {
                if (product != null)
                    product.IncrisePrice(Percent);
            }
        }
    }
}
