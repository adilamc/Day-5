using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_5
{
    class SecondLargest
    {
        public static void Main()
        {
            int n,j=0, largest, secondlargest;
            Console.WriteLine("Input size of array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            for(int i=0;i<n;i++)
            {
                Console.WriteLine("Enter arr[" + i + "]: ");
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }
            largest = 0;
            for(int i=0;i<n;i++)
            {
                if(largest<arr1[i])
                {
                    largest = arr1[i];
                    j = i;
                }
            }
            secondlargest = 0;
            for(int i=0;i<n;i++)
            {
                if(i==j)
                {
                    i++;
                    i--;
                }
                else
                {
                    if(secondlargest<arr1[i])
                    {
                        secondlargest = arr1[i];
                    }
                }
            }
            Console.WriteLine("Second Largest " + secondlargest);
            Console.ReadLine();
        }
    }
}
