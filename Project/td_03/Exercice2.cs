using System;

namespace td_03;

class Exercice2
{

    public static void ShuffleTable(int[] arrayExo2)
    {
        Random rand = new Random();
        for (int i = arrayExo2.Length - 1; i > 0; i--)
        {
            int j = rand.Next(i + 1);
            int temp = arrayExo2[i];
            arrayExo2[i] = arrayExo2[j];
            arrayExo2[j] = temp;
        }
    }

}
