﻿//Problem 1. Odd lines
//
//    Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.IO;
using System.Text;

class OddLines
{
    static void Main()
    {
        //Write a program that reads a text file and prints on the console its odd lines.
        string path = @"C:\Users\Ceko\Desktop\test.txt";
        Encoding utf8 = Encoding.GetEncoding("UTF-8");
        Encoding win1251 = Encoding.GetEncoding("Windows-1251");
        try
        {
            StreamReader fileReader = new StreamReader(path, win1251);
            using (fileReader)
            {
                int lineNum = 0;
                string line = fileReader.ReadLine();
                while (line != null)
                {
                    lineNum++;
                    if (lineNum % 2 != 0)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNum, line);
                    }
                    line = fileReader.ReadLine();
                }
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Error!");
        }
    }
}