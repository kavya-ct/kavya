using System;

namespace Algorithmpgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1. Anagram\n2.Primenumbers\n3.PalindromeAna");

            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:

                Anagram ana = new Anagram();
                ana.AreAnagram();
                break;

                case 2:

                    Primenumbers pn = new Primenumbers();
                    pn.Prime();
                    break;

                case 3:
                    PalindromeAna pa = new PalindromeAna();
                    pa.Palindrome();
                    break;
            }


              
        }

    




                //default:
                  //Console.WriteLine("Invalid Choice");
                    //break;
            
        
 }   }
