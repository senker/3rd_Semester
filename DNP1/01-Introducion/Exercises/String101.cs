
using System;

namespace ExerciseString{

   class StringUtility{

      public static string SumarizeText(string text){
         if(text.Length <= 20)
            return text;
         return text.Substring(0, 20) + " ...";
      }

      public static string Reverse(string name){
         char tmp;
         char[] segmentedName = name.ToCharArray();

         for(int i = 0; i < segmentedName.Length / 2; i++){
            tmp = segmentedName[i];
            segmentedName[i] = segmentedName[segmentedName.Length-i-1];
            segmentedName[segmentedName.Length-i-1] = tmp;
         }

         return new String(segmentedName);
      }
   }
}