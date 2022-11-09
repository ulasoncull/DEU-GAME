using System;
using System.Collections;
using System.Threading;

namespace D_E_U
{
    class Program
    {
        static int score1 = 120;
        static int score2 = 120;
        static int whichArrayOfPlayer1;

        static void Main(string[] args)
        {
            bool GameOver = false;
            int countPlayer = 1;
            int indexOfArray2 = 0;
            int indexOfArray3 = 0;
            int indexOfArray1 = 0;
            int y0 = 5;
            int[] player1_1 = new int[15];
            int[] player1_2 = new int[15];
            int[] player1_3 = new int[15];

            Random whichArray = new Random();
            Random elementOfLetter = new Random(); //It determines which letter will be written.
            int x1 = 3;
            int oldx1 = 3;
            int x2 = 3;
            int oldx2 = 3;
            int oldx3 = 3;
            int x3 = 3;
            for (int z = 0; z < 45; z++)
            {
                whichArrayOfPlayer1 = whichArray.Next(1, 4); //It determines which array to write to.
                while (whichArrayOfPlayer1 == 1 && indexOfArray1 <= 14)
                {
                    if (countPlayer % 2 == 1) //Determines the player's turn.
                    {
                        score1 = score1 - 5;
                        Console.Write("Player 1 :");
                        Console.WriteLine("    (P1-" + score1 + " P2-" + score2 + ")");
                        Console.WriteLine("A1\n");
                        Console.WriteLine("A2\n");
                        Console.WriteLine("A3");
                    }
                    else
                    {
                        score2 = score2 - 5;
                        Console.Write("Player 2 :");
                        Console.WriteLine("    (P1-" + score1 + " P2-" + score2 + ")");
                        Console.WriteLine("A1\n");
                        Console.WriteLine("A2\n");
                        Console.WriteLine("A3");
                    }
                    countPlayer = countPlayer + 1;
                    do
                    {
                        int maxValue = Math.Max(indexOfArray1, indexOfArray2);
                        int maxValue2 = Math.Max(maxValue, indexOfArray3);
                        for (int i = 0; i < maxValue2; i++)
                        {

                            if (indexOfArray1 > 0) //Prints the values ​​from the old stages of the 1st array.
                            {
                                if (player1_1[indexOfArray1 - 1] >= 1 && player1_1[indexOfArray1 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray1; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx1 = 3;
                                        }
                                        Console.SetCursorPosition(oldx1, Console.CursorTop - y0);
                                        if (player1_1[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_1[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_1[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0);
                                        oldx1 += 2;
                                    }
                                }
                            }
                            if (indexOfArray2 > 0) //Prints the values ​​from the old stages of the 2nd array.
                            {
                                if (player1_2[indexOfArray2 - 1] >= 1 && player1_2[indexOfArray2 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray2; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx2 = 3;
                                        }
                                        Console.SetCursorPosition(oldx2, Console.CursorTop - y0 + 2);
                                        if (player1_2[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_2[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_2[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0 - 2);
                                        oldx2 += 2;
                                    }
                                }
                            }
                            if (indexOfArray3 > 0) // Prints the values ​​from the old stages of the 3rd array.
                            {
                                if (player1_3[indexOfArray3 - 1] >= 1 && player1_3[indexOfArray3 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray3; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx3 = 3;
                                        }
                                        Console.SetCursorPosition(oldx3, Console.CursorTop - y0 + 4);
                                        if (player1_3[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_3[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_3[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0 - 4);
                                        oldx3 += 2;
                                    }
                                }
                            }
                        }
                        break;
                    } while (false);
                    int a = elementOfLetter.Next(1, 4);
                    player1_1[indexOfArray1] = a; //Prints the new value to the 1st array.
                    Console.SetCursorPosition(x1, Console.CursorTop - y0);
                    if (a == 1)
                    {
                        Console.Write("D");
                    }
                    if (a == 2)
                    {
                        Console.Write("E");
                    }
                    if (a == 3)
                    {
                        Console.Write("U");
                    }
                    Console.SetCursorPosition(0, Console.CursorTop + y0);
                    indexOfArray1 += 1;
                    Thread.Sleep(1000);

                    x1 += 2;
                    for (int i = 0; i <= 12; i++) //Controls when the game will end.
                    {
                        if (player1_1[i] == 1 && player1_1[i + 1] == 2 && player1_1[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_2[i] == 1 && player1_2[i + 1] == 2 && player1_2[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_3[i + 1] == 2 && player1_3[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i + 1] == 2 && player1_3[i + 2] == 3)
                        {
                            GameOver = true;

                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i + 1] == 2 && player1_1[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i] == 2 && player1_3[i] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i] == 2 && player1_1[i] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                    }
                    for (int i = 14; i >= 2; i--)
                    {
                        if (player1_1[i] == 1 && player1_1[i - 1] == 2 && player1_1[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_2[i] == 1 && player1_2[i - 1] == 2 && player1_2[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_3[i - 1] == 2 && player1_3[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i - 1] == 2 && player1_3[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i - 1] == 2 && player1_1[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                    }

                    break;
                }
                if (whichArrayOfPlayer1 == 1 && indexOfArray1 == 15)
                {
                    z -= 1;
                }
                while (whichArrayOfPlayer1 == 2 && indexOfArray2 <= 14)
                {
                    if (countPlayer % 2 == 1)
                    {
                        score1 = score1 - 5;
                        Console.Write("Player 1 :");
                        Console.WriteLine("    (P1-" + score1 + " P2-" + score2 + ")");
                        Console.WriteLine("A1\n");
                        Console.WriteLine("A2\n");
                        Console.WriteLine("A3");
                    }
                    else
                    {
                        score2 = score2 - 5;
                        Console.Write("Player 2 :");
                        Console.WriteLine("    (P1-" + score1 + " P2-" + score2 + ")");
                        Console.WriteLine("A1\n");
                        Console.WriteLine("A2\n");
                        Console.WriteLine("A3");
                    }
                    countPlayer = countPlayer + 1;
                    do
                    {
                        int maxValue = Math.Max(indexOfArray1, indexOfArray2);
                        int maxValue2 = Math.Max(maxValue, indexOfArray3);
                        for (int i = 0; i < maxValue2; i++)
                        {
                            if (indexOfArray1 > 0)
                            {
                                if (player1_1[indexOfArray1 - 1] >= 1 && player1_1[indexOfArray1 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray1; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx1 = 3;
                                        }
                                        Console.SetCursorPosition(oldx1, Console.CursorTop - y0);
                                        if (player1_1[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_1[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_1[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0);
                                        oldx1 += 2;
                                    }
                                }
                            }
                            if (indexOfArray2 > 0)
                            {
                                if (player1_2[indexOfArray2 - 1] >= 1 && player1_2[indexOfArray2 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray2; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx2 = 3;
                                        }
                                        Console.SetCursorPosition(oldx2, Console.CursorTop - y0 + 2);
                                        if (player1_2[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_2[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_2[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0 - 2);
                                        oldx2 += 2;
                                    }
                                }
                            }
                            if (indexOfArray3 > 0)
                            {
                                if (player1_3[indexOfArray3 - 1] >= 1 && player1_3[indexOfArray3 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray3; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx3 = 3;
                                        }
                                        Console.SetCursorPosition(oldx3, Console.CursorTop - y0 + 4);
                                        if (player1_3[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_3[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_3[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0 - 4);
                                        oldx3 += 2;
                                    }
                                }
                            }
                        }

                        break;
                    } while (false);
                    int a = elementOfLetter.Next(1, 4);
                    player1_2[indexOfArray2] = a;
                    Console.SetCursorPosition(x2, Console.CursorTop - y0 + 2);
                    if (a == 1)
                    {
                        Console.Write("D");
                    }
                    if (a == 2)
                    {
                        Console.Write("E");
                    }
                    if (a == 3)
                    {
                        Console.Write("U");
                    }
                    Console.SetCursorPosition(0, Console.CursorTop + y0 - 2);
                    indexOfArray2 += 1;
                    Thread.Sleep(1000);
                    x2 += 2;
                    for (int i = 0; i <= 12; i++)
                    {
                        if (player1_1[i] == 1 && player1_1[i + 1] == 2 && player1_1[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_2[i] == 1 && player1_2[i + 1] == 2 && player1_2[i + 2] == 3)
                        {
                            GameOver = true;

                            break;
                        }
                        if (player1_3[i] == 1 && player1_3[i + 1] == 2 && player1_3[i + 2] == 3)
                        {
                            GameOver = true;

                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i + 1] == 2 && player1_3[i + 2] == 3)
                        {
                            GameOver = true;

                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i + 1] == 2 && player1_1[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i] == 2 && player1_3[i] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i] == 2 && player1_1[i] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                    }
                    for (int i = 14; i >= 2; i--)
                    {
                        if (player1_1[i] == 1 && player1_1[i - 1] == 2 && player1_1[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_2[i] == 1 && player1_2[i - 1] == 2 && player1_2[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_3[i - 1] == 2 && player1_3[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i - 1] == 2 && player1_3[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i - 1] == 2 && player1_1[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                    }
                    break;
                }
                if (whichArrayOfPlayer1 == 2 && indexOfArray2 == 15)
                {
                    z -= 1;
                }
                while (whichArrayOfPlayer1 == 3 && indexOfArray3 <= 14)
                {
                    if (countPlayer % 2 == 1)
                    {
                        score1 = score1 - 5;
                        Console.Write("Player 1 :");
                        Console.WriteLine("    (P1-" + score1 + " P2-" + score2 + ")");
                        Console.WriteLine("A1\n");
                        Console.WriteLine("A2\n");
                        Console.WriteLine("A3");
                    }
                    else
                    {
                        score2 = score2 - 5;
                        Console.Write("Player 2 :");
                        Console.WriteLine("    (P1-" + score1 + " P2-" + score2 + ")");
                        Console.WriteLine("A1\n");
                        Console.WriteLine("A2\n");
                        Console.WriteLine("A3");
                    }
                    countPlayer = countPlayer + 1;
                    do
                    {
                        int maxValue = Math.Max(indexOfArray1, indexOfArray2);
                        int maxValue2 = Math.Max(maxValue, indexOfArray3);
                        for (int i = 0; i < maxValue2; i++)
                        {
                            if (indexOfArray1 > 0)
                            {
                                if (player1_1[indexOfArray1 - 1] >= 1 && player1_1[indexOfArray1 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray1; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx1 = 3;
                                        }
                                        Console.SetCursorPosition(oldx1, Console.CursorTop - y0);
                                        if (player1_1[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_1[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_1[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0);
                                        oldx1 += 2;
                                    }
                                }
                            }
                            if (indexOfArray2 > 0)
                            {
                                if (player1_2[indexOfArray2 - 1] >= 1 && player1_2[indexOfArray2 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray2; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx2 = 3;
                                        }
                                        Console.SetCursorPosition(oldx2, Console.CursorTop - y0 + 2);
                                        if (player1_2[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_2[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_2[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0 - 2);
                                        oldx2 += 2;
                                    }
                                }
                            }
                            if (indexOfArray3 > 0)
                            {
                                if (player1_3[indexOfArray3 - 1] >= 1 && player1_3[indexOfArray3 - 1] < 4)
                                {
                                    for (int x = 0; x < indexOfArray3; x++)
                                    {
                                        if (x == 0)
                                        {
                                            oldx3 = 3;
                                        }
                                        Console.SetCursorPosition(oldx3, Console.CursorTop - y0 + 4);
                                        if (player1_3[x] == 1)
                                        {
                                            Console.Write("D");
                                        }
                                        if (player1_3[x] == 2)
                                        {
                                            Console.Write("E");
                                        }
                                        if (player1_3[x] == 3)
                                        {
                                            Console.Write("U");
                                        }
                                        Console.SetCursorPosition(0, Console.CursorTop + y0 - 4);
                                        oldx3 += 2;
                                    }
                                }
                            }
                        }
                        break;
                    } while (false);
                    int a = elementOfLetter.Next(1, 4);
                    player1_3[indexOfArray3] = a;
                    Console.SetCursorPosition(x3, Console.CursorTop - y0 + 4);
                    if (a == 1)
                    {
                        Console.Write("D");
                    }
                    if (a == 2)
                    {
                        Console.Write("E");
                    }
                    if (a == 3)
                    {
                        Console.Write("U");
                    }
                    Console.SetCursorPosition(0, Console.CursorTop + y0 - 4);
                    indexOfArray3 += 1;
                    x3 += 2;
                    for (int i = 0; i <= 12; i++)
                    {
                        if (player1_1[i] == 1 && player1_1[i + 1] == 2 && player1_1[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_2[i] == 1 && player1_2[i + 1] == 2 && player1_2[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_3[i + 1] == 2 && player1_3[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i + 1] == 2 && player1_3[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i + 1] == 2 && player1_1[i + 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i] == 2 && player1_3[i] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i] == 2 && player1_1[i] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                    }
                    for (int i = 14; i >= 2; i--)
                    {
                        if (player1_1[i] == 1 && player1_1[i - 1] == 2 && player1_1[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_2[i] == 1 && player1_2[i - 1] == 2 && player1_2[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_3[i - 1] == 2 && player1_3[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_1[i] == 1 && player1_2[i - 1] == 2 && player1_3[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                        if (player1_3[i] == 1 && player1_2[i - 1] == 2 && player1_1[i - 2] == 3)
                        {
                            GameOver = true;
                            break;
                        }
                    }
                    break;
                }
                Thread.Sleep(1000);
                if (whichArrayOfPlayer1 == 3 && indexOfArray3 == 15)
                {
                    z -= 1;
                }
                if (indexOfArray1 > 14 && indexOfArray2 > 14 && indexOfArray3 > 14)
                {
                    break;
                }

                if (GameOver)
                {
                    break;
                }
            }
            string[] names = new string[] { "Derya", "Elife", "Fatih", "Ali", "Azra", "Siber", "Cem", "Nazan", "Mehmet", "Nil", "Can", "Tarkan", "PlayerX", };
            int[] scores = new int[] { 100, 100, 95, 90, 85, 80, 80, 70, 55, 50, 30, 30, 0 };

            if (countPlayer % 2 == 0 && GameOver == true) //It determines who wins.
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlayer 1 WON!!");
                Console.ResetColor();
                Console.WriteLine("\nHIGH SCORE TABLE");
                scores[12] = score1;
                Array.Sort(scores);
                Array.Reverse(scores);
                int location = Array.IndexOf(scores, score1);
                for (int r = 11; r >= location; r--) //Moves the player to where they should be on the table.
                {
                    names[r + 1] = names[r];
                    names[r] = names[r + 1];
                }
                names[location] = "Player1";
                foreach (string name in names) //prints the names in the table.
                {
                    Console.WriteLine(name);
                }
                foreach (int score in scores) //prints the scores in the table.
                {
                    Console.SetCursorPosition(25, Console.CursorTop - 13);
                    Console.WriteLine(score);
                    Console.SetCursorPosition(0, Console.CursorTop + 13);
                }
                Console.SetCursorPosition(0, Console.CursorTop - 12);

            }
            else if (countPlayer % 2 == 1 && GameOver == true) //It determines who wins.
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nPlayer 2 WON!!");
                Console.ResetColor();
                Console.WriteLine("\nHIGH SCORE TABLE");
                scores[12] = score2;
                Array.Sort(scores);
                Array.Reverse(scores);
                int location = Array.IndexOf(scores, score2);
                for (int r = 11; r >= location; r--)
                {
                    names[r + 1] = names[r];
                    names[r] = names[r + 1];
                }
                names[location] = "Player2";
                foreach (string name in names)
                {
                    Console.WriteLine(name);
                }
                foreach (int score in scores)
                {
                    Console.SetCursorPosition(25, Console.CursorTop - 13);
                    Console.WriteLine(score);
                    Console.SetCursorPosition(0, Console.CursorTop + 13);
                }
                Console.SetCursorPosition(0, Console.CursorTop - 12);

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\nThe Game Is Draw!!");
                Console.ResetColor();
                Console.WriteLine("\nHIGH SCORE TABLE");
                for (int i = 0; i < 12; i++)
                {
                    Console.WriteLine(names[i]);
                }
                for (int i = 0; i < 12; i++)
                {
                    Console.SetCursorPosition(25, Console.CursorTop - 12);
                    Console.WriteLine(scores[i]);
                    Console.SetCursorPosition(0, Console.CursorTop + 12);
                }
                Console.SetCursorPosition(0, Console.CursorTop - 12);

            }

        }
    }
}
