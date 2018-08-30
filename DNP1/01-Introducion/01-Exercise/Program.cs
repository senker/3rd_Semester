using System;
using CustomMathLib;
using ExerciseString;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercises from https://github.com/it-dnp1-a18/exercises_01

            // Exercise no.1 -> .net tutorial
            Console.WriteLine("Tutorial DONE! \n");
            
            // Exercise no.2 -> create new project, output your name
            Console.WriteLine("Hello R0b1S !\n");
            
            // Exercise no.3 -> person class (new file), Introduce method
            var person = new Person("Natalie");
            Console.WriteLine(person.Introduce() + "\n");
            
            
            // Exercise no.4 -> for(even), while(odd)
            // for (int i = 0; i <= 100; i++)
            //     Console.Write((i % 2 == 0) ? i + " ," : " ");
           
            // Console.WriteLine("");

            // int x = 0;
            // while(x < 100)
            //     Console.Write((++x % 2 != 0) ? x + " ," : " ");
            
            // Exercise no.5 -> 0-10 switch
           // var switch101 = new Switch101();

            // Exercise no.6
            var calculator = new Calculator();
            // Console.WriteLine(calculator.Add(31,11));
            // Console.WriteLine(calculator.Add(new int[] {1,2,3}) + "\n");


            // Exercise no.7 -> readline 2 numbers => max
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine((a > b) ? $"MAX: {a}" : (a < b) ? $"MAX: {b}" : "MAX: equals");
            
            // Exercise no.8
            // Console.WriteLine(StringUtility.SumarizeText("This is short too long for this."));

            // Exercise no.9
            // Exercise no.10
            Console.WriteLine(calculator.Div(4, 2));
            Console.WriteLine(calculator.Div(5, 0));
            Console.WriteLine(calculator.Mul(21, 2));
            Console.WriteLine(calculator.Sub(49, 7));


        }
    }
}
