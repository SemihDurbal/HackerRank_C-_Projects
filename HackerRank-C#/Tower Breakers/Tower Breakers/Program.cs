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
    public static int towerBreakers(int n, int m)
    {
        int player = 0;
        for(int i = 0; i < n; i++) 
        {
            player++;
                for(int j = m / 2; j > 0; j--)
                {
                    m = m / j;
                    if (j == 1)
                    {
                        break;
                    }
            }

        }

        if( player %2 == 1) 
        {
            player = 1;
        }
        else
        {
            player = 2;
        }


        return player;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        String sonuc = "";
        int t = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            sonuc += Result.towerBreakers(n,m) + " ";
        }
        Console.WriteLine(sonuc);
        Console.ReadLine();
    }
}
