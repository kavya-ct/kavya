using System;
using System.Collections.Generic;
using System.Text;

namespace Functionalpgms
{
    class String
    {
        public void Run() { 
            Console.WriteLine("please enter your name");
            string str1 = Console.ReadLine();
            string str2 = "Hello   <<UserName>> How are You?";

            Console.WriteLine(str2.Replace(" <<UserName>>", str1));

        }
    }
}
