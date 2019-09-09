using System;

namespace Functionalpgms
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1. String\n2. LeapYear\n3.Power\n4.Flipcoin\n5.Harmonic\n6.Factor");
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

                    
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
