using System;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)

        {
            int choice;
            Console.WriteLine("1.UnorderdList\n2.OrderedList\n3.BalancedParanthesis\n4.BankingCashCounter\n5.PalindromeChecker\n6.Calender");
            Console.WriteLine("\n7.PrimeNumbers\n8.BinarySearch");


            Console.WriteLine("Enter your choice");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    UnorderedList order = new UnorderedList();
                    order.List();
                    break;

                case 2:
                    OrderedList ordered = new OrderedList();
                    ordered.Order();
                    break;

                case 3:
                    BalancedParanthesis balanced = new BalancedParanthesis();
                    balanced.Paranthesis();
                    break;

                 case 4:
                    BankingCashCounter cash = new BankingCashCounter();
                    cash.CashCounter();
                    break;

                case 5:
                    PalindromeChecker palindrome = new PalindromeChecker();
                    palindrome.Checker();
                    break;

                case 6:
                    Calender month = new Calender();
                    month.Year();
                    break;

                case 7:
                    PrimeNumbers num = new PrimeNumbers();
                    num.Prime();
                    break;

                case 8:
                    BinarySearch binary = new BinarySearch();
                    binary.Search();
                    break;

                









                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }
    }
}
