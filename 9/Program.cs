using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
      
        List<int> numbers = new List<int> { 55, 200, 740, 76, 230, 482, 95 };

       
        Console.WriteLine("The numbers greater than 80 are:");
        foreach (int num in numbers)
        {
            if (num > 80)
            {
                Console.WriteLine(num);
            }
        }

   
    }
}



