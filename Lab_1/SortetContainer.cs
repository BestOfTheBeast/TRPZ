using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class SortetContainer
    {
        public void SelectionSort()
        {
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(20);

            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);

            }
            Console.WriteLine();

            int min;
            int temp = 0;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }

                Console.Write("{0} ", arr[i]);
            }
            Console.ReadKey();
        }
    }
}
