/*
 Goodland Electricity hackerrank solution c#
Goodland is a country with a number of evenly spaced cities along a line.
The distance between adjacent cities is  unit. There is an energy infrastructure project planning meeting,
and the government needs to know the fewest number of power plants needed to provide electricity to the entire 
list of cities. Determine that number. If it cannot be done, return -1.

You are given a list of city data. Cities that may contain a power plant have been labeled .
Others not suitable for building a plant are labeled . Given a distribution range of ,
find the lowest number of plants that must be built such that all cities are served.
The distribution range limits supply to cities where distance is less than k.

Function Description
pylons has the following parameter(s):
int k: the distribution range
int arr[n]: each city's suitability as a building site
Returns
int: the minimum number of plants required or -1
Input Format
The first line contains two space-separated integers n and k, the number of cities
in Goodland and the plants' range constant.
The second line contains n space-separated binary integers where each integer indicates
suitability for building a plant.
*/

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
     * Complete the 'pylons' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int pylons(int k, List<int> arr)
    {
        int n = arr.Length;
        int powerPlants = 0;
        int currentPosition = 0;

        while (currentPosition < n)
        {
            int nextPlantPosition = -1;

            for (int i = Math.Min(currentPosition + k - 1, n - 1); i >= Math.Max(currentPosition - k + 1, 0); i--)
            {
                if (arr[i] == 1)
                {
                    nextPlantPosition = i;
                    break;
                }
            }

            if (nextPlantPosition == -1)
            {
                return -1; // Unable to serve all cities
            }

            powerPlants++;
            currentPosition = nextPlantPosition + k;
        }

        return powerPlants;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine()!.TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int k = Convert.ToInt32(firstMultipleInput[1]);

        List<int> arr = Console.ReadLine()!.TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.pylons(k, arr);

        Console.WriteLine(result);
    }
}
