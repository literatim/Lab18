using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab18
{
    public static class LinkedListExtensions
    {
        public static bool RemoveAt(this LinkedList<int> list, int index)
        {
            try
            {
                LinkedListNode<int> currentNode = list.First;
                for (int i = 0; i <= index && currentNode != null; i++)
                {
                    if (i != index)
                    {
                        currentNode = currentNode.Next;
                        continue;
                    }

                    list.Remove(currentNode);
                }

                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public static void PrintReverse(this LinkedList<int> linkedList)
        {
            for (int i = linkedList.Count - 1; i > -1; i--)
            {
                linkedList.AddLast(linkedList.ElementAt(i));
                linkedList.Remove(linkedList.ElementAt(i));
            }

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        public static bool InsertAt<T>(this LinkedList<T> list, int index, T o)
        {
            try
            {
                LinkedListNode<T> currentNode = list.First;
                for (int i = 0; i <= index && currentNode != null; i++)
                {
                    if (i != index)
                    {
                        currentNode = currentNode.Next;
                        continue;
                    }

                    list.AddBefore(currentNode, o);
                }

                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }

}