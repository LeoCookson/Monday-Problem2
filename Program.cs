using System;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            
        Console.Clear();
        var number = 0;
        var count = 9;
      Console.WriteLine("This Program will ask for ten numbers then tell you the total and average");
        for(var i = 0; i <= count; i++)
      { 
     Console.WriteLine("Please enter a number");
     
     var Input = int.Parse(Console.ReadLine());

     number += Input;
     
      }
      Console.WriteLine($"The Total Number is {number}");
      Console.WriteLine($"The Average is {number / 9}");
     




        
			
			Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
        }
    }
}
