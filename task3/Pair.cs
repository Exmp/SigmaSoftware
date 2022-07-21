using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Pair
    {
        public int freq;
        public int value;

        public Pair(int freq, int value)
        {
            this.freq = freq;
            this.value = value;
        }

        public override bool Equals(Object obj)
        {
            try
            {
                Pair pair = (Pair)obj;
                return pair.freq * pair.value == this.freq * this.value;
            }
            catch
            {
                return false;
            }
        }

        public override string ToString()
        {
            return value + " - " + freq;
        }

    }
}
