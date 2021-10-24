using System;
using System.Collections.Generic;
using System.IO;

namespace BinarySearchProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Algorithm Programs!");
           
                Console.WriteLine("1.Binary Search the word from wordlist");
                Console.WriteLine("Enter the option");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    
                    case 1:
                        string txtpath = File.ReadAllText(@"C:\Users\Lenovo\Desktop\Algorithm Programs  problems\BinarySearchProblem\BinarySearchProblem\Algo.txt");
                        List<string> words = new List<string>(txtpath.Split());
                        words.Sort();
                        BinarySearch.BinarySearchWord(words);
                        break;
                    default:
                        Console.WriteLine("Enter the valid option!");
                        break;

                }
                Console.WriteLine("\nDo you want to continue");
            }
        }
    }

