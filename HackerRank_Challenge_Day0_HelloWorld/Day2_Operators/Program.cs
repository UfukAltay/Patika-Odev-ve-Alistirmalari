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
     * Complete the 'solve' function below.
     *
     * The function accepts following parameters:
     *  1. DOUBLE meal_cost
     *  2. INTEGER tip_percent
     *  3. INTEGER tax_percent
     */    

    public static void solve(double meal_cost, int tip_percent, int tax_percent)
    {
        tip_percent = Convert.ToInt32(meal_cost / 100 * tip_percent);
        tax_percent = Convert.ToInt32(tax_percent / 100 * 20);
        meal_cost += tip_percent + tax_percent;
               

        Console.WriteLine(meal_cost);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Meal Cost Giriniz : ");
        double meal_cost = Convert.ToDouble(Console.ReadLine().Trim());

        Console.WriteLine("Tip Percent Giriniz : ");
        int tip_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Console.WriteLine("Tax Percent Giriniz : ");
        int tax_percent = Convert.ToInt32(Console.ReadLine().Trim());

        Result.solve(meal_cost, tip_percent, tax_percent);

    }
}