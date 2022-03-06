using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Grid game = new Grid();
            game.createGrid();
            game.displayGrid();
            int choice1, choice2, next = 0;
            int draw = 0;
            while (true)
            {
                next = 0;
                while (true)
                {
                    if (draw < 9)
                        Console.Write("\nPlayer-1 ->Enter box number to grab it: ");
                    else
                    {
                        Console.WriteLine("ROUND DRAW!!!.\nPlease press any key to restart!!");
                        Console.ReadKey();
                        Console.Clear();
                        game.createGrid();
                        game.displayGrid();
                        draw = 0;
                        break;
                    }
                    bool valid = int.TryParse(Console.ReadLine(), out choice1);
                    if (valid && choice1 > 0 && choice1 <= 9)
                    {
                        int check = game.playChance(1, choice1);
                        switch (check)
                        {
                            case 1:
                                Console.WriteLine("It has already been grabbed! Select any other.");
                                break;
                            case 2:
                                draw++;
                                next = 1;
                                Console.Clear();
                                game.displayGrid();
                                break;
                            case 3:
                                Console.WriteLine("\nHurray!! Player 1 won the game.\nPlease press any key to restart!!");
                                Console.ReadKey();
                                Console.Clear();
                                game.createGrid();
                                game.displayGrid();
                                draw = 0;
                                break;
                        }
                        if (next == 1)
                            break;
                    }
                    else
                        Console.WriteLine("Please enter valid box number!");
                }
                next = 0;
                while (true)
                {
                    if(draw<9)
                        Console.Write("\nPlayer-2 ->Enter box number to grab it: ");
                    else
                    {
                        Console.WriteLine("Round DRAW!!!.\nPlease press any key to restart!!");
                        Console.ReadKey();
                        Console.Clear();
                        game.createGrid();
                        game.displayGrid();
                        draw = 0;
                        break;
                    }

                    bool valid = int.TryParse(Console.ReadLine(), out choice2);
                    if (valid && choice2 > 0 && choice2 <= 9)
                    {
                        int check = game.playChance(2, choice2);
                        switch (check)
                        {
                            case 1:
                                Console.WriteLine("It has already been grabbed! Select any other."+draw);
                                break;
                            case 2:
                                draw++;
                                next = 1;
                                Console.Clear();
                                game.displayGrid();
                                break;
                            case 3:
                                Console.WriteLine("\nHurray!! Player 2 won the game.\nPlease press any key to restart!!");
                                Console.ReadKey();
                                Console.Clear();
                                game.createGrid();
                                game.displayGrid();
                                next = 1;
                                draw = 0;
                                break;
                        }
                        if (next == 1)
                            break;
                    }
                    else
                        Console.WriteLine("Please enter valid box number!");
                }
            }
        }
    }
}
