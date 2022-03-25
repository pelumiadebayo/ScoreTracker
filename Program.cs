using System;

namespace ScoreTracker
{
    class Program
    {
        static void Main()
        {
            int[] array = {1,2,3,4,5};
            ScoreTracker(array);
        }

        public static void ScoreTracker(int[] intArray)
        {
            int totalScore = 0;
            foreach (var item in intArray)
            {
                if (item%2==0)
                {
                    totalScore += 1;
                }
                if (item % 2 > 0)
                {
                    totalScore += 3;
                }
                if (item==8)
                {
                    totalScore += 5;
                }
            }
            Console.WriteLine(totalScore);
        }
    }
}
