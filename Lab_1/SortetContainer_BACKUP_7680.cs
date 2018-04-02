using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    public class SortetContainer
    {
<<<<<<< HEAD
        public static int[] SortArray(int[] array)
        {
            int min, x, y = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];
                x = i;
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (min > array[j + i + 1])
                    {
                        min = array[j + i + 1];
                        x = i + j + 1;
                    }
                }

                y = array[i];
                array[i] = min;
                array[x] = y;
            }
            return array;
=======
        public static int[] ShakerSort(int[] arr)
        {
            int temp;
            int left = 0;
            int right = arr.Length - 1;
            do
            {
                for (int i = left; i < right; i++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                right--;
                for (int i = right; i > left; i--)
                {
                    if (arr[i] < arr[i - 1])
                    {
                        temp = arr[i];
                        arr[i] = arr[i - 1];
                        arr[i - 1] = temp;
                    }
                }
                left++;
            } while (left < right);
            return arr;
>>>>>>> master
        }
    }
}
