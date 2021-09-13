using System;

namespace ConsoleApp1_imon_
{
    class Program
    {
        static void Main(string[] args)
        {
            int t;
            string str ,pw;
          

            for ( t=3; t >= 1; t--)
            {
                Console.WriteLine("Username (admin.com) :");
                str = Console.ReadLine();
                Console.WriteLine("Password (minimum 5 character) :");
                pw= Console.ReadLine();
                int pwLength = pw.Length;

                // username 
                string s1 = ".com";
                bool bo = str.Contains(s1);

                if (bo == true && pwLength >=5)
                {
                    Console.WriteLine("Thank you, "+str+".");
                    break;
                }
                else
                {
                    Console.WriteLine("!! Check in the Username or password , " + (t-1)+ " try again");
                   

                }
                
            }
        

            }
        }
    }

