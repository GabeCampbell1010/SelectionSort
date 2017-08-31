using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 3,7,4,1,6,5,2,9,0,8, 19, 12, 13, 11, 14, 17, 16 };
            
            List<int> sorted = SelectionSort.Sort(list);
            
            foreach(int num in sorted)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }

    public static class SelectionSort
    {
        public static List<int> Sort(List<int> list)
        {
            int min = list[0];
            int minIndex = 0;
            int temp = 0;
            int count = 0;
            int max = list[0];
            
            while (count < list.Count)
            {
                for (int i = count; i < list.Count(); i++)
                {
                    
                    if (list[i] < min)
                    {
                        min = list[i];
                        minIndex = i;
                    }
                    if(list[i] > max)
                    {
                        max = list[i];
                    }
                    
                }
                
                temp = list[count];
                list[count] = min;
                list[minIndex] = temp;
                min = max + 1;//min needs to be reset to the new starting position after it is used
                count++;
            }
            for(int i = 0; i < list.Count -1; i++)
            {
                Debug.Assert(list[i] < list[i + 1]);//check that it is sorted
            }
            return list;
        }
    }
}

