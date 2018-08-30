

namespace CustomMathLib{

   class Calculator{

      public int add(int a, int b) => a + b;

      public int add(int[] array){
         int sum = 0;
         foreach (int number in array)
            sum += number;
         
         return sum;
      }

      public int sub(int a, int b) => a - b;

      public int mul(int a, int b) => a * b;

      public int div(int divident, int divisor) => divisor == 0 ? throw new System.DivideByZeroException() : divident / divisor;
   }


}