using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Spring_20_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            while(true)
            {
                Console.WriteLine("Press 1 to Add new employee info and 2 for show all employee and press any other number to exit:");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    data_write();
                }
                else if(choice==2)
                {
                    data_read();
                }
                else
                {
                    Console.WriteLine("Thank you for using this sogtware...");
                    Console.ReadLine();
                    break;
                }

            }



        }

        public static void data_write()
        {
            if (!File.Exists(@"E:/sp_20.txt"))
            {
                File.Create(@"E:/sp_20.txt").Close();
            }

            string name, age, nid, salary, position;

            Console.WriteLine("Please Enter Employee Name, Age, NID, Salary and Position:");
            name = Console.ReadLine();
            age = Console.ReadLine();
            nid = Console.ReadLine();
            salary = Console.ReadLine();
            position = Console.ReadLine();

            try
            {
                StreamWriter sw = File.AppendText(@"E:/sp_20.txt");

                sw.WriteLine(name);
                sw.WriteLine(age);
                sw.WriteLine(nid);
                sw.WriteLine(salary);
                sw.WriteLine(position);

                sw.Close();
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }

        }

        public static void data_read()
        {
            StreamReader sr = new StreamReader(@"E:/sp_20.txt");

            string name="abc", age, nid, salary, position;

            while(name!=null)
            {
                name = sr.ReadLine();
                age = sr.ReadLine();
                nid = sr.ReadLine();
                salary = sr.ReadLine();
                position = sr.ReadLine();
                if (name != null)
                {
                    Console.WriteLine("Name: " + name + " Age:  " + age + " NID: " + nid + " Salary: " + salary + " Position: " + position+"\n");
                }
            }

            Console.ReadLine();
        }
    }
}