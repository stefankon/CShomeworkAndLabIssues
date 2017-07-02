using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ')
                                .Select(int.Parse).ToArray();

            InsertionSort(arr);

            Console.WriteLine(String.Join(" ", arr));
        }

        static void InsertionSort(int[] arr)
        {
            for (int firstIndex = 0; firstIndex < arr.Length; firstIndex++)
            {
                for (int secondIndex = firstIndex; secondIndex > 0; secondIndex--)
                {
                    if (arr[secondIndex - 1] > arr[secondIndex])
                    {
                        Swap(ref arr[secondIndex - 1], ref arr[secondIndex]);
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        static void BubleSort(ref int[] arr)
        {
            for (int cnt1 = 0; cnt1 < arr.Length; cnt1++)
            {
                for (int cnt2 = 0; cnt2 < arr.Length - 1; cnt2++)
                {
                    if (arr[cnt2] > arr[cnt2 + 1])
                    {
                        Swap(ref arr[cnt2], ref arr[cnt2 + 1]);
                    }
                }
            }
            
        }
        static void Swap(ref int first, ref int second)
        {
            int temp = first;
            first = second;
            second = temp;
        }
    }
}
