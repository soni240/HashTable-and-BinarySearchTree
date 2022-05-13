﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UC3_Remove_Word.MapNode;

namespace UC3_Remove_Word
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("------Hashing Problem------");
            Console.WriteLine("-----USE CASE 1-To find frequency of words in a sentence---- ");
            Console.WriteLine("-----USE CASE 2-To find frequency of words in a paragraph---- ");
            Console.WriteLine("----USE CASE3-Remove the word in a paragraph---");
            Console.WriteLine("Enter the option");
            int num = Convert.ToInt32(Console.ReadLine());
            MapNode<string, int> myMapNode = new MapNode<string, int>(6);
            switch (num)
            {
                case 1:
                    string[] words = { "to", "be", "or", "not", "to", "be" };
                    int count = 1;
                    foreach (string i in words)
                    {
                        count = myMapNode.CheckHash(i);
                        if (count > 1)
                        {
                            myMapNode.Add(i, count);
                        }
                        else
                        {
                            myMapNode.Add(i, 1);
                        }
                    }

                    IEnumerable<string> uniqueItems = words.Distinct<string>();
                    foreach (var i in uniqueItems)
                    {
                        myMapNode.Display(i);
                    }
                    break;
                case 2:

                    MapNode<string, int> myMap = new MapNode<string, int>(10);
                    string[] Paragraph;
                    string input = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    Paragraph = input.Split(' ');
                    //Given string input

                    int counts = 1;
                    foreach (string i in Paragraph)
                    {
                        counts = myMap.CheckHash(i);
                        if (counts > 1)
                        {
                            myMap.Add(i, counts);
                        }
                        else
                        {
                            myMap.Add(i, 1);
                        }
                    }
                    Console.WriteLine("\n---------Frequency of words in paragraph---------\n");
                    IEnumerable<string> distinct = Paragraph.Distinct<string>();
                    foreach (var i in distinct)
                    {
                        myMap.Display(i);
                    }

                    break;
                case 3:
                    MapNode<string, int> myMap1 = new MapNode<string, int>(10);
                    string[] paragraph1;
                    string input1 = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                    paragraph1 = input1.Split(' ');

                    int count1 = 1;
                    foreach (string i in paragraph1)
                    {
                        counts = myMap1.CheckHash(i);
                        if (count1 > 1)
                        {
                            myMap1.Add(i, counts);
                        }
                        else
                        {
                            myMap1.Add(i, 1);
                        }
                    }
                    IEnumerable<string> unique = paragraph1.Distinct<string>();
                    Console.WriteLine("\nEnter the word which you want to remove in paragraph");
                    string removeWord = Console.ReadLine();
                    myMap1.Remove(removeWord);
                    foreach (var i in unique)
                    {
                        myMap1.Display(i);
                    }
                    break;
                default:
                    Console.WriteLine("Enter the valid option!!!");
                    break;

            }

            Console.ReadLine();
        }
    }
}

