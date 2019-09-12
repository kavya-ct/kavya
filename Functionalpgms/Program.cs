// --------------------------------------------------------------------------------------------------------------------
// <copyright file=Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;

namespace Functionalpgms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1. String\n2. LeapYear\n3.Power\n4.Flipcoin\n5.Harmonic\n6.Factor\n7.Gambler\n8.CouponNumber\n9.WindChill\n10.Quadratic\n11.Sumofinteger\n12.Distance\n13.Two_D_Array\n14.Stop\n15.TicTacToe"); 
                
            Console.WriteLine("Enter your choice :");
            choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    String s = new String();

                    s.Run(); break;


                case 2:
                    LeapYear obj = new LeapYear();
                    obj.readdata();
                    
                    break;

                case 3:
                    Power pow = new Power();
                    pow.highest();
                    break;

                case 4:
                    Flipcoin.Flip();
                    break;

                case 5:
                    Harmonic.Harmon();
                    break;

                 case 6:
                    Factor fa = new Factor();
                    fa.fact();
                    break;

                case 7:
                    Gambler ga = new Gambler();
                    ga.game();
                    break;

                case 8:
                    CouponNumber cp = new CouponNumber();
                    cp.Coupan();
                    break;

                case 9:
                    WindChill wc = new WindChill();
                    wc.Wind();
                    break;

                case 10:
                    Quadratic qu = new Quadratic();
                    int a = 1, b = -7, c = 12;
                    qu.findRoots(a,b,c);
                    break;

                case 11:
                    Sumofinteger si = new Sumofinteger();
                    si.Sum();
                    break;

                case 12:
                    Distance ds = new Distance();
                    ds.Calculate();
                    break;

                case 13:
                    Two_D_Array td = new Two_D_Array();
                    td.IntArray();
                    break;

                case 14:
                    Stop stp = new Stop();
                    stp.stop();
                    break;

                case 15:
                    TicTacToe ticTac = new TicTacToe();
                    ticTac.game();
                    break;
                    
                       
                    
                   




                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
