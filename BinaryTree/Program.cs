﻿using System;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            tree tree = new tree();

            Random random = new Random();

            for (var i = 0; i < 35; i++)
            {
                tree.Add(random.Next(0, 100));
            }

            while (true)
            {
                Console.Clear();
                tree.Print(tree.Root);
                Console.WriteLine("-------------------------------------");
                tree.InOrderTraversal(tree.Root);
                Console.WriteLine("Delete node: ");
                
                tree.Delete(Convert.ToInt32(Console.ReadLine()));
                
            }

        }
    }
}
