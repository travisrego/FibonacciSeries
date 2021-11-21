using System;
using System.IO;
using System.Threading;
using Figgle;

namespace FibonacciSeries
{
    internal static class Program
    {
        private static decimal _number1;
        private static decimal _number2 = 1;
        private static decimal _x;
        private static FileStream _fontStream; 

        private static void Main()
        {
            WindowUtility.MoveWindowToCenter();
            Console.ForegroundColor = ConsoleColor.Blue;
            _fontStream = File.OpenRead(@"D:\Documents\Projects\code\Practice\Learning C Sharp\FibonacciSeries\assets\Ogre.flf");
            var font = FiggleFontParser.Parse(_fontStream);
            var text = font.Render("Fibonacci  Series");
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Enter the number of elements: ");
            _x = Convert.ToDecimal(Console.ReadLine()); // 79228162514264337593543950335
            var xIsSmall = false;
            while (!xIsSmall)
            {
                if (_x <= 137)
                {
                    Console.Clear();

                    Console.Write("Loading...");
                    Thread.Sleep(1500);

                    Console.Clear();
            
                    Console.WriteLine(string.Empty);
                    Console.WriteLine(string.Empty);
            
                    Console.WriteLine("This is {0} elements of the Fibonacci Series", _x);
                    Console.WriteLine(string.Empty);
            
                    Console.Write(_number1 + ", " + _number2);
                    for (decimal i = 0; i <= _x; i++)
                    {
                        decimal number3 = _number1 + _number2;
                        Console.Write(", {0}", number3);
                        _number1 = _number2; // 1 
                        _number2 = number3; // 1
                    }
                    
                    RestartConsole();
                    xIsSmall = true; 
                }
                else
                {
                    Console.Clear();
                    WindowUtility.MoveWindowToCenter();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    _fontStream = File.OpenRead(@"D:\Documents\Projects\code\Practice\Learning C Sharp\FibonacciSeries\assets\Ogre.flf");
                    font = FiggleFontParser.Parse(_fontStream);
                    text = font.Render("Fibonacci  Series");
                    Console.WriteLine(text);
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Enter the number of elements: ");
                    Console.ForegroundColor = ConsoleColor.Red; 
                    Console.WriteLine("Your number is too big try a number equal or less than 137");
                    Console.ForegroundColor = ConsoleColor.Gray;
                    _x = Convert.ToDecimal(Console.ReadLine()); // 79228162514264337593543950335
                }
            }
        }

        private static void RestartConsole()
        {
            Console.WriteLine(string.Empty);
            Console.WriteLine(string.Empty);
            Console.WriteLine("Do you want to restart console?");
            Console.WriteLine("Type 1 or Y - Yes");
            Console.Write("Type 2 or N - No");
            Console.WriteLine(string.Empty);
            string input = Console.ReadLine()?.ToUpper();
            while (true)
            {
                _number1 = 0;
                _number2 = 1;
                switch (input)
                {
                    case "1" or "Y":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Restarting...");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Thread.Sleep(1000);
                        System.Diagnostics.Process.Start("FibonacciSeries.exe");
                        Console.Clear();
                        Environment.Exit(0);
                        return;
                    case "2" or "N":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Exiting console...");
                        Thread.Sleep(1000);
                        Environment.Exit(0);
                        return;
                }

                Console.Clear();
            
                Console.WriteLine(string.Empty);
                Console.WriteLine(string.Empty);
                Console.WriteLine("This is {0} elements of the Fibonacci Series", _x);
                Console.WriteLine(string.Empty);
                Console.Write(_number1 + ", " + _number2);
                for (decimal i = 0; i <= _x; i++)
                {
                    decimal number3 = _number1 + _number2;
                    Console.Write(", {0}", number3);
                    _number1 = _number2; // 1 
                    _number2 = number3; // 1
                }
                Console.WriteLine(string.Empty);
                Console.WriteLine(string.Empty);
                Console.WriteLine("Do you want to restart console?");
                
                Console.WriteLine("Type 1 or Y - Yes");
                Console.Write("Type 2 or N - No");
                Console.WriteLine(string.Empty);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter a valid option!");
                Console.ForegroundColor = ConsoleColor.Gray;
                input = Console.ReadLine()?.ToUpper();
                Thread.Sleep(500);
            }
        }
    }
}