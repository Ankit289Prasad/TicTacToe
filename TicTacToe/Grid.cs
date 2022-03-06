using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    class Grid
    {
        private char[,] grid = new char[3, 3];
        public void createGrid()
        {
            int c = 49;
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                {
                    grid[i, j] = (char)c;
                    c++;
                }
        }
        public void displayGrid()
        {
            Console.WriteLine(" +==========================+");
            for (int i = 0; i < 3; i++)
            {
                
                Console.WriteLine(" |        :        :        |");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(" |   "+grid[i, j]+"   ");
                }
                Console.WriteLine(" |\n |        :        :        |");
                if(i<2)
                Console.WriteLine(" ----------------------------");
            }
            Console.WriteLine(" +==========================+");
        }
        public int playChance(int playerNumber,int choice)
        {
            int status=0;
            switch(choice)
            {
                case 1:
                    if (grid[0, 0] == 49)
                    {
                        if (playerNumber == 1)
                            grid[0, 0] = 'X';
                        else
                            grid[0, 0] ='O';
                        status=checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 2:
                    if (grid[0, 1] == 50)
                    {
                        if (playerNumber == 1)
                            grid[0, 1] = 'X';
                        else
                            grid[0, 1] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 3:
                    if (grid[0, 2] == 51)
                    {
                        if (playerNumber == 1)
                            grid[0, 2] = 'X';
                        else
                            grid[0, 2] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 4:
                    if (grid[1,0] == 52)
                    {
                        if (playerNumber == 1)
                            grid[1, 0] = 'X';
                        else
                            grid[1, 0] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 5:
                    if (grid[1,1] == 53)
                    {
                        if (playerNumber == 1)
                            grid[1,1] = 'X';
                        else
                            grid[1,1] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 6:
                    if (grid[1,2] == 54)
                    {
                        if (playerNumber == 1)
                            grid[1, 2] = 'X';
                        else
                            grid[1, 2] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 7:
                    if (grid[2,0] == 55)
                    {
                        if (playerNumber == 1)
                            grid[2, 0] = 'X';
                        else
                            grid[2, 0] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 8:
                    if (grid[2, 1] == 56)
                    {
                        if (playerNumber == 1)
                            grid[2, 1] = 'X';
                        else
                            grid[2, 1] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
                case 9:
                    if (grid[2, 2] == 57)
                    {
                        if (playerNumber == 1)
                            grid[2, 2] = 'X';
                        else
                            grid[2, 2] = 'O';
                        status = checkWinning();
                    }
                    else
                        status = 1;
                    break;
            }
            return status;
        }
        public int checkWinning()
        {
            int status = 2;
            if ((grid[0, 0] == grid[1, 1] && grid[1, 1] == grid[2, 2]) || (grid[0, 0] == grid[0, 1] && grid[0, 1] == grid[0, 2]) || ((grid[0, 0] == grid[1, 0] && grid[1, 0] == grid[2, 0])) || (grid[0, 1] == grid[1, 1] && grid[2, 1] == grid[1, 1]) || (grid[0, 2] == grid[1, 2] && grid[1, 2] == grid[2, 2]) || (grid[0, 2] == grid[1, 1] && grid[2, 0] == grid[1, 1]) || (grid[1, 0] == grid[1, 1] && grid[1, 1] == grid[1, 2]) || (grid[2, 0] == grid[2, 1] && grid[2, 1] == grid[2, 2]))
                status = 3;
            if (status == 3)
            {
                Console.Clear();
                displayGrid();
            }
            return status;
        }
    }
}
