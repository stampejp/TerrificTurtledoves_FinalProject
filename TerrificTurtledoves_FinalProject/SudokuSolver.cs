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
    /// Problem: Sudoku Solver
    /// Description: Solve a given Sudoku puzzle by filling in empty cells, ensuring that each row,
    /// column, and 3x3 grid contains numbers 1-9 without repetition.
    /// Solution by AI assistance, modified by [Your Name].
    /// </summary>
    public class SudokuSolver
    {
        public void SolveSudoku(char[][] board)
        {
            Solve(board);
        }

        private bool Solve(char[][] board)
        {
            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (board[row][col] == '.')
                    {
                        for (char num = '1'; num <= '9'; num++)
                        {
                            if (IsValid(board, row, col, num))
                            {
                                board[row][col] = num;

                                if (Solve(board)) return true;

                                board[row][col] = '.';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        private bool IsValid(char[][] board, int row, int col, char num)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row][i] == num || board[i][col] == num ||
                    board[3 * (row / 3) + i / 3][3 * (col / 3) + i % 3] == num)
                    return false;
            }
            return true;
        }
    }
}