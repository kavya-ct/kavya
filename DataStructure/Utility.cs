// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Datastructure.cs" company="Bridgelabz">
//   Copyright © 2019 Company="BridgeLabz"
// </copyright>
// <creator name="Kavya ct"/>
// --------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    /// <summary>
    /// 
    /// </summary>
    class Utility
    {
        Node head = null;
        INode head1 = null;

        /// <summary>
        /// Node is class i have taking for string data
        /// </summary>
        public class Node
        {
            public string data;
            public Node next = null;

            public Node(string data)
            {
                this.data = data;
                this.next = null;
            }
        }

        /// <summary>
        /// INode is class i have taking for integer data
        /// </summary>
        public class INode
        {
            public int data;
            public INode next = null;

            public INode(int numbers)
            {
                this.data = data;
                this.next = null;
            }
        }
        public void AddString(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted 1" + " " + node.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted 2" + " " + node.data);
            }
        }

        public void AddIntegers(int numbers)
        {
            INode nod = new INode(numbers);
            if (head1 == null)
            {
                head1 = nod;
                Console.WriteLine("Inserted 1" + " " + nod.data);

            }
            else
            {
                INode temp = head1;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = nod;
                Console.WriteLine("Inserted 2" + " " + nod.data);


            }
        }

        public void Display()
        {
            Node temp = head;
            while (temp.next != null)
            {

                Console.WriteLine("temp.data");
                temp = temp.next;
            }

        }

        public void DeleteString(string data)
        {
            Node temp = head;
            Node Prev = head;
            if (temp == null)
            {
                Console.WriteLine("empty");
                return;
            }
            else if (temp.data == data)
            {
                head = temp.next;
                Console.WriteLine("found");
                return;
            }
            else
            {
                while (temp != null)
                {

                    if (temp.data == data)
                    {

                        Prev.next = temp.next;
                        Console.WriteLine("found");
                        Console.WriteLine("deleting  " + "  temp data");
                        return;

                    }
                    Prev = temp;
                    temp = temp.next;
                }


                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }

        public void DeleteInteger(int data)
        {
            INode temp = head1;
            INode Prev = head1;
            if (temp == null)
            {
                Console.WriteLine("empty");
                return;
            }
            else if (temp.data == data)
            {
                head1 = temp.next;
                Console.WriteLine("found");
                return;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Prev.next = temp.next;
                        Console.WriteLine("found");
                        Console.WriteLine("deleting" + "temp data");
                        return;

                    }
                    Prev = temp;
                    temp = temp.next;
                }

                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }
        public int SearchString(string search)
        {
            ////Function to search the list
            Node temp = head;
            ////if the list is empty
            if (head.data == null)
            {
                Console.WriteLine("nothing found list is empty");
            }
            else
            {
                ////while loop is used to search the data.
                while (temp != null)
                {
                    if (temp.data == search)
                    {
                        Console.WriteLine(search + "is in the list");
                        return 1;
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine(search + "not in the list");
            return 0;
        }
        public int SearchIntegers(int search)
        {
            INode temp = head1;
            if (head1.data == 0)
            {
                Console.WriteLine("nothing found list is empty");

            }
            else
            {
                ////while loop is used to search the data
                while (temp != null)
                {
                    if (temp.data == search)
                    {
                        Console.WriteLine(search + "is in the list");
                        return 1;
                    }
                    temp = temp.next;
                }
            }
            Console.WriteLine(search + "not in the list");
            return 0;
        }

        public void Isempty()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Arithmetic expression is balanced");

            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                }
                temp = temp.next;
            }
            Console.WriteLine("Arithmatic expression is not balanced");

        }

        public int DepositCash(BankingCashCounter bankingCash)
        {
            int amount;
            do
            {
                Console.WriteLine("enter the amount you want to deposit");
                Console.WriteLine("NOTE:-Amount should be greater than zero to make a deposit");
                amount = Convert.ToInt32(Console.ReadLine());
            }
            while (amount < 0);
            {
                BankingCashCounter.InitialAmount = BankingCashCounter.InitialAmount + amount;
                Console.WriteLine("Transaction succesfull Enter Amount had been successfully Deposited");

            }
            return BankingCashCounter.InitialAmount;
        }

        public int WithDrawlCash(BankingCashCounter bankingCash)
        {
            Console.WriteLine("Available Balance Rs- + BankingCashCounter.InitialAmount");
            Console.WriteLine("Enter amount withdrawal");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= BankingCashCounter.InitialAmount)
            {
                Console.WriteLine("Enter amount had successfully withdrawal");
                BankingCashCounter.InitialAmount = BankingCashCounter.InitialAmount - amount;
            }
            else
            {
                Console.WriteLine("error!!!Enter amount more than cash available in account");
            }
            return BankingCashCounter.InitialAmount;
        }

        public void Dequeue(string data)
        {
            Node temp = head;
            Node Prev = head;
            if (temp == null)
            {
                Console.WriteLine("empty");
                return;
            }
            else if (temp.data == data)
            {
                head = temp.next;
                Console.WriteLine("found" + " " + data);
                return;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Prev.next = temp.next;
                        Console.WriteLine("found");
                        Console.WriteLine("found1 " + " " + temp.data);
                        return;
                    }
                    Prev = temp;
                    temp = temp.next;

                }
                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }

            }


        }

        public void Enqueue(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted " + " " + node.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted " + " " + node.data);
            }
        }


        public static bool IsNumber(String input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public static int CountBinarySearch(int n)
        {
            int numerator = 0;
            int denominator = 0;
            ////to count binary trees for given no. of n
            numerator = Factorial(2 * n);
            denominator = Factorial(n + 1) * Factorial(n);
            return numerator / denominator;

        }

        public static int Factorial(int num)
        {
            int fact = num;
            while (num > 1)
            {
                fact = fact * (num - 1);
                num--;
            }
            return num;
        }

        public static int day(int month,int day,int year)
        {
            int y = year - (14 - month) / 12;
            int x = y + y / 4 - y / 100 + y / 400;
            int m = month + 12 * ((14 - month) / 12) - 2;
            int d = (day + x + (31 * m) / 12) % 7;
            return d;
        }

        public static bool isLeapYear(int year)
        {
            if((year % 4 == 0) && (year % 100 != 0))
            { 
                return true;
            }
            if (year % 400 == 0)
            {
                return true;
            }
            return false;
        }
    }



}


        


 



    










     