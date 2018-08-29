using System;

namespace Exercise
{

   class Switch101
   {
      public Switch101()
      {

         Console.WriteLine("\nType 0-10 or -1 for exit!");

         int x = 0;
         // Should be in try/catch
         // Let`s assume that client is smart 
         // and know what 0 - 10 means.
         x = Convert.ToInt32(Console.ReadLine());
         

         while (x != -1)
         {
            switch (x)
            {
               case 0:
                  Console.WriteLine("This is the first number");
                  break;
               case 1:
               case 2:
               case 3:
               case 4:
               case 5:
               case 6:
               case 7:
               case 8:
               case 9:
                  Console.WriteLine($"Number {x}");
                  break;
               case 10:
                  Console.WriteLine("This is the last number");
                  break;
               default:
                  Console.WriteLine("Wrong Input !");
                  break;
            }
            x = Convert.ToInt32(Console.ReadLine());
         }
      }
   }
}
