using System;

namespace td_01
{
    public static class Exercice4
    {
        public static int SumArray(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            Console.WriteLine("Réponse à l'exercice 4: " + sum);
            return sum;
        }
    }
}