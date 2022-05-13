﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static UC3_Search_63_BT.MapNode;

namespace UC3_Search_63_BT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Binary Search Tree Operations------");
            Console.WriteLine("1.Insertion.");
            Console.WriteLine("2.Insert More Elements");
            Console.WriteLine("3.Search the element");
            Console.WriteLine("Enter the option!!!");
            int num = Convert.ToInt32(Console.ReadLine());
            BST<int> binarySearchTree = new BST<int>(56);
            switch (num)
            {
                case 1:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Display();
                    break;
                case 2:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    binarySearchTree.GetSize();
                    break;
                case 3:
                    binarySearchTree.Insert(30);
                    binarySearchTree.Insert(70);
                    binarySearchTree.Insert(22);
                    binarySearchTree.Insert(40);
                    binarySearchTree.Insert(11);
                    binarySearchTree.Insert(3);
                    binarySearchTree.Insert(16);
                    binarySearchTree.Insert(60);
                    binarySearchTree.Insert(95);
                    binarySearchTree.Insert(65);
                    binarySearchTree.Insert(63);
                    binarySearchTree.Insert(67);
                    binarySearchTree.Display();
                    bool result = binarySearchTree.IfExists(63, binarySearchTree);
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("Enter valid option!!!");
                    break;
            }
            Console.ReadLine();
        }
    }
}

