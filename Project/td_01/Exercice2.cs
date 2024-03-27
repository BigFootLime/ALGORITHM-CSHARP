using System;
namespace td_01;
public class Exercice2
{
    public static string ReverseString(string inputString)
    {
        char[] charArray = inputString.ToCharArray(); // Convert string to char array
        Array.Reverse(charArray); // Reverse the array
        return new string(charArray); // Convert char array to string
    }

    // CORRECTION

    // public static string ReverseString(string str)
    // {
    //     char[] charArray = str.ToCharArray();
    //     Array.Reverse(charArray);
    //     return new string(charArray);
    // }



}