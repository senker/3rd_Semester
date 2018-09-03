

using System;

namespace AnimalsCollecion{

   class Animal {

      private string type;
      private double weight;
      private int speed;

      public Animal(string type, double weight, int speed){
         this.type = type;
         this.weight = weight;
         this.speed = speed;
      }

      public double GetWeight(){
         return weight;
      }

      public override string ToString() => $"Animal: {type} => Weight: {weight} => Speed: {speed}";

   }
}