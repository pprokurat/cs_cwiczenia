﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj parametry w formacie: -res=poziomxpion -inputdir=sciezka -outputdir=sciezka:\n");
            string input;
            input = Console.ReadLine();
            Console.WriteLine("\n");

            string[] inputArray = new string[3];
                inputArray = input.Split(' ');

            string[] parameters = new string[4];

            for(int i=0; i<=2; i++)
            {
                string sub = inputArray[i].Substring(inputArray[i].IndexOf("=")+1, inputArray[i].Length-(inputArray[i].IndexOf("=")+1));
                if (i == 0)
                {
                    string sub2 = sub.Substring(0, sub.Length - (sub.IndexOf("x") + 1));
                    parameters[i] = sub2;
                    string sub3 = sub.Substring(sub.IndexOf("x") + 1, sub.Length - sub2.Length - 1);
                    parameters[i + 1] = sub3;
                }
                else
                {
                    parameters[i + 1] = sub;
                }                
            }
            
            string[] parametersLabels = new string[] { "szerokosc", "wysokosc", "katalog wejsciowy", "katalog wyjsciowy" };

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(parametersLabels[i] + ": " + parameters[i]);
            }

            string[] filePaths = Directory.GetFiles(@parameters[2], "*.jpg");
            string[] out_filePaths = new String[filePaths.Length];

            for (int i = 0; i < filePaths.Length; i++)
            {
                string sub = filePaths[i].Substring(parameters[2].Length + 1, filePaths[i].Length - (parameters[2].Length +1));
                //Console.WriteLine(i + 1 + " " + sub);
                out_filePaths[i] = parameters[3] + "/" + sub;

                if (File.Exists(out_filePaths[i]) == false)
                {
                    File.Copy(filePaths[i], out_filePaths[i]);
                }
                else
                {
                    int j = 1;
                    string sub2 = sub.Substring(0, sub.Length - (sub.Length - sub.IndexOf(".")));
                    string sub3 = sub.Substring(sub.IndexOf("."), sub.Length - sub.IndexOf("."));
                    while (File.Exists(out_filePaths[i]) == true)
                    {
                        out_filePaths[i] = parameters[3] + "/" + sub2 + "_" + j + sub3;
                        j++;
                    }
                    //Console.WriteLine(out_filePaths[i]);
                    File.Copy(filePaths[i], out_filePaths[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
