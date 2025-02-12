﻿namespace Algorithms
{
    public class BinarySearch
    {
        public int Search(string[] list, string find, int start, int end)
        {
            if (start <= end)
            {
                int mid = (start + end) / 2;
                if (list[mid].CompareTo(find) == 0) return mid;
                if (find.CompareTo(list[mid]) > 0) return Search(list, find, mid + 1, end);
                else
                    return Search(list, find, start, mid - 1);
            }
            else
                return -1;
        }
    }
}