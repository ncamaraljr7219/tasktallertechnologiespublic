using System;
using System.Collections.Generic;

namespace LongestSubstring
{
    class Program
    {
        static int TaskTallerTechnologies(string s)
        {
            int n = s.Length;
            Dictionary<char, int> charIndex = new Dictionary<char, int>();
            int start = 0;
            int maxLength = 0;

            for (int end = 0; end < n; end++)
            {
                if (charIndex.ContainsKey(s[end]) && charIndex[s[end]] >= start)
                {
                    start = charIndex[s[end]] + 1;
                }
                charIndex[s[end]] = end;
                maxLength = Math.Max(maxLength, end - start + 1);
            }

            return maxLength;
        }

        static void Main(string[] args)
        {
            string inputStr = "BBBB";
            Console.WriteLine($"Length of the longest substring for BBBB: {TaskTallerTechnologies(inputStr)}");
            
            inputStr = "ABDEFGABEF";
            Console.WriteLine($"Length of the longest substring for ABDEFGABEF: {TaskTallerTechnologies(inputStr)}");
            
            inputStr = "GEEKSFORGEEKS";
            Console.WriteLine($"Length of the longest substring for GEEKSFORGEEKS: {TaskTallerTechnologies(inputStr)}");
            
            Console.Write("Enter a string: ");
            inputStr = Console.ReadLine();
            Console.WriteLine($"Length of the longest substring inserted by User: {TaskTallerTechnologies(inputStr)}");
        }
    }
}
