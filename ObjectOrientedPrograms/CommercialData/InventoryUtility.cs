using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.CommercialData
{
    class InventoryUtility
    {
        public static bool ContainsCharacter(string username)
        {
            try
            {
                char[] usernameCharacter = username.ToCharArray();
                for (int i = 0; i < usernameCharacter.Length; i++)
                {
                    if (!char.IsLetterOrDigit(usernameCharacter[i]))
                    {
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }

        public static bool ContainsDigit(string username)
        {
            try
            {
                char[] usernameCharacter = username.ToCharArray();
                for (int i = 0; i < usernameCharacter.Length; i++)
                {
                    if (char.IsDigit(usernameCharacter[i]))
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }
        public static bool CheckString(string name)
        {
            try
            {
                name = name.Trim();
                if (string.IsNullOrEmpty(name))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return true;
        }


    }
}

