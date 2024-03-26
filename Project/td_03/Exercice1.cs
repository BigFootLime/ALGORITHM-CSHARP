using System;

namespace td_03;

class Exercice1
{

    public static string GetFirstAndLastChar(string input)
    {
        if (string.IsNullOrEmpty(input) || input.Length < 2)
        {
            return "L'input est trop court";
        }
        try
        {
            return input[0] + " " + input[^1];
        }
        catch (Exception)
        {
            return "Vueillez entrer une chaine de caractères valide";
        }
    }

}
