using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay1CSharpAdvanced
{
    internal class Helper
    {

        public static void ReverseElement(ArrayList array)
        {
            int leftIndex = 0, rightIndex = array.Count - 1;
            #region First Implementation
            if (array.Count > 0)
            {
                while (leftIndex < rightIndex)
                {
                    object? temp = array[leftIndex];
                    array[leftIndex] = array[rightIndex];
                    array[rightIndex] = temp;
                    leftIndex++;
                    rightIndex--;
                }
            }
            #endregion

            #region Other Implementation 
            //if (array.Count > 0)
            //{
            //    while (leftIndex < rightIndex)
            //    {
            //        (array[leftIndex], array[rightIndex]) = (array[rightIndex], array[leftIndex]);
            //        leftIndex++;
            //        rightIndex--;
            //    }
            //}
            #endregion
        }

        public static List<int> FilterNumberEvenOfArray(List<int> array)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < array.Count; i++)
            {
                if ((array[i] % 2) == 0)
                {
                    result.Add(array[i]);
                }
            }
            return result;
        }

    }
}
