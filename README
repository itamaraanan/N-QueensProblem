# nQueens Problem

## Introduction

The nQueens problem is a classic computer science problem that involves placing `n` queens on an `n x n` chessboard such that no two queens threaten each other. This means that no two queens can be in the same row, column, or diagonal.

## Solution Explanation

This solution is implemented in C# and uses a backtracking approach to solve the nQueens problem. The main idea is to place a queen in a row and then recursively attempt to place queens in subsequent rows, backtracking whenever a conflict is detected.

### Key Functions

1. **SolveBoard(char[,] board, int row)**:
   - This function attempts to place queens on the board starting from the given row.
   - If all queens are placed successfully, it returns `true`.
   - It iterates through each column in the current row, checks if placing a queen there is safe, and then recursively attempts to place queens in the next row.
   - If placing a queen in the current column leads to a solution, it returns `true`; otherwise, it backtracks by removing the queen and trying the next column.

2. **isSafe(char[,] board, int row, int col)**:
   - This function checks if placing a queen at the given row and column is safe.
   - It checks for conflicts in the same row, same column, and both diagonals.
   - If no conflicts are found, it returns `true`; otherwise, it returns `false`.

3. **CreateBoard(int N)**:
   - This function initializes an `N x N` chessboard with all positions set to `'.'`.

## How to Run

1. Copy the code into a C# file (e.g., `Program.cs`).
2. Compile the code using a C# compiler (e.g., `csc Program.cs`).
3. Run the compiled program (e.g., `./Program`).

## Conclusion

This implementation demonstrates a backtracking approach to solve the nQueens problem. By carefully placing queens and backtracking when conflicts arise, the solution efficiently finds a valid configuration for the given board size.
