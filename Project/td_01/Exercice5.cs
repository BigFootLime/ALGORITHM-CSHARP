using System;
namespace td_01
{
    public static class Exercice5
    {
        public static int MaxArray(int[] arrayforMax)
        {
            int max = 0;
            foreach (int i in arrayforMax)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            Console.WriteLine("Réponse à l'exercice 5: " + max);
            return max;
        }
    }
}