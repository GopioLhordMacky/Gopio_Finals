using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_with_Class
{
    internal class Membership
    {

        static List<string> FrUsers = new List<string>();

        private static void FreeUsers()
        {
            FrUsers.Add("password");
            FrUsers.Add("admin");
            FrUsers.Add("qwerty");
            FrUsers.Add("1234");
            FrUsers.Add("letmein");
        }
        public static int FreeLogin(string userinput)
        {
            FreeUsers();
            int result = 0;
            foreach (var Free in FrUsers)
            {
                if (Free == userinput)
                {
                    result = 2;
                    break;
                }
                else
                {
                    result = 5;
                }
            }
            return result;
        }
       
        static List<string> PremUsers = new List<string>();
       static List<string> PremGmail = new List<string>();
        
        private static void PremiumUsers(string password, string username)
        {

            PremUsers.Add("A1B2C3");
            PremUsers.Add("D4E5F6");
            PremUsers.Add("G7H8I9");
            PremUsers.Add("J0K1L2");
            PremUsers.Add("M3N4O5");
            PremGmail.Add($"{username}");

        }

        public static int PremiumLogin(string password, string username, string userinput, string userinput1)
        {
            PremiumUsers(password, username);
            int result = 0;
            foreach (var Premium in PremUsers)
            {
                if (Premium == userinput)
                {
                    foreach (var Gmail in PremGmail)
                    {
                        if (Gmail == userinput1)
                        {
                            result = 3;
                            break;
                        }
                        else
                        {
                            result = 6;
                        }
                    }

                    break;
                }
                else
                {
                    result = 5;
                }
            }
            return result;
        }
        




    }
}
