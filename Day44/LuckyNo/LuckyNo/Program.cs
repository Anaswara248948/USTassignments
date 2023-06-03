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

class Solution
{
    static int nearlyLucky(List<int> Arr, int N)
    {
        // Write your code here
        int count = 0, rem = 0, num = 0, c = 0;
        for (int i = 0; i < N; i++)
        {
            num = Arr[i];
            while (num > 0)
            {
                rem = num % 10;
                if (rem == 3 || rem == 4 || rem == 7)
                {
                    c++;
                }
                num = num / 10;
            }
            if (c == 3 || c == 4 || c == 7)
            {
                count++;
            }
            c = 0;
        }
        return count;
    }

    static void Main(string[] args)
    {
        int N;
        N = Convert.ToInt32(Console.ReadLine());
        List<int> Arr = new List<int>();
        for (int j = 0; j < N; ++j)
        {
            int ArrItem = Convert.ToInt32(Console.ReadLine());
            Arr.Add(ArrItem);
        }
        int result;
        result = nearlyLucky(Arr, N);
        Console.Write(result);
    }
}