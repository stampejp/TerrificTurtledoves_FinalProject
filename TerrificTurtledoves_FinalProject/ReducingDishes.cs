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
    public class Dishes
    {
        public int MaxSatisfaction(int[] satisfaction)
        {
            // Sort the array in descending order
            Array.Sort(satisfaction);
            Array.Reverse(satisfaction);

            int total = 0; // Total like-time coefficient
            int runningSum = 0; // Running sum of satisfaction values

            foreach (int dish in satisfaction)
            {
                // Check if adding this dish increases the total
                if (runningSum + dish > 0)
                {
                    runningSum += dish;
                    total += runningSum;
                }
                else
                {
                    // Stop if adding this dish reduces the total
                    break;
                }
            }

            return total;
        }
    }
}