using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShirtAssignmentV2.Sorting
{
    class BucketSort
    {
        public static List<Shirt> SortShirtsByColorAscending(List<Shirt> shirts)
        {
            List<Shirt> sortedList = new List<Shirt>();

            int numOfBuckets = 4;
            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < shirts.Count; i++)
            {
                int bucket = (int)shirts[i].Color;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(shirts[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = InsertionSortBucketByColor(buckets[i]);
                sortedList.AddRange(temp);
            }

            return sortedList;
        }
        public static List<Shirt> SortShirtsByFabricAscending(List<Shirt> shirts)
        {
            List<Shirt> sortedList = new List<Shirt>();

            int numOfBuckets = 4;
            List<Shirt>[] buckets = new List<Shirt>[numOfBuckets];
            for (int i = 0; i < numOfBuckets; i++)
            {
                buckets[i] = new List<Shirt>();
            }

            for (int i = 0; i < shirts.Count; i++)
            {
                int bucket = (int)shirts[i].Fabric;
                if (bucket == 0 || bucket == 1)
                    bucket = 0;
                else if (bucket == 2 || bucket == 3)
                    bucket = 1;
                else if (bucket == 4 || bucket == 5)
                    bucket = 2;
                else
                    bucket = 3;

                buckets[bucket].Add(shirts[i]);
            }

            for (int i = 0; i < numOfBuckets; i++)
            {
                List<Shirt> temp = InsertionSortBucketByFabric(buckets[i]);
                sortedList.AddRange(temp);
            }

            return sortedList;
        }

        public static List<Shirt> InsertionSortBucketByColor(List<Shirt> shirts)
        {
            Shirt temp;
            for (int i = 1; i < shirts.Count; i++)
            {
                int currentValue = (int)shirts[i].Color;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)shirts[pointer].Color)
                    {
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return shirts;
        }

        public static List<Shirt> InsertionSortBucketByFabric(List<Shirt> shirts)
        {
            Shirt temp;
            for (int i = 1; i < shirts.Count; i++)
            {
                int currentValue = (int)shirts[i].Fabric;
                int pointer = i - 1;

                while (pointer >= 0)
                {
                    if (currentValue < (int)shirts[pointer].Fabric)
                    {
                        temp = shirts[pointer + 1];
                        shirts[pointer + 1] = shirts[pointer];
                        shirts[pointer] = temp;
                        pointer--;
                    }
                    else
                        break;
                }
            }
            return shirts;
        }
    }
}
