using System;
using System.Collections.Generic;
namespace Assignment_2
{
   class Program
   {
       static void Main(string[] args)
       {
           // Question 1: Find Missing Numbers in Array
           Console.WriteLine("Question 1:");
           int[] nums1 = { 4, 3, 2, 7, 8, 2, 3, 1 };
           IList<int> missingNumbers = Question1.MissingNumbers.FindMissingNumbers(nums1);
           Console.WriteLine(string.Join(",", missingNumbers));
           // Question 2: Sort Array by Parity
           Console.WriteLine("Question 2:");
           int[] nums2 = { 3, 1, 2, 4 };
           int[] sortedArray = Question2.SortArray.SortArrayByParity(nums2);
           Console.WriteLine(string.Join(",", sortedArray));
           // Question 3: Two Sum
           Console.WriteLine("Question 3:");
           int[] nums3 = { 2, 7, 11, 15 };
           int target = 9;
           int[] indices = Question3.TwoSum(nums3, target);
           Console.WriteLine(string.Join(",", indices));
           // Question 4: Find Maximum Product of Three Numbers
           Console.WriteLine("Question 4:");
           int[] nums4 = { 1, 2, 3, 4 };
           int maxProduct = Question4.MaximumProduct(nums4);
           Console.WriteLine(maxProduct);
           // Question 5: Decimal to Binary Conversion
           Console.WriteLine("Question 5:");
           int decimalNumber = 42;
           string binary = Question5.DecimalToBinary(decimalNumber);
           Console.WriteLine(binary);
           // Question 6: Find Minimum in Rotated Sorted Array
           Console.WriteLine("Question 6:");
           int[] nums5 = { 3, 4, 5, 1, 2 };
           int minElement = Question6.FindMin(nums5);
           Console.WriteLine(minElement);
           // Question 7: Palindrome Number
           Console.WriteLine("Question 7:");
           int palindromeNumber = 121;
           bool isPalindrome = Question7.IsPalindrome(palindromeNumber);
           Console.WriteLine(isPalindrome);
           // Question 8: Fibonacci Number
           Console.WriteLine("Question 8:");
           int n = 4;
           int fibonacciNumber = Question8.Fibonacci(n);
           Console.WriteLine(fibonacciNumber);
       }
   }
   // Question 1: Find Missing Numbers in Array
   public static class Question1
   {
       public static class MissingNumbers
       {
           public static IList<int> FindMissingNumbers(int[] nums)
           {
               var missing = new List<int>();  // List to hold numbers that are missing
               var seen = new HashSet<int>(nums);  // Track all elements from input array
               int range = nums.Length;
               for (int i = 1; i <= n; i++)  // Check every number from 1 to n
               {
                   if (!seen.Contains(i))
                   {
                       missing.Add(i);   // Add number to result if it's not in the original array
                   }
               }
               return missing;
           }
       }
   }
   // Question 2: Sort Array by Parity
   public static class Question2
{
    public static class SortArray
    {
        public static int[] SortArrayByParity(int[] nums)
        {
            int i = 0, j = nums.Length - 1;

            // Use two pointers to rearrange the array
            while (i < j)
            {
                // If left is odd and right is even, swap
                if (nums[i] % 2 > nums[j] % 2)
                {
                    (nums[i], nums[j]) = (nums[j], nums[i]);
                }

                // Move pointers accordingly
                if (nums[i] % 2 == 0) i++;
                if (nums[j] % 2 == 1) j--;
            }

            return nums; // Return the sorted array
        }
    }
}
   // Question 3: Two Sum
   public static class Question3
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var indexMap = new Dictionary<int, int>(); // Stores value-to-index mapping

        for (int i = 0; i < nums.Length; i++)
        {
            int required = target - nums[i]; // Calculate the complement

            if (indexMap.ContainsKey(required))
            {
                return new int[] { indexMap[required], i }; // Return indices if pair found
            }

            indexMap[nums[i]] = i; // Store current number and its index
        }

        return Array.Empty<int>(); // Return empty if no valid pair
    }
}
   // Question 4: Find Maximum Product of Three Numbers
   public static class Question4
{
    public static int MaximumProduct(int[] nums)
    {
        Array.Sort(nums); // Sort to find extremes
        int len = nums.Length;

        int product1 = nums[len - 1] * nums[len - 2] * nums[len - 3]; // Top 3 largest numbers
        int product2 = nums[0] * nums[1] * nums[len - 1]; // 2 smallest (possibly negative) * largest

        return Math.Max(product1, product2); // Return the maximum possible product
    }
}
   // Question 5: Decimal to Binary Conversion
   public static class Question5
{
    public static string DecimalToBinary(int num)
    {
        if (num == 0) return "0"; // Edge case: binary of 0 is "0"

        var digits = new Stack<int>(); // Stack to hold binary digits

        while (num > 0)
        {
            digits.Push(num % 2); // Push remainder to stack (0 or 1)
            num /= 2; // Divide by 2 for next digit
        }

        return string.Concat(digits); // Combine stack elements into final binary string
    }
}

   // Question 6: Find Minimum in Rotated Sorted Array
   public static class Question6
{
    public static int FindMin(int[] nums)
    {
        int low = 0, high = nums.Length - 1;

        // Binary search to locate minimum element
        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (nums[mid] > nums[high])
            {
                low = mid + 1; // Minimum lies to the right
            }
            else
            {
                high = mid; // Minimum lies to the left (including mid)
            }
        }

        return nums[low]; // Final low index holds the minimum
    }
}
   // Question 7: Palindrome Number
   public static class Question7
{
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false; // Negative numbers can't be palindromes

        int original = x;
        int reverse = 0;

        // Reverse the number
        while (x != 0)
        {
            reverse = reverse * 10 + x % 10;
            x /= 10;
        }

        return original == reverse; // Compare reversed number with original
    }
}
   // Question 8: Fibonacci Number
   // Question 8: Fibonacci Number
public static class Question8
{
    public static int Fibonacci(int n)
    {
        if (n < 2) return n; // Return 0 for n=0, 1 for n=1

        int prev = 0, curr = 1;

        // Iteratively compute Fibonacci numbers up to n
        for (int i = 2; i <= n; i++)
        {
            int next = prev + curr;
            prev = curr;
            curr = next;
        }

        return curr; // Return nth Fibonacci number
    }
}
