using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//შექმენით გაფართოებული მეთოდი მთელ რიცხვთა მასივისთვის, რომელიც მოახდენს მასივის დალაგებას
namespace Store
{
    public static class problemTwo
    {
        public static void Sort(this int[] array)
        {
            int n = array.Length;
            for(int i=0; i< n-1; i++)
            {
                int minIndex = i;
                for(int j= i+1; j < n; j++)
                {
                    if (array[j] < array[minIndex]) { 
                        minIndex = j;
                    }
                }
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }

    }
}
