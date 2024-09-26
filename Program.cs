using System;
using System.Collections.Concurrent;

class Program {
    public static bool SolveBoard(char[,] board, int row ) {
        //stop if the row reaches N
       if(row == board.GetLength(0)){
         return true; // All queens are placed
        }


        for (int col = 0; col < board.GetLength(1); col++) //trying all the possible opptions in the row
        {
            if(isSafe(board, row, col)){
                board[row,col] = 'Q'; 

                if(SolveBoard(board, row+1)){// if at the end this path came to be the solution
                    return true;
                }

                board[row,col] = '.'; // if this path wasnt the solution, then bracktrack;
            } 

        }
        return false; //no valid options in this row
            
        }



    public static bool isSafe(char [,] board,  int row, int col){

        
        for(int i =0; i< board.GetLength(0); i++){

            if(board[row, i] == 'Q' || board[i,col] == 'Q'){
                
                return false;
            }
        }
        

        for (int i = 0; i < board.GetLength(0); i++) {
            if (i != row && col + (i - row) >= 0 && col + (i - row) < board.GetLength(0)) {
                if (board[i, col + (i - row)] == 'Q') {
                    return false; // Found a queen on the right diagonal
                }
            }
        }
        

        // Check the left diagonal (top-right to bottom-left)
        for (int i = 0; i < board.GetLength(0); i++) {
            if (i != row && col - (i - row) >= 0 && col - (i - row) < board.GetLength(0)) {
                if (board[i, col - (i - row)] == 'Q') {
                    return false; // Found a queen on the left diagonal
                }
            }
        }
        return true;

    }





    public static char[,] CreateBoard(int N) {
        char[,] board = new char[N, N];
        for (int i = 0; i < board.GetLength(0); i++) {
            for (int j = 0; j < board.GetLength(1); j++) {
                board[i, j] = '.';
            }
        }
        return board;
    }

    public static void PrintBoard(char[,] board) {
        for (int i = 0; i < board.GetLength(0); i++) {
            for (int j = 0; j < board.GetLength(1); j++) {
                Console.Write(board[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public static void Main(string[] args) {
        Console.WriteLine("===========================================");
        Console.WriteLine("Please enter the size of the board you want:");
        int N = Convert.ToInt32(Console.ReadLine());
        char[,] board = CreateBoard(N);

        bool isPossible = SolveBoard(board, 0);
        if(isPossible){
            PrintBoard(board);
        }
        else{
            System.Console.WriteLine("no solution was found");
        }
        
    }

}
