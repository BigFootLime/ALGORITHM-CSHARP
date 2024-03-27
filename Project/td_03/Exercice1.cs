using System;

namespace td_03;

class Exercice1
{

    public static string GetFirstAndLastChar(string chaine)
    {
        char firstLetter = chaine[0];
        char lastLetter = chaine[chaine.Length - 1];
        return firstLetter + " " + lastLetter;

    }

}
