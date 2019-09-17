using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithmpgm
{
    public class Utility
    {
        public string String_input()
        {
            Console.WriteLine("Enter the string");
            string s = Convert.ToString(Console.ReadLine());
            return s;
        }

        public void InsertString(String[] arr)
        {
            int n = arr.Length;
            String temp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((arr[i].CompareTo(arr[j]) > 0))
                    {
                        temp = arr[i];
                        arr[j] = arr[i];
                        arr[j] = temp;
                    }
                }
            }

        }
        public void BinaryString(string[] arr, int first, int last, string key)
        {
            int mid = (first + last) / 2;
            while (first <= last)
            {
                int store = key.CompareTo(arr[mid]);
                if (store == 0)
                {
                    Console.WriteLine(key + "element is found at index" + (mid + 1));
                    break;
                }
                else if (store < 0)
                {
                    last = mid - 1;
                }
                else
                {
                    first = mid + 1;
                }
                mid = (first + last) / 2;
            }
            if (first > last)
            {
                Console.WriteLine("Element is not found");
            }
        }


            public void Merge(string[] arr, int l, int m, int r)
        {
            ////Calculate the length of two subarrays
            int n1 = m - l + 1;
            int n2 = r - m;
            string[] L = new string[n1];
            string[] R = new string[n2];
            ////move strings from left of mid in L subarray
            for (int i = 0; i < n1; i++)

            {
                L[i] = arr[l + i];
            }
            ////move strings from right of mid in R subarray
            for (int j = 0; j < n2; j++)
            {
                R[j] = arr[m + 1 + j];
            }
            ////merge the temporary arrays
            int p = 0, n = 0;
            ////Initial index of merged sub array
            int k = l;
            while (p < n1 && n < n2)
            {
                if (L[p].CompareTo(R[n]) < 0)
                {
                    arr[k] = L[p];
                    p++;

                }
                else
                {
                    arr[k] = R[n];
                    n++;
                }

                k++;
            }
            ////copy remaining elements of L[] if any
            while (p < n1)
            {
                arr[k] = L[p];
                p++;
                k++;
            }
            ////copy remaining elements of R[] if any
            while (n < n2)
            {
                arr[k] = R[p];
                n++;
                k++;
            }



        }
    }
}

