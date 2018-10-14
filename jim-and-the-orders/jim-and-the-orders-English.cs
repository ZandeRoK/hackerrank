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

class Solution {

    // Complete the jimOrders function below.
    static int[] jimOrders(int[][] orders) {
        Dictionary<int,int> dic = new Dictionary<int,int>();
        for(int i=0;i<orders.Length;i++)
        {
            int sum=0;
            for (int j =0; j<orders[i].Length; j++)
            {
                sum+=orders[i][j];
            }
            dic.Add(i+1,sum);
            
        }
             dic = dic.OrderBy(u => u.Value).ToDictionary(z => z.Key, y => y.Value);
            
            int[] foos = dic.Keys.ToArray();
            
            return foos;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[][] orders = new int[n][];

        for (int i = 0; i < n; i++) {
            orders[i] = Array.ConvertAll(Console.ReadLine().Split(' '), ordersTemp => Convert.ToInt32(ordersTemp));
        }

        int[] result = jimOrders(orders);

        textWriter.WriteLine(string.Join(" ", result));

        textWriter.Flush();
        textWriter.Close();
    }
}