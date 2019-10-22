using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DesignPatterns.Reflection
{
    /// <summary>
    /// 
    /// </summary>
    class TypeProperties
    {
        /// <summary>
        /// Moneys this instance.
        /// </summary>
        public static void Money()
        {
           
            Type t = typeof(Car);
            GetTypeProperties(t);
            Console.ReadLine();
        }
        public static void GetTypeProperties(Type t)
        {
            StringBuilder OutputText = new StringBuilder();

            ////properties retrieve the strings 
            OutputText.AppendLine("Analysis of type " + t.Name);
            OutputText.AppendLine("Type Name: " + t.Name);
            OutputText.AppendLine("Full Name: " + t.FullName);
            OutputText.AppendLine("Namespace: " + t.Namespace);

            ////properties retrieve references        
            Type tBase = t.BaseType;

            if (tBase != null)
            {
                OutputText.AppendLine("Base Type: " + tBase.Name);
            }

            Type tUnderlyingSystem = t.UnderlyingSystemType;

            if (tUnderlyingSystem != null)
            {
                OutputText.AppendLine("UnderlyingSystem Type: " +
                    tUnderlyingSystem.Name);
                ////OutputText.AppendLine("UnderlyingSystem Type Assembly: " +
                // //   tUnderlyingSystem.Assembly); 
            }

            ////properties retrieve boolean         
            OutputText.AppendLine("Is Abstract Class: " + t.IsAbstract);
            OutputText.AppendLine("Is an Arry: " + t.IsArray);
            OutputText.AppendLine("Is a Class: " + t.IsClass);
            OutputText.AppendLine("Is a COM Object : " + t.IsCOMObject);

            OutputText.AppendLine("\nPUBLIC MEMBERS:");
            MemberInfo[] Members = t.GetMembers();

            foreach (MemberInfo NextMember in Members)
            {
                OutputText.AppendLine(NextMember.DeclaringType + " " +
                NextMember.MemberType + "  " + NextMember.Name);
            }
            Console.WriteLine(OutputText);
        }
    }
}




