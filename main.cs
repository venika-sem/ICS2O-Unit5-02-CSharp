// Created by: Venika Sem
// Created on: May 2022
//
// This program accepts user input

using System;

class Program
{
    public static void Main(string[] args)
    {
        int userInteger;
        Console.WriteLine("Input integer (positive or negative):");
        userInteger = int.Parse(Console.ReadLine());
        if (userInteger > -1)
        {
            userInteger = Convert.ToInt32(Console.Read());
            Console.WriteLine("Integer is positive.");
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Integer is negative.");
        }
    }
}