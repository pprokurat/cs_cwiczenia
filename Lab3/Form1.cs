﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private string path = "E:/dokumenty_studia/zaawansowane_techniki_programowania_C#/ćwiczenia/cs_cwiczenia";

        public Form1()
        {
            InitializeComponent();
        }

        private void selectPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            fbd.Description = "Wybierz folder";
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                MessageBox.Show("Wybrany folder: \n" + fbd.SelectedPath);
            path = fbd.SelectedPath;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = System.IO.Directory.GetFiles(path, "*.sln");
                String[] vcproj_array = new String[100];
                String[] outputFiles_array = new String[100];

                for (int i = 0; i < files.Length; i++)
                {
                    Console.WriteLine(files[i]);
                    if (i >= files.Length)
                        break;
                }

                for (int i = 0; i < files.Length; i++)
                {
                    
                    System.IO.StreamReader file = new System.IO.StreamReader(files[i]);
                    string line;

                    while ((line = file.ReadLine()) != null)
                    {
                        if (line.Contains("csproj"))
                        {
                            string sub = line.Substring(53,line.Length-95);
                            //Console.WriteLine(sub);
                            string sub1 = sub.Substring(0, sub.IndexOf("\","));
                            Console.WriteLine(sub1);
                            vcproj_array[i] = path + "/" + sub1 + "/" + sub1 + ".csproj";
                            Console.WriteLine(vcproj_array[i]);
                        }
                    }

                    int k = 0;
                    for (int j = 0; j < vcproj_array.Length; j++)
                    {
                        System.IO.StreamReader file2 = new System.IO.StreamReader(vcproj_array[j]);

                        while ((line = file2.ReadLine()) != null)
                        {                            
                            if (line.Contains("Compile Include") || line.Contains("EmbeddedResource Include") || line.Contains("None Include"))
                            {
                                string sub = line;
                                outputFiles_array[k] = sub;
                                Console.WriteLine(outputFiles_array[k]);
                            }
                            k++;
                        }




                        //if (j >= vcproj_array.Length)
                        //    break;
                    }

                   

                        if (i >= files.Length)
                        break;
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
