using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortTest3
{
    public class Program
    {
        private static void Main(string[] args)
        {
        }

        public static List<int> Quick(List<int> n)
        {
            if (n.Count <= 1)
            {
                return n;
            }

            int pivot = n[0];

            List<int> b = new List<int>();
            List<int> a = new List<int>();

            for (int i = 1; i < n.Count; i++)
            {
                if (n[i] < pivot)
                {
                    b.Add(n[i]);
                }
                else
                {
                    a.Add(n[i]);
                }
            }

            List<int> r = new List<int>();

            r.AddRange(Quick(b));
            r.Add(pivot);
            r.AddRange(Quick(a));

            return r;
        }

        public static List<int> Bubblesort(List<int> numbers)
        {
            int temp;

            for (int j = 0; j <= numbers.Count - 2; j++)
            {
                for (int i = 0; i <= numbers.Count - 2; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        temp = numbers[i + 1];
                        numbers[i + 1] = numbers[i];
                        numbers[i] = temp;
                    }
                }
            }

            return numbers;
        }

        public static List<int> Insertionsort(List<int> numbers)
        {
            for (int i = 0; i < numbers.Count - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        int temp = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}