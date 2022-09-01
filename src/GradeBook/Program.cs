using System;
using System.Collections.Generic;

namespace GradeBook {
   class Program {
      static void Main(string[] args) {
         var numbers = new[]{12.3,4.3,24.3};
         var grades = new List<double>(){12.3,4.3,24.3}; 
         grades.Add(34.4);
         var result = 0.0;
         
         foreach(var number in grades) {
            result+= number;
         }

         var average = result/grades.Count;

         Console.WriteLine($"The average grade is {average:N2}.");
         // cw is the shortcut in vs code for Console.WriteLine but...
         System.Console.WriteLine("uses full namespace for some dumb reason");
         
         if (args.Length > 0) {
            Console.WriteLine($"Hello, {args[0]}!");
         } else {
            Console.WriteLine("You must provide an argument!");
         }        
      }
   }
}