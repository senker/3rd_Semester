using System;
using CustomMathLib;
using ExerciseString;

namespace Exercise {
  
   class Program {
  
      static void Main (string[] args) {
         // Exercises from https://github.com/it-dnp1-a18/exercises_01

         // Exercise no.1 -> .net tutorial
         Console.WriteLine ("Exercise No. 1");
         Console.WriteLine ("\t" + "Tutorial DONE! \n");

         // Exercise no.2 -> create new project, output your name
         Console.WriteLine("Exercise No. 2");
         Console.WriteLine ("\t" + "Hello R0b1S !\n");

         // Exercise no.3 -> person class (new file), Introduce method
         Console.WriteLine("Exercise No. 3");
         var person = new Person ("Natalie");
         Console.WriteLine ("\t" + person.Introduce () + "\n");

         // Exercise no.4 -> for(even), while(odd)
         Console.WriteLine("Exercise No. 4");
         for (int i = 0; i <= 100; i++)
            Console.Write (((i % 2 == 0) ? i + " ," : " "));

         int x = 0;
         while (x < 100)
            Console.Write (((++x % 2 != 0) ? x + " ," : " "));

         // Exercise no.5 -> 0-10 switch
         Console.WriteLine("Exercise No. 5");
         var switch101 = new Switch101 ();

         // Exercise no.6 -> calculator add method
         Console.WriteLine("Exercise No. 6");
         var calculator = new Calculator ();
         Console.WriteLine ("\t" + calculator.Add (31, 11));
         Console.WriteLine ("\t" + calculator.Add (new int[] { 1, 2, 3 }) + "\n");

         // Exercise no.7 -> readline 2 numbers => max
         Console.WriteLine("Exercise No. 7 -> insert 2 number");
         int a = Convert.ToInt32 (Console.ReadLine ());
         int b = Convert.ToInt32 (Console.ReadLine ());
         Console.WriteLine ("\t" + ((a > b) ? $"MAX: {a}" : (a < b) ? $"MAX: {b}" : "MAX: equals") + "\n");

         // Exercise no.8 -> reverse name - should ask from user
         Console.WriteLine("Exercise No. 8");
         Console.WriteLine ("\t" + StringUtility.Reverse ("Natalie"));

         // Exercise no.9 -> sumarize text 
         Console.WriteLine("Exercise No. 9");
         Console.WriteLine ("\t" + StringUtility.SumarizeText ("This is short too long for this." + "\n"));

         // Exercise no.10 -> calculator div,mul,sub
         Console.WriteLine("Exercise No. 10");
         Console.WriteLine ("\t" + calculator.Div (4, 2));
         Console.WriteLine ("\t" + calculator.Div (5, 0));
         Console.WriteLine ("\t" + calculator.Mul (21, 2));
         Console.WriteLine ("\t" + calculator.Sub (49, 7));

      }
   }
}