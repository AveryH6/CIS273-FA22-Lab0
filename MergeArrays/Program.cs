using System;

namespace MergeArrays
{

    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public static int[] MergeSortedArrays(int[] array1, int[] array2)
        {

            List<int> mergedArrays = new List<int>();

            foreach (int number in array1)
            {
                mergedArrays.Add(number);
            }

            foreach (int number in array2)
            {
                mergedArrays.Add(number);
            }

            mergedArrays.Sort();

            int[] newArray = mergedArrays.ToArray();

            return newArray;
            //var newArray = array1.Concat(array2).ToArray();
            
        }
    }

}