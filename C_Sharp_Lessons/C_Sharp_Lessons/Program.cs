using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace C_Sharp_Lessons
{
   public class Program
    {

     
       public static void Main(string[] args)
        {
            
            int[] arr = { 2, 1, 2, 6, 79, 1 };
            int max=arr[0];
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<arr[0]) arr[i] = arr[0];
                Console.WriteLine(arr[i]);
              

            }
            
        
        }
            
        
           
        }
    }

