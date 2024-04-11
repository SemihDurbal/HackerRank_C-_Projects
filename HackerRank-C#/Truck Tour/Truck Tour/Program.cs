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

    /*
     * Complete the 'truckTour' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY petrolpumps as parameter.
     */

    //public static int truckTour(List<List<int>> petrolpumps)
    //{

    //}

}

class Solution
{
    public static void Main(string[] args)
    {
        //Benzin pompa sayısı
        int pompaSayi = Convert.ToInt32(Console.ReadLine());

        //Her kilometrede 1 litre benzin tüketiyor

        for(int i = 1;i<=pompaSayi; i++)
        {
            int benzinMiktari = Convert.ToInt32(Console.ReadLine());
            int pompaMesafa = Convert.ToInt32(Console.ReadLine());
            if(benzinMiktari - pompaMesafa <= 0)
            {
                Console.WriteLine(i);
                return;
            }
        }


        Console.ReadLine();


    }
}
