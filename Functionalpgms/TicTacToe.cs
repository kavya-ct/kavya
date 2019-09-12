// --------------------------------------------------------------------------------------------------------------------
// <copyright file=TicTacToe" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    /// <summary>
    /// TicTacToe is the class
    /// </summary>
    class TicTacToe
    {
        /// <summary>
        /// TicTac this instance
        /// </summary>

        public void game()
        {
            Console.WriteLine("Enter rows and column");
            int[,] array = new int[,] { { -1, -2, -3 }, { -4, -5, -6 }, { -7, -8, -9 } };
            int i = 0, x, y;
            Random random = new Random();
            ////
            ///

            while (i < 9)
            {
                if (i % 2 == 0)
                {
                    do
                    {
                        Console.WriteLine("user enter the coordinates");
                        x = Convert.ToInt32(Console.ReadLine());
                        y = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("{0}, {1}", x, y);
                    }

                    while (array[x, y] > 0);
                    array[x, y] = 1;

                    if (this.Win(array) == 1)
                    {
                        Console.WriteLine("user is winner");
                        break;

                    }
                    i++;

                }
                else
                {
                    do
                    {
                        Console.WriteLine("computer enter the coordinate");
                        x = random.Next(3);
                        y = random.Next(3);
                        Console.WriteLine("{0},{1}", x, y);
                    }
                    while (array[x, y] > 0);
                    array[x, y] = 2;
                    if (this.Win(array) == 1)
                    {
                        Console.WriteLine("computer is winner");
                        break;
                    }
                    i++;
                }
                if (this.Win(array)!= 1 && i > 3)
                {
                    Console.WriteLine("draw");

                }

            }
        }

        public int Win(int[,] array)
        {
            for (int i = 0; i < 3; i++)
            {
                if (array[i, 0] == array[i, 1] && array[i, 1] == array[i, 2])
                {
                    return 1;
                }

                else if (array[0, i] == array[1, i] && array[1, i] == array[2, i])
                {
                    return 1;
                }

            }

            if (array[0, 0] == array[1, 1] && array[1, 1] == array[2, 2])
            {
                return 1;
            }
            if (array[0, 2] == array[1, 1] && array[1, 1] == array[2, 0])
            {
                return 1;
            }
            return 0;
        }
    }

}
