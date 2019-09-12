// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Two_D_Array.cs" company="Bridgelabz">
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
    /// Two_D_Array is class name
    /// </summary>
    public class Two_D_Array
    {

        Utility utility = new Utility();
        public void IntArray()
        {
            Console.WriteLine("Enter number of rows");
            ////reading number of rows from the user
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of column");

            ////reading number of column from the user
            int column = Convert.ToInt32(Console.ReadLine());

            int[,] intArray = new int[row, column];
            double[,] doubleArray = new double[row, column];
            Boolean[,] BooleanArray = new Boolean[row, column];
            Console.WriteLine("1.Integer Array \n2.Double Array \n3.Boolean Array");

            int choice = Convert.ToInt32(Console.ReadLine());
            ///switch case to execute code faster
            switch (choice)
            {
                case 1:
                    intArray = utility.CallTwoDimArray(row, column);
                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write(intArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 2:
                    doubleArray = utility.Call(row, column);

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write(doubleArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 3:
                    BooleanArray = utility.CallBool(row, column);

                    for (int i = 0; i < row; i++)
                    {
                        for (int j = 0; j < column; j++)
                        {
                            Console.Write(BooleanArray[i, j] + " ");
                        }
                        Console.WriteLine();
                    }
                    break;

                default:

                    Console.WriteLine("Enter correct number");
                    Convert.ToInt32(Console.ReadLine());
                    break;




            }


        }
    }
}
