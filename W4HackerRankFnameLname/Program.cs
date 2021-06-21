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
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
     */

    public static void staircase(int n)
    {
        //amount of spaces in each line
        int space = n - 1;

        //loops down the staircase
        for (int i = 1; i <= n; i++)
        {

            //loops to the right of the staircase
            //Prints the sames number of spaces as space variable
            for (int j = 0; j <= space; j++)
            {
                if (j != 0)
                {
                    Console.Write(" ");

                }

                //When space runs out, starts printing # and makes a new line
                if (j == space || space == 0)
                {
                    for (int k = 1; k <= n - space; k++)
                    {
                        Console.Write("#");
                    }
                    Console.WriteLine();
                }
            }

            //Makes sure space never goes negative
            if (space > 0)
            {
                space--;
            }
        }
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
