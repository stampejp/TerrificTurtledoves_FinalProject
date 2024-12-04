using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
    public partial class index : Page
    {
        protected void btnSolve_Click(object sender, EventArgs e)
        {
            string selectedProblem = problemSelect.SelectedValue;
            descriptionPanel.Controls.Clear(); // Clear existing content
            outputPanel.Controls.Clear(); // Clear output panel

            if (selectedProblem == "MaxScoreWords")
            {
                // Problem description for MaxScoreWords
                descriptionPanel.Controls.Add(new Literal
                {
                    Text = @"
                Given a list of words, list of  single letters (might be repeating) and score of every character.<br/>
                Return the maximum score of any valid set of words formed by using the given letters (words[i] cannot be used two or more times).<br/>
                It is not necessary to use all characters in letters and each letter can only be used once. Score of letters 'a', 'b', 'c', ... ,'z' is given by score[0], score[1], ... , score[25] respectively.<br/><br/>
                <b>Example 1:</b><br/>
                Input: words = [""dog"",""cat"",""dad"",""good""], letters = [""a"",""a"",""c"",""d"",""d"",""d"",""g"",""o"",""o""], score = [1,0,9,5,0,0,3,0,0,0,0,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0] <br/>
                Output: 23<br/>
                Explanation:
                Score  a=1, c=9, d=5, g=3, o=2
                Given letters, we can form the words ""dad"" (5+1+5) and ""good"" (3+2+2+5) with a score of 23.<br/>
                Words ""dad"" and ""dog"" only get a score of 21."
                });

                MaxScore solution = new MaxScore();
                string[] words = { "dog", "cat", "dad", "good" };
                char[] letters = { 'a', 'a', 'c', 'd', 'd', 'd', 'g', 'o', 'o' };
                int[] score = { 1, 0, 9, 5, 0, 0, 3, 0, 0, 0, 0, 0, 0, 0, 2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                int result = solution.MaxScoreWords(words, letters, score);
                outputPanel.Controls.Add(new Literal { Text = $"Max Score: {result}" });
            }
            else if (selectedProblem == "SudokuSolver")
            {
                // Problem description for SudokuSolver
                descriptionPanel.Controls.Add(new Literal
                {
                    Text = @"
                    Write a program to solve a Sudoku puzzle by filling the empty cells.<br/>
                    A sudoku solution must satisfy all of the following rules:<br/>
                    1. Each of the digits 1-9 must occur exactly once in each row.<br/>
                    2. Each of the digits 1-9 must occur exactly once in each column.<br/>
                    3. Each of the digits 1-9 must occur exactly once in each of the 9 3x3 sub-boxes of the grid.<br/>
                    The '.' character indicates empty cells.<br/><br/>
                    <b>Example 1:</b><br/>
                    Input: board = <br/>
                    [[‘5’,’3’,’.’,’.’,’7’,’.’,’.’,’.’,’.’],<br/>
                    [‘6’,’.’,’.’,’1’,’9’,’5’,’.’,’.’,’.’],<br/>
                    [‘.’,’9’,’8’,’.’,’.’,’.’,’.’,’6’,’.’],<br/>
                    [‘8’,’.’,’.’,’.’,’6’,’.’,’.’,’.’,’3’],<br/>
                    [‘4’,’.’,’.’,’8’,’.’,’3’,’.’,’.’,’1’],<br/>
                    [‘7’,’.’,’.’,’.’,’2’,’.’,’.’,’.’,’6’],<br/>
                    [‘.’,’6’,’.’,’.’,’.’,’.’,’2’,’8’,’.’],<br/>
                    [‘.’,’.’,’.’,’4’,’1’,’9’,’.’,’.’,’5’],<br/>
                    [‘.’,’.’,’.’,’.’,’8’,’.’,’.’,’7’,’9’]]<br/>
                    Output: <br/>
                    [[‘5’,’3’,’4’,’6’,’7’,’8’,’9’,’1’,’2’],<br/>
                    [‘6’,’7’,’2’,’1’,’9’,’5’,’3’,’4’,’8’],<br/>
                    [‘1’,’9’,’8’,’3’,’4’,’2’,’5’,’6’,’7’],<br/>
                    [‘8’,’5’,’9’,’7’,’6’,’1’,’4’,’2’,’3’],<br/>
                    [‘4’,’2’,’6’,’8’,’5’,’3’,’7’,’9’,’1’],<br/>
                    [‘7’,’1’,’3’,’9’,’2’,’4’,’8’,’5’,’6’],<br/>
                    [‘9’,’6’,’1’,’5’,’3’,’7’,’2’,’8’,’4’],<br/>
                    [‘2’,’8’,’7’,’4’,’1’,’9’,’6’,’3’,’5’],<br/>
                    [‘3’,’4’,’5’,’2’,’8’,’6’,’1’,’7’,’9’]]<br/>
                    Explanation: The input board is shown above and the only valid solution is shown below:"
                });

                SudokuSolver solver = new SudokuSolver();
                char[][] board = {
            new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
            new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
            new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
            new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
            new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
            new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
            new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
            new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
            new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
        };
                solver.SolveSudoku(board);
                string solvedBoard = string.Join("<br />", Array.ConvertAll(board, row => string.Join(" ", row)));
                outputPanel.Controls.Add(new Literal { Text = $"Solved Board:<br />{solvedBoard}" });
            }
            else if (selectedProblem == "ReducingDishes")
            {
                // Problem description for ReducingDishes
                descriptionPanel.Controls.Add(new Literal
                {
                    Text = @"
                A chef has collected data on the satisfaction level of his n dishes. Chef can cook any dish in 1 unit of time.<br/>
                Like-time coefficient of a dish is defined as the time taken to cook that dish including previous dishes multiplied by its satisfaction level i.e. time[i] * satisfaction[i].<br/>
                Return the maximum sum of like-time coefficient that the chef can obtain after preparing some amount of dishes.<br/>
                Dishes can be prepared in any order and the chef can discard some dishes to get this maximum value.<br/><br/>
                <b>Example 1:</b><br/>
                Input: satisfaction = [-1,-8,0,5,-9]<br/>
                Output: 14<br/>
                Explanation: After removing the second and last dish, the maximum total like-time coefficient will be equal to (-1*1 + 0*2 + 5*3 = 14).<br/>
                Each dish is prepared in one unit of time."
                });

                Dishes solver = new Dishes();
                int[] satisfaction = { -1, -8, 0, 5, -9 }; // Example input
                int result = solver.MaxSatisfaction(satisfaction);
                outputPanel.Controls.Add(new Literal { Text = $"Max Satisfaction: {result}" });
            }
        }
    }
    }
