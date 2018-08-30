
using System;

namespace ExerciseString{

   class StringUtility{

      public static string SumarizeText(String text){
         if(text.Length <= 20)
            return text;
         return text.Substring(0, 20) + " ...";
      }
   }
}