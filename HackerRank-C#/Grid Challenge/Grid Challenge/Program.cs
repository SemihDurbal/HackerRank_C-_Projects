using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    public static string gridChallenge(List<string> words , int harfSayisi)
    {

        List<string> result = new List<string>();

        for(int i = 0; i < harfSayisi; i++)
        {
            Char[] wordsChar = words[i].ToCharArray();
            
            for(int j = 1; j < harfSayisi; j++)
            {
                int numberOfChar1 = Convert.ToInt32(wordsChar[j-1]);
                int numberOfChar2 = Convert.ToInt32(wordsChar[j]);
                if(numberOfChar2 < numberOfChar1)
                {
                    return "NO";
                }
            }
        }
        for(int i = 0; i < harfSayisi-1; i++)
        {
            Char[] ilkKelime = words[i].ToCharArray();
            Char[] ikinciKelime = words[i + 1].ToCharArray();
            for(int j = 0; j<harfSayisi; j++)
            {
                int FWord = Convert.ToInt32(ilkKelime[j]);
                int SWord = Convert.ToInt32(ikinciKelime[j]);
                if(FWord > SWord)
                {
                    return "NO";
                }
            }
        }

        return "YES";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        // testCaselerin sayısı
        int testCases = Convert.ToInt32(Console.ReadLine());

        List<String> words = new List<String>();

        for (int i = 0; i < testCases; i++)
        {
            // kelimelerin kaç harfli olacağı
            int harfSayi = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < harfSayi; j++)
            {
                String word = Convert.ToString(Console.ReadLine());
                if (word.Length == 2)
                {
                    word = word + " ";
                }
                if (word.Length == 1)
                {
                    word = word + "  ";
                }
                if (word.Length == 0)
                {
                    word = word + "   ";
                }
                words.Add(word);
            }
            Console.WriteLine(Result.gridChallenge(words, harfSayi));
            words.RemoveAll(word => word.Length > 0);
        }

        Console.ReadLine();

    }
}
