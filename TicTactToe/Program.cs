using System.Security.Cryptography.X509Certificates;

namespace TicTactToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var whosTurn = "O";
            var board = new string[9] { "[1]", "[2]", "[3]", "[4]", "[5]", "[6]", "[7]", "[8]", "[9]" };
            WelcomeMessage();
            DisplayBoard(board);
            Turn(whosTurn, board);
            static void WelcomeMessage() {
                Console.WriteLine("Welcome to Tic Tac Toe!");
            }
            static void DisplayBoard(string[] board)
            {
            for (int i = 0; i < 9; i += 3)
            {
                for (int j = 0; j < 3; j++)
                {
                Console.Write(board[i + j]);
                }
                Console.WriteLine();
            }
            }
            static void Turn(string whosTurn,string[] board)
            {
                Console.Write("Player " + whosTurn + ", Enter a number for your position.");
                var position = Convert.ToInt32(Console.ReadLine()) - 1;
                board[position]="["+whosTurn+"]";
                DisplayBoard(board);
                CheckForWin(board, whosTurn);
            }
            static void CheckForWin(string[] board, string whosTurn)
            {
                Console.WriteLine(board[0] == "[O]" && board[1] == "[O]" && board[2] == "[O]");
                if (board[0] == "[O]" && board[1] == "[O]" && board[2] == "[O]" ||
                    board[3] == "[O]" && board[4] == "[O]" && board[5] == "[O]" ||
                    board[6] == "[O]" && board[7] == "[O]" && board[8] == "[O]" ||
                    board[0] == "[O]" && board[3] == "[O]" && board[6] == "[O]" ||
                    board[1] == "[O]" && board[4] == "[O]" && board[7] == "[O]" ||
                    board[2] == "[O]" && board[5] == "[O]" && board[8] == "[O]" ||
                    board[0] == "[O]" && board[4] == "[O]" && board[8] == "[O]" ||
                    board[6] == "[O]" && board[4] == "[O]" && board[2] == "[O]")
                {
                    Console.WriteLine("Player O has won the game!");
                }
                else if (board[0] == "[X]" && board[1] == "[X]" && board[2] == "[X]" ||
                         board[3] == "[X]" && board[4] == "[X]" && board[5] == "[X]" ||
                         board[6] == "[X]" && board[7] == "[X]" && board[8] == "[X]" ||
                         board[0] == "[X]" && board[3] == "[X]" && board[6] == "[X]" ||
                         board[1] == "[X]" && board[4] == "[X]" && board[7] == "[X]" ||
                         board[2] == "[X]" && board[5] == "[X]" && board[8] == "[X]" ||
                         board[0] == "[X]" && board[4] == "[X]" && board[8] == "[X]" ||
                         board[6] == "[X]" && board[4] == "[X]" && board[2] == "[X]")
                {
                    Console.WriteLine("Player X has won the game!");
                }
                else
                {
                    if (whosTurn == "X")
                    {
                        whosTurn = "O";
                    }
                    else if (whosTurn == "O")
                    {
                        whosTurn = "X";
                    };
                    Turn(whosTurn, board);
                }
            }
        }
    }
}