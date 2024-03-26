using System;

namespace td_03;

class Exercice3
{

    public static int GetPosOrNeg(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("Le nombre est positif");
        }
        else if (number < 0)
        {
            Console.WriteLine("Le nombre est négatif");
        }
        else
        {
            Console.WriteLine("Le nombre est nul");
        }
        return number;
    }

}
