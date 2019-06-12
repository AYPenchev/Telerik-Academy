using System.ComponentModel.Design;

namespace Task4
{
    using System;
    using System.Collections.Generic;

    public class Mines
    {
        static void Main()
        {
            const int MAX_MOVES = 35;
            string comand = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = DeployBombs();
            int countMoves = 0;
            bool isOnMine = false;
            List<Points> bestResults = new List<Points>(6);
            int row = 0;
            int column = 0;
            bool hasToShowRules = true;
            bool isWinner = false;

            do
            {
                if (hasToShowRules)
                {
                    Console.WriteLine("Lets play “Mines”. Try finding all fields without mines." +
                                      "\nComands: \n'top' - shows ranking \n'restart' - begin new game \n'exit' - exit the game!");
                    DeployGameField(field);
                    hasToShowRules = false;
                }

                Console.Write("Enter comand or choose row and column: ");
                comand = Console.ReadLine().Trim();
                if (comand.Length >= 3)
                {
                    if (int.TryParse(comand[0].ToString(), out row) &&
                        int.TryParse(comand[2].ToString(), out column) &&
                        row <= field.GetLength(0) &&
                        column <= field.GetLength(1))
                    {
                        comand = "turn";
                    }
                }

                switch (comand)
                {
                    case "top":
                        Ranking(bestResults);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = DeployBombs();
                        DeployGameField(field);
                        break;
                    case "exit":
                        Console.WriteLine("Bye!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                YourTurn(field, bombs, row, column);
                                countMoves++;
                            }
                            if (MAX_MOVES == countMoves)
                            {
                                isWinner = true;
                            }
                            else
                            {
                                DeployGameField(field);
                            }
                        }
                        else
                        {
                            isOnMine = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid comand\n");
                        break;
                }

                if (isOnMine)
                {
                    DeployGameField(bombs);

                    Console.Write("\nGame over with {0} points. " + "Nickname: ", countMoves);

                    string nickname = Console.ReadLine();
                    Points gamerPoints = new Points(nickname, countMoves);

                    if (bestResults.Count < 5)
                    {
                        bestResults.Add(gamerPoints);
                    }
                    else
                    {
                        for (int i = 0; i < bestResults.Count; i++)
                        {
                            if (bestResults[i].PointsIn < gamerPoints.PointsIn)
                            {
                                bestResults.Insert(i, gamerPoints);
                                bestResults.RemoveAt(bestResults.Count - 1);
                                break;
                            }
                        }
                    }

                    bestResults.Sort((r1, r2) => r2.Name.CompareTo(r1.Name));
                    bestResults.Sort((r1, r2) => r2.PointsIn.CompareTo(r1.PointsIn));
                    Ranking(bestResults);

                    field = CreateGameField();
                    bombs = DeployBombs();
                    countMoves = 0;
                    isOnMine = false;
                    hasToShowRules = true;
                }
                else if (isWinner)
                {
                    Console.WriteLine("\nYou opened 35 cells without stepping on bomb and you WIN!.");
                    DeployGameField(bombs);

                    Console.WriteLine("Nickname: ");
                    string yourNickname = Console.ReadLine();

                    Points yourPoints = new Points(yourNickname, countMoves);

                    bestResults.Add(yourPoints);
                    Ranking(bestResults);

                    field = CreateGameField();
                    bombs = DeployBombs();
                    countMoves = 0;
                    isWinner = false;
                    hasToShowRules = true;
                }
            } while (comand != "exit");
        }

        private static void Ranking(List<Points> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells",
                        i + 1, points[i].Name, points[i].PointsIn);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("No raking!\n");
            }
        }

        private static void YourTurn(char[,] field, char[,] bombs, int row, int column)
        {
            char numberOfBombs = BombsNumberAroundCell(bombs, row, column);
            bombs[row, column] = numberOfBombs;
            field[row, column] = numberOfBombs;
        }

        private static void DeployGameField(char[,] board)
        {
            int rowsLength = board.GetLength(0);
            int columnsLength = board.GetLength(1);

            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");

            for (int i = 0; i < rowsLength; i++)
            {
                Console.Write("{0} | ", i);

                for (int j = 0; j < columnsLength; j++)
                {
                    Console.Write("{0} ", board[i, j]);
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] DeployBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> bombs = new List<int>();
            while (bombs.Count < 15)
            {
                Random random = new Random();
                int bombPosition = random.Next(50);
                if (!bombs.Contains(bombPosition))
                {
                    bombs.Add(bombPosition);
                }
            }

            foreach (int bombPosition in bombs)
            {
                int bombColumn = (bombPosition / columns);
                int bombRow = (bombPosition % columns);
                if (bombRow == 0 && bombPosition != 0)
                {
                    bombColumn--;
                    bombRow = columns;
                }
                else
                {
                    bombRow++;
                }
                gameField[bombColumn, bombRow - 1] = '*';
            }

            return gameField;
        }

        private static char BombsNumberAroundCell(char[,] bombs, int row, int column)
        {
            int countBombsAroundCell = 0;
            int rowsLength = bombs.GetLength(0);
            int columnsLength = bombs.GetLength(1);

            bool isDownRowBomb = (row - 1 >= 0) && (bombs[row - 1, column] == '*');
            bool isUpRowBomb = (row + 1 < rowsLength) && (bombs[row + 1, column] == '*');
            bool isLeftColumnBomb = (column - 1 >= 0) && (bombs[row, column - 1] == '*');
            bool isRightColumnBomb = (column + 1 < columnsLength) && (bombs[row, column + 1] == '*');

            bool isDownRowLeftColumnBomb = (row - 1 >= 0) && (column - 1 >= 0) && (bombs[row - 1, column - 1] == '*');
            bool isDownRowRightColumnBomb = (row - 1 >= 0) && (column + 1 < columnsLength) &&
                                            (bombs[row - 1, column + 1] == '*');
            bool isUpRowLeftColumnBomb = (row + 1 < rowsLength) && (column - 1 >= 0) && (bombs[row + 1, column - 1] == '*');
            bool isUpRowRightColumnBomb = (row + 1 < rowsLength) && (column + 1 < columnsLength) &&
                                          (bombs[row + 1, column + 1] == '*');

            List<bool> checksForBombsAroundCell = new List<bool>()
            {
                isDownRowBomb,
                isUpRowBomb,
                isLeftColumnBomb,
                isRightColumnBomb,
                isDownRowLeftColumnBomb,
                isDownRowRightColumnBomb,
                isUpRowLeftColumnBomb,
                isUpRowRightColumnBomb
            };

            foreach (bool check in checksForBombsAroundCell)
            {
                if (check == true)
                {
                    countBombsAroundCell++;
                }
            }

            return char.Parse(countBombsAroundCell.ToString());
        }
    }
}
