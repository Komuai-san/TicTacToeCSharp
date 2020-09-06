using System;
using System.Collections.Generic;

namespace C__Practice
{

    public class theBoard
    {
       public Dictionary<int,string> board = new Dictionary<int,string>
       {
            {1, "-"},
            {2, "-"},
            {3, "-"},
            {4, "-"},
            {5, "-"},
            {6, "-"},
            {7, "-"},
            {8, "-"},
            {9, "-"},

        };

        public List<int> beard;
    }
    class Program
    {

        static void Main(string[] args)
        {
            theBoard Mainboard = new theBoard();
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Drawboard(Mainboard.board);
            theGame(Mainboard.board);

            while(true)
            {
                Console.Write("Would you like to play again? ");
                string choice = Console.ReadLine();
                if(choice.Equals("Yes"))
                {   
                    ResetBoard(Mainboard.board);
                    Mainboard.board = new Dictionary<int,string>
                    {
                        {1, "-"},
                        {2, "-"},
                        {3, "-"},
                        {4, "-"},
                        {5, "-"},
                        {6, "-"},
                        {7, "-"},
                        {8, "-"},
                        {9, "-"},
                    };
                    Drawboard(Mainboard.board);
                    theGame(Mainboard.board);
                }

                else if(choice.Equals("No"))
                {
                    Console.WriteLine("Thanks for playing!!");
                    break;
                }

                else
                {
                    Console.WriteLine("That's not a valid choice. Try again");
                }
            }
            



            
        }

        static void ResetBoard(Dictionary<int, string> board)
        {
            board.Clear();
    
        }


        static void theGame(Dictionary<int, string> board)
        {
            while(true)

            {
                if(Defeated(board) == true)
                {
                    Console.WriteLine("You lost!!");
                    break;
                }

                YourTurn(board);

                
                if(Victorious(board) == true)
                {
                    Console.WriteLine("You won!!");
                    break;
                }

                if(GameTied(board) == true)
                {
                    Console.WriteLine("It's a draw!");
                    break;
                }

                Opponent(board);

            }
        }


       


        static bool GameTied(Dictionary<int, string> board)
        {
            bool tied = false;

            if(!board.ContainsValue("-"))
            {
                return tied = true;
            }

            return tied;
        }

        static void Drawboard(Dictionary<int, string> board)
        {
            int counter = 1;

            while(counter <=9)
            {
               Console.Write(board[counter] + " | ");
               
               if(counter % 3 == 0)
               {    
                   Console.WriteLine();
               }

               counter++;
            }
        }

        static void YourTurn(Dictionary<int, string> board)
        {
        
            while(true)
            {
                Console.Write("From the number 1-9, please choose: ");
                string position = Console.ReadLine();
                int thenumba = Convert.ToInt32(position);

                if(board[thenumba] == "X" || board[thenumba] == "O")
                {
                    Console.WriteLine("Please try again!");
                    Console.WriteLine();
                    continue;
                }

                else
                {
                    board[thenumba] = "X";
                    Drawboard(board);
                    break;
        
                }

            }

        }

        static void Opponent(Dictionary<int, string> board)
        {
            while(true)
            {

                Console.Write("Player 2. From the number 1-9, please choose: ");
                string opposition = Console.ReadLine();
                int enemynumba = Convert.ToInt32(opposition);

                if(board[enemynumba] == "X" || board[enemynumba] == "O")
                {
                    Console.WriteLine("Please try again!");
                    Console.WriteLine();
                    continue;
                }

                else
                {
                    board[enemynumba] = "O";
                    Drawboard(board);
                    break;
        
                }

            }
        }



        static bool Defeated(Dictionary<int, string> board)
        {
            bool defeat = false;
            
            if(board[1] == "O" && board[2] == "O" && board[3] == "O")
            {
                defeat = true;
            }

            if(board[4] == "O" && board[5] == "O" && board[6] == "O")
            {
                defeat = true;
            }

            if(board[7] == "O" && board[8] == "O" && board[9] == "O")
            {
                defeat = true;
            }

            if(board[1] == "O" && board[4] == "O" && board[7] == "O")
            {
                defeat = true;
            }

            if(board[2] == "O" && board[5] == "O" && board[8] == "O")
            {
                defeat = true;
            }

            if(board[3] == "O" && board[6] == "O" && board[9] == "O")
            {
                defeat = true;
            }

            if(board[1] == "O" && board[5] == "O" && board[9] == "O")
            {
                defeat = true;
            }

            if(board[3] == "O" && board[5] == "O" && board[7] == "O")
            {
                defeat = true;
            }

            return defeat;
            

        }

        static bool Victorious(Dictionary<int, string> board)
        {
            bool victory = false;
            
            if(board[1] == "X" && board[2] == "X" && board[3] == "X")
            {
                victory = true;
            }

            if(board[4] == "X" && board[5] == "X" && board[6] == "X")
            {
                victory = true;
            }

            if(board[7] == "X" && board[8] == "X" && board[9] == "X")
            {
                victory = true;
            }

            if(board[1] == "X" && board[4] == "X" && board[7] == "X")
            {
                victory = true;
            }

            if(board[2] == "X" && board[5] == "X" && board[8] == "X")
            {
                victory = true;
            }

            if(board[3] == "X" && board[6] == "X" && board[9] == "X")
            {
                victory = true;
            }

            if(board[1] == "X" && board[5] == "X" && board[9] == "X")
            {
                victory = true;
            }

            if(board[3] == "X" && board[5] == "X" && board[7] == "X")
            {
                victory = true;
            }

            return victory;
            

        }






    }
}
