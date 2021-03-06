using System;

namespace StudentNamespace { 

   class Student {

      public virtual string Hi(){
         return "Hi, I am student";
      }

   }

   class DNPStudent : Student {

      // override/new -> with 'new' after casting to parent,
      //                parent`s method is called
      public new string Hi(){
         return "Hi, I am DNPStudent";
      }

      // base => calls parents method
      // public override string Hi(){
      //    return base.Hi();
      // }

   }

   interface IStudent{

      void Register(int year);
   }
}