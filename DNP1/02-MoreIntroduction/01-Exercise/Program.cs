using System;
using StudentNamespace;
using CompanyExercise;
using AnimalsCollecion;
using System.Collections.Generic;
using System.Collections;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Exercise no.1 -> inheritance, polymorphism
            // a)
            var student = new Student();
            Console.WriteLine(student.Hi());
            var dnpStudent01 = new DNPStudent();
            Console.WriteLine(dnpStudent01.Hi());
            // b) -> for more info check Student101.cs file
            var dnpStudent02 = (Student) dnpStudent01;
            Console.WriteLine(dnpStudent02.Hi());
            
            // Exercise no.2 -> polymorphism
            // setup company
            var company = new Company();
            // setup fulltime employees
            var fullEmp01 = new FullTimeEmployee("Josh", 15.0);
            var fullEmp02 = new FullTimeEmployee("Bart", 75.4);
            var fullEmp03 = new FullTimeEmployee("Trisha", 11.3);
            // setup parttime employees
            var partEmp01 = new PartTimeEmployee("Erica", 13.0, 10);
            var partEmp02 = new PartTimeEmployee("Peter", 11.5, 5);
            var partEmp03 = new PartTimeEmployee("Joshua", 9.0, 2);
            // hire employees
            company.EmployNewEmplyee(fullEmp01);
            company.EmployNewEmplyee(fullEmp02);
            company.EmployNewEmplyee(fullEmp03);
            company.EmployNewEmplyee(partEmp01);
            company.EmployNewEmplyee(partEmp02);
            company.EmployNewEmplyee(partEmp03);
            // calculate total month salary
            Console.WriteLine(company.GetMonthlySalatyTotal());

            // Exercise no.3 -> interfaces
            // hire part time student
            var partStudent01 = new PartTimeStudent("Patrick", 110.5, 75, 2016);
            company.EmployNewEmplyee(partStudent01);
            // calculate total salary one more time
            Console.WriteLine(company.GetMonthlySalatyTotal());

            // Exercise no.4 -> collections
            // a)
            var animal01 = new Animal("dog", 5.3, 22);
            var animal02 = new Animal("cat", 2.0, 15);
            var animal03 = new Animal("chicken", 3.4, 18);
            // b)
            IList animalList = new List<Animal>();
            animalList.Add(animal01);
            animalList.Add(animal02);
            animalList.Add(animal03);
            foreach(Animal animal in animalList)
                Console.WriteLine(animal.ToString());
            // c) sort animals by wright

        }
    }
}
