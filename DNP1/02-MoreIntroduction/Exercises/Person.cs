
namespace PersonExercise{

   class Person{

      private string name;
      private int age;
      private int power;

      public string Name{ get{ return name;} }
      public int Age{ get; set; }
      public int Power{ get; set; }

      public Person(string name, int age, int power){
         this.name = name;
         this.age = age;
         this.power = power;
      }

      public override string ToString() => this.name;
   }
}