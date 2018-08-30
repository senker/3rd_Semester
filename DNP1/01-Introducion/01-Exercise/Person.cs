using System;

namespace Exercise
{

   class Person
   {
      private String name;

      public Person(String name) => this.name = name;

      public String Introduce(){
         return $"Hi, I am {name}";
      }
   }
}
