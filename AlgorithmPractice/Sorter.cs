using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice
{
    class Sorter
    {
        
        public static void MergeSort(int[] array, int[] helper, int startIndex, int endIndex)
        {
            if (startIndex < endIndex)
            {
                int middleIndex = (startIndex + endIndex) / 2;
                MergeSort(array, helper, startIndex, middleIndex);
                MergeSort(array, helper, middleIndex + 1, endIndex);
                Merge(array, helper, startIndex, middleIndex, endIndex);
            }
        }

        private static void Merge(int [] array, int[] helper, int startIndex, int middleIndex, int endIndex)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                helper[i] = array[i];
            }
            int helperLeft = startIndex;
            int helperRight = middleIndex + 1;
            int currentIndex = startIndex;

            while (helperLeft <= middleIndex && helperRight <= endIndex)
            {
                if (helper[helperLeft] <= helper[helperRight])
                {
                    array[currentIndex] = helper[helperLeft];
                    helperLeft++;
                }
                else
                {
                    array[currentIndex] = helper[helperRight];
                    helperRight++;
                }
                currentIndex++;
            }

            int remaining = middleIndex - helperLeft;
            for (int i = 0; i <= remaining; i++)
            {
                array[currentIndex + i] = helper[helperLeft + i];
            }
        }
    }
}
