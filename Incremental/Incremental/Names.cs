using System;
using System.Collections.Generic;
using System.Numerics;

namespace Incremental
{
    public class Names
    {
        public static String[] namesLv1to5 = { "George", "Hillary", "Trump", "Ronald", "Frank", "Steve", "Philip"};
        public static String[] namesLv1to10 = { "Michael", "Melissa", "Henry", "Sue", "Kelsey", "Kylie", "Kayla" };

        public static String GetRandomName(int level)
        {
            if(level <= 5)
            {
                return GetRandomNameFromArray(namesLv1to5);
            }
            else if (level <= 10)
            {
                return GetRandomNameFromArray(namesLv1to10);
            }
            return "NO NAMES FOR THIS LEVEL";
        }

        private static String GetRandomNameFromArray(String[] array)
        {
            return array[Number.random.Next(array.Length)];
        }
    }
}