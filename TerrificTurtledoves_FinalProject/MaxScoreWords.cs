using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// Documentation
// # Name: Jacob Stamper, Grahame Halliburton, Asfia Siddiqui
// # email: stampejp@mail.uc.edu, hallibgl@mail.uc.edu, siddiqaf@mail.uc.edu
// # Assignment Title: Final Project
// # Due Date: 12/10/24
// # Course: IS 3050
// # Semester/Year: Fall 2024
// # Brief Description: This is our final project, allowing users to select which Leet Code problem they wish to solve.
//# Citations: For LeetCode solving: https://chatgpt.com/
// # Anything else that's relevant: N/A

namespace TerrificTurtledoves_FinalProject
{
    /// <summary>
    /// Problem: Maximum Score of Words
    /// Description: Given a list of words, a list of letters, and a scoring array, find the maximum score
    /// that can be achieved by forming valid words using the given letters.
    /// Solution by AI assistance, modified by [Your Name].
    /// </summary>
    public class MaxScore
    {
        public int MaxScoreWords(string[] words, char[] letters, int[] score)
        {
            int[] letterCounts = new int[26];
            foreach (char c in letters)
            {
                letterCounts[c - 'a']++;
            }

            int CalculateWordScore(string word, int[] availableLetters)
            {
                int wordScore = 0;
                int[] tempLetterCounts = new int[26];
                foreach (char c in word)
                {
                    int index = c - 'a';
                    tempLetterCounts[index]++;
                    if (tempLetterCounts[index] > availableLetters[index]) return -1;
                    wordScore += score[index];
                }
                return wordScore;
            }

            int Backtrack(int index, int[] availableLetters)
            {
                if (index == words.Length) return 0;

                int skipWord = Backtrack(index + 1, availableLetters);

                int wordScore = CalculateWordScore(words[index], availableLetters);
                int includeWord = 0;
                if (wordScore != -1)
                {
                    foreach (char c in words[index])
                        availableLetters[c - 'a']--;

                    includeWord = wordScore + Backtrack(index + 1, availableLetters);

                    foreach (char c in words[index])
                        availableLetters[c - 'a']++;
                }

                return Math.Max(skipWord, includeWord);
            }

            return Backtrack(0, letterCounts);
        }
    }
}
