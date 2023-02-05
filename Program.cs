/*
 * Assignment 1
 * 
 * Purpose: to submit assignment 1
 * Name: Daphne Duong
 * Revision History: created Jan 23 by Daphne
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1Part2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable declaration
            double temperatureF;
            double temperatureC;

            Console.WriteLine("Assignment 1 Part 2");
            Console.WriteLine("Name: Daphne Duong");
            Console.WriteLine("Email: dduong7255@conestogac.on.ca");
            Console.WriteLine("I have a basic programming experience. Asides from what I am learning now with C# and HTML, I self-learned SQL before taking this program.");
            Console.WriteLine();

            //get inputs
            Console.Write("Please enter a tempature in Fahrenheit: ");
            temperatureF = Convert.ToDouble(Console.ReadLine());

            //do calculations
            temperatureC = (temperatureF - 32) * 5 / 9;
            temperatureC = Math.Round(temperatureC, 1);

            //show outputs
            Console.WriteLine($"{temperatureF} degrees Fahrenheit is {temperatureC} degrees Celsius");

            Console.ReadKey();
        }
    }
}
