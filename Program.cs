using ShirtAssignmentV2.Enums;
using ShirtAssignmentV2.Payment;
using ShirtAssignmentV2.Sorting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShirtAssignmentV2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Running as is creates stack overflow error
            // Run with caution

            ShirtDatabase db = new ShirtDatabase();

            var newList = new List<Shirt>(db.Shirts);

            BubbleSort.SortShirtsBySizeAscending(newList);
            Console.WriteLine("Sorted by size, ascending, bubble sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            BubbleSort.SortShirtsBySizeDescending(newList);
            Console.WriteLine("Sorted by size, descending, bubble sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            BucketSort.SortShirtsByColorAscending(newList);
            Console.WriteLine("Sorted by color, ascending, bucket sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            QuickSort.SortShirtsByColorDescending(newList);
            Console.WriteLine("Sorted by color, descending, quick sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            BucketSort.SortShirtsByFabricAscending(newList);
            Console.WriteLine("Sorted by fabric, ascending, bucket sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            BubbleSort.SortShirtsByFabricDescending(newList);
            Console.WriteLine("Sorted by fabric, descending, bubble sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            BubbleSort.SortShirtsByEverythingAscending(newList);
            Console.WriteLine("Sorted by all, ascending, bubble sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();

            BubbleSort.SortShirtsByEverythingDescending(newList);
            Console.WriteLine("Sorted by all, descending, bubble sorting.");
            Console.WriteLine();
            foreach (var item in newList)
            {
                item.Output();
            }
            Console.WriteLine();
        }
    }
}
