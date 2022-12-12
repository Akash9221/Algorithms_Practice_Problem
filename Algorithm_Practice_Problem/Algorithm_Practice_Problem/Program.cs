using System;

namespace Algorithm_Practice_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AP1_BinarySearch
            //Console.WriteLine("DataStructure Algorithm Problems");
            //BinarySearch bs = new BinarySearch();
            //string[] arr = { "apple", "ball", "cat", "dog", "egg", "fish" };
            //Console.WriteLine("Please enter a string to be searched :");
            //string key = Console.ReadLine();
            //int result = bs.Binary_Search(arr, key);
            //if (result == -1)
            //    Console.WriteLine("Element not present");
            //else
            //    Console.WriteLine("Element found at " + "index " + result);
            //Console.WriteLine(result);
            //Console.ReadLine();


            //AP2
            //Accept Two String From Use
            Console.WriteLine("Enter The First Word");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter The Second Word");
            string word2 = Console.ReadLine();
            AnagramDetection.Anagram(word1, word2);//Pass Values To Function
            Console.ReadLine();

            //AP3_Bubble_Sort
            //Bubble_Sort bubbleSort = new Bubble_Sort();
            //bubbleSort.BubbleSort();
            //Console.ReadLine();
        }
    }
}
