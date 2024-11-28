using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DiskLab_2
{
    static class LaboratoryWork
    {
        static string variables = "abcde";
        static public string Execute(string[] inputData, int count)
        {
            string strSKNF, strSDNF, strMDNF = "abc";
            int countVar = 3, k = 0;
            string[] arr = inputData;
            int[,] ar = SpiltVariables(arr);
            strSKNF = SKNF(ar);
            strSDNF = SDNF(ar);

            arr = strSDNF.Split(' ', 'v', ' ');
            arr = SplitEquation(arr);

            string prevMDNF = "";
            while (strMDNF != "")
            {
                string[,] mdnf = SepVar(arr, count - k);
                string[] resMDNF = MDNF(mdnf).Split(' ', 'v', ' ');
                resMDNF = SplitEquation(resMDNF);
                strMDNF = PrintMDNF(resMDNF);
                arr = resMDNF;
                k++;
                if (strMDNF != "")
                    prevMDNF = strMDNF;
            }
            return "СКНФ: " + strSKNF + "\n" +
                "СДНФ: " + strSDNF +"\n"
                + "МДНФ: " + prevMDNF;
        }
        static int[,] SpiltVariables(string[] data)
        {
            int[,] arr = new int[data.Length, data[0].Length - 1];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                string sep_data = data[i];
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (j == arr.GetLength(1) - 1)
                        arr[i, j] = (int)sep_data[sep_data.Length - 1] - 48;
                    else
                        arr[i, j] = (int)(sep_data[j]) - 48;
                }
            }
            return arr;
        }
        static string SKNF(int[,] data)
        {
            string res = "";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, data.GetLength(1) - 1] == 0)
                {
                    res += "(";
                    for (int j = 0; j < data.GetLength(1) - 1; j++)
                    {
                        if (j == data.GetLength(1) - 2)
                        {
                            if (data[i, j] == 1)
                                res += ("!" + variables[j]);
                            else
                                res += variables[j];
                        }
                        else
                        {
                            if (data[i, j] == 1)
                                res += ("!" + variables[j] + "v");
                            else
                                res += (variables[j] + "v");
                        }
                    }
                    res += ")";
                }
            }
            return res;
        }
        static string SDNF(int[,] data)
        {
            string res = "";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                if (data[i, data.GetLength(1) - 1] == 1)
                {
                    for (int j = 0; j < data.GetLength(1) - 1; j++)
                    {
                        if (j == data.GetLength(1) - 2)
                        {
                            if (data[i, j] == 0)
                                res += ("!" + variables[j]);
                            else
                                res += variables[j];
                        }
                        else
                        {
                            if (data[i, j] == 0)
                                res += ("!" + variables[j]);
                            else
                                res += variables[j];
                        }
                    }
                    res += " v ";
                }
            }
            return res.Remove(res.Length-3,3);
        }
        static string[] SplitEquation(string[] variables)
        {
            int k = 0;
            for (int i = 0; i < variables.Length; i++)
            {
                if (variables[i] == "")
                    k += 1;
            }
            SortedSet<string> temp = new SortedSet<string>();
            int len = variables.Length - k;
            k = 0;
            for (int i = 0; i < len; i++)
            {
                if (variables[k] == "")
                    --i;
                else
                    temp.Add(variables[k]);
                k++;
            }
            return temp.ToArray<string>();
        }
        static string[,] SepVar(string[] variables, int count)
        {
            string[,] res = new string[variables.Length, count];
            string temp = "";
            for (int i = 0; i < variables.Length; i++)
            {
                int j = 0;
                int column = 0;
                for (; j < variables[i].Length; j++)
                {
                    if (variables[i][j] == '!')
                        temp += variables[i][j];
                    else
                    {
                        temp += variables[i][j];
                        res[i, column] = temp;
                        column++;
                        temp = "";
                    }
                }
            }
            return res;
        }
        static string MDNF(string[,] data)
        {
            Dictionary<string, string> pairs = new Dictionary<string, string>();
            pairs.Add("a", "!a");
            pairs.Add("b", "!b");
            pairs.Add("c", "!c");
            pairs.Add("d", "!d");
            pairs.Add("e", "!e");
            pairs.Add("!a", "a");
            pairs.Add("!b", "b");
            pairs.Add("!c", "c");
            pairs.Add("!d", "d");
            pairs.Add("!e", "e");

            int countDiff = 1;
            string res = "";
            int remIndex = 0;
            for (int i = 0; i < data.GetLength(0) - 1; i++) 
            {
                for (int j = 1; j < data.GetLength(0); j++)
                {
                    int k = 0, k2 = 0;
                    for (int b = 0; b < data.GetLength(1); b++)
                    {
                        for (int c = 0; c < data.GetLength(1); c++)
                        {
                            if (data[i, b] != data[j, c])
                            {
                                k++;
                                if (pairs[data[i, b]] == data[j, c])
                                {
                                    k2++;
                                    remIndex = b;
                                }
                            }
                        }
                    }
                    if (k2 == countDiff && k == (Math.Pow(2,data.GetLength(1))-1))
                    {
                        for (int iter = 0; iter < data.GetLength(1); iter++)
                        {
                            if (iter != remIndex)
                                res += data[i, iter];
                        }
                    }
                    res += " v ";
                }
            }
            return res;
        }
        static string PrintMDNF(string[] data)
        {
            string res = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (i != data.Length - 1)
                    res += data[i] + " v ";
                else
                    res += data[i];
            }
            return res;
        }
    }
}
