using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 20, 12, 44, 12, 56, 5, 22 };
            int[] result = SortetContainer.ShakerSort(arr);
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
