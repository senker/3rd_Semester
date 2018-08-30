

namespace CustomMathLib{

   class Calculator{

      public int Add(int a, int b) => a + b;

      public int Add(int[] array){
         int sum = 0;
         foreach (int number in array)
            sum += number;
         
         return sum;
      }

      public int Sub(int a, int b) => a - b;

      public int Mul(int a, int b) => a * b;

      public int Div(int divident, int divisor) => divisor == 0 ? -1 : divident / divisor;
   }


}