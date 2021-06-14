using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtAssignmentV2.Sorting
{
    class QuickSort
    {
        public static void SortShirtsByColorDescending(List<Shirt> shirts)
        {
            QuicksortDescending(shirts, 0, shirts.Count - 1);
        }


        private static void QuicksortDescending(List<Shirt> shirts, int left, int right)
        {
            if (left > right)
                return;

            var pivot = (int)shirts[(left + right) / 2].Color;
            int index = Partition(shirts, left, right, pivot);

            QuicksortDescending(shirts, left, index - 1);
            QuicksortDescending(shirts, index, right);
        }

        private static int Partition(List<Shirt> shirts, int left, int right, int pivot)
        {
            while (left <= right)
            {
                while ((int)shirts[left].Color < pivot)
                {
                    left++;
                }
                while ((int)shirts[right].Color > pivot)
                {
                    right--;
                }

                if (left <= right)
                {
                    var temp = shirts[left];
                    shirts[left] = shirts[right];
                    shirts[right] = temp;
                    left++;
                    right--;
                }
            }
            return left;
        }
    }
}
