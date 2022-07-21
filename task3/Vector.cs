using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Vector
    {
        protected int[] array;

#if QuickSort
        public void QuickSort()
        {
            QuickSort(0, array.Length - 1);
        }
        void QuickSort(int start, int end)
        {
            if (end - start < 1) return;
            int min = start, max = end;
            for (int i = start + 1; i <= end; i++)
            {
                if (array[min] > array[i]) min = i;
                if (array[max] < array[i - 1]) max = i;
            }
            Swap(start, min);
            Swap(end, max);
            if (end - start > 2)
            {
                int middle = (array[end] - array[start]) / 2 + array[start];
                int l = start + 1, r = end - 1;
                while (l < r)
                {
                    while (array[l] <= middle && l < r) l++;
                    while (array[r] >= middle && r > l) r--;
                    if (l < r) Swap(l++, r--);
                }
                QuickSort(start + 1, l - 1);
                QuickSort(l, end - 1);
            }
        }
        void Swap(int n, int m)
        {
            if (n != m)
            {
                int tmp = array[n];
                array[n] = array[m];
                array[m] = tmp;
            }
        }
#endif
        public Vector(int n)
        {
            array = new int[n];
        }

        public void InitRandom(int a, int b)
        {
            var generator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = generator.Next(a, b + 1);
            }
        }

        public static bool IsPolindrom(int[] arr)
        {
            bool result = arr.Length > 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (arr[i] != arr[arr.Length - i - 1])
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        public static int[] GetMaxSequence(int[] arr)
        {
            int j = 0;
            int maxvalue = 0;
            int curvalue = 0;

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                curvalue = 1;
                for (j = i; j < arr.Length - 1; j++)
                {
                    if (arr[j] + 1 == arr[j + 1])
                    {
                        curvalue++;
                    }
                    else { break; }
                }
                if (maxvalue < curvalue)
                {
                    index = i;
                    maxvalue = curvalue;
                };
            }

            int[] result = new int[maxvalue];
            for (j = 0; j < maxvalue; j++)
            {
                result[j] = arr[index + j];
            }

            return result;
        }

        public void ReversMyImpl()
        {
            int buffer;
            for (int i = 0; i < array.Length / 2; i++)
            {
                buffer = array[array.Length - i - 1];
                array[array.Length - i - 1] = array[i];
                array[i] = buffer;

            }
        }

        public void ReversStandart()
        {
            Array.Reverse(array);
        }

        public void InitShufle()
        {
            int r;
            var generator = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                while (true)
                {
                    r = generator.Next(1, array.Length + 1);
                    if (Array.IndexOf(array, r) >= 0)
                    {
                        array[i] = r;
                        break;
                    }
                }
            }
        }


        public Pair[] CalculateFreq()
        {
            var pairs = new Pair[0];
            for (int i = 0; i < array.Length; i++)
            {
                bool noPair = true;

                for (int j = 0; j < pairs.Length; j++)
                    if (pairs[j].value == array[i])
                    {
                        noPair = false;
                        pairs[j].freq++;
                        break;
                    }

                if (noPair)
                {
                    Array.Resize(ref pairs, pairs.Length + 1);
                    pairs[pairs.Length - 1] = new Pair(1, array[i]);
                }
            }
            return pairs;

        }

        public override string ToString()
        {
            return GetStringFromArray(array);

        }

        public int this[int index]
        {
            set
            {
                array[index] = value;

            }
            get
            {
                return array[index];
            }
        }

        public static string GetStringFromArray(int[] arr)
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                result = result + arr[i];
                if (i < arr.Length - 1)
                {
                    result = result + ',';
                }

            }
            return result;

        }


    }
}
