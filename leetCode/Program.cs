

using System.Runtime.InteropServices;

public class Program
{
    public static void printDivider()
    {
        Console.WriteLine("--------------------------------------");
    }

    public static void Question1(int[] inputArray, int target)
    {
        /*
            Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.

            You may assume that each input would have exactly one solution, and you may not use the same element twice.

            You can return the answer in any order.
        */
        Console.WriteLine("Question #1");
        int part1 = -1; // the first answer
        int part2 = -1; // the second answer
        int currentSum = -1; // the sum of the current pair
        //{ 2, 7, 11, 15 }
        for (int i = 0; i < inputArray.Length; i++)
        {
            part1 = inputArray[i];
            for(int j = (i + 1); j < inputArray.Length; j++)
            {
                part2 = inputArray[j];
                currentSum = part1 + part2;
                
                if (currentSum == target)
                    break;
            }
            if (currentSum == target)
                break;
        }
        int[] answerArr = { part1, part2 };
        
        for (int i = 0; i < answerArr.Length; i++)
        {
            Console.WriteLine("Part " + i + ": " + answerArr[i]);
        }


    }
    public static void Question2(int element)
    {
        /*
            Given an integer x, return true if x is a palindrome, and false otherwise. 
        */
        Console.WriteLine("Question #2");

        string elementStr = element.ToString();
        string forward = elementStr;
        string backward = "";
        for(int i = (elementStr.Length - 1); i >= 0; i--)
        {
            char currentChar = elementStr[i];
            backward = backward + currentChar.ToString();
        }
        bool isPalindrome = forward.Equals(backward);
        Console.WriteLine(isPalindrome);
       
    }



    public static void Main()
    {
        string name = "Timothy";

        // Question 1
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        Question1(nums, target);

        printDivider();

        // Question 2
        int element = 120;
        Question2(element);

        printDivider();

        //
        
    }
}
