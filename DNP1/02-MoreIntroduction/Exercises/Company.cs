using System;
using System.Collections;
using System.Collections.Generic;

using StudentNamespace;

namespace CompanyExercise
{

   class Company
   {
      IList employeeList;

      public Company()
      {
         employeeList = new List<Employee>();
      }

      public void EmployNewEmplyee(Employee newEmployee)
      {
         employeeList.Add(newEmployee);
      }

      public double GetMonthlySalatyTotal()
      {
         double sum = 0.0;
         foreach (Employee employee in employeeList)
         {
            sum += employee.GetMonthSalary();
         }
         return sum;
      }
   }

   abstract class Employee
   {
      private string name;

      public Employee(string name) => this.name = name;

      public abstract double GetMonthSalary();
   }

   class FullTimeEmployee : Employee
   {
      private double monthlySalary;

      public FullTimeEmployee(string name, double monthlySalary) : base(name) => this.monthlySalary = monthlySalary;

      public override double GetMonthSalary()
      {
         return monthlySalary;
      }
   }

   class PartTimeEmployee : Employee
   {
      private double hourlyWage;
      private int hoursPerMonth;

      public PartTimeEmployee(string name, double hourlyWage, int hoursPerMonth) : base(name)
      {
         this.hourlyWage = hourlyWage;
         this.hoursPerMonth = hoursPerMonth;
      }

      public override double GetMonthSalary()
      {
         return hourlyWage * hoursPerMonth;
      }

   }

   class PartTimeStudent : PartTimeEmployee, IStudent
   {

      private int eduStart;

      public PartTimeStudent(string name, double hourlyWage, int hoursPerMonth, int eduStart) : base(name, hourlyWage, hoursPerMonth)
      {
         Register(eduStart);
      }

      public void Register(int year)
      {
         this.eduStart = year;
      }

   }
}