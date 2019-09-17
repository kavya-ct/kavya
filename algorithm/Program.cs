using System;

namespace Algorithmpgm
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.Anagram\n2.Primenumbers\n3.PalindromeAna\n4.VendingMachine\n5.BubbleSort");
            Console.WriteLine("\n6.MergeSort\n7.InsertionSort\n8.BinarySearch\n9.QuestionNumber\n10.Gregoriancalendar");
            Console.WriteLine("\n11.TemperatureConversion\n12.MonthlyPayment\n13.BinaryNumber\n14.Searchtext\n15.Nibbles\n16.Newton");

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

                case 4:
                    VendingMachine vm = new VendingMachine();
                    vm.Amount();
                    break;

                case 5:
                    BubbleSort bs = new BubbleSort();
                    bs.Mysort();
                    break;

                case 6:
                    MergeSort ms = new MergeSort();
                    ms.Merge();
                    break;

                case 7:
                    InsertionSort insert = new InsertionSort();
                    insert.Insertion();
                    break;

                case 8:
                    BinarySearch bss = new BinarySearch();
                    bss.Binary();
                    break;

                case 9:
                    QuestionNumber qn = new QuestionNumber();
                    qn.Question_Game();
                    break;

                case 10:
                    Gregoriancalendar gregorian = new Gregoriancalendar();
                    gregorian.DayofWeek();
                    break;

                case 11:
                    TemperatureConversion temp = new TemperatureConversion();
                    temp.Sqrt();
                    break;

                case 12:
                    MonthlyPayment mp = new MonthlyPayment();
                    mp.Pay();
                    break;

                case 13:
                    BinaryNumber bn = new BinaryNumber();
                    bn.Binary();
                    break;

                case 14:
                    Searchtext st = new Searchtext();
                    st.TextFile();
                    break;

                case 15:
                    Nibbles n = new Nibbles();
                    n.Swap();
                    break;

                case 17:
                    
                    
                    Newton.Sqrt();
                    break;









            }


              
        }

    




                //default:
                  //Console.WriteLine("Invalid Choice");
                    //break;
            
        
 }   }
