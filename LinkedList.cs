using System;
using System.Collections.Generic;

namespace Lab18
{
    public static class LinkedListExtensions
    {
        public static bool RemoveAt(this LinkedList<int> list, int index)
        {
            var removed = true;
            try
            {
            }
            catch (Exception e)
            {
                removed = false;
                Console.WriteLine(typeof(IndexOutOfRangeException));
                throw;
            }

            return removed;
        }

        public static void PrintReverse(this LinkedList<int> list)
        {
        }

        public static bool InsertAt(this LinkedList<int> list, int index, object o)
        {
            var inserted = true;
            try
            {
            }
            catch (Exception e)
            {
                inserted = false;
                Console.WriteLine(typeof(IndexOutOfRangeException));
                throw;
            }

            return inserted;
        }
    }
}