using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            while(true)
            {
                Console.WriteLine("Press 1 to Add new employee info and 2 for show all employee, 3 for employee info update, 4 for delete, and press any other number to exit:");
                choice = Int32.Parse(Console.ReadLine());
                if (choice == 1)
                {
                    data_write();
                }
                else if(choice==2)
                {
                    data_read();
                }
                else if(choice==3)
                {
                    data_update();
                }
                else if(choice==4)
                {
                    data_delete();
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


          
            string search_name;
            int found = 0;
            Console.WriteLine("Enter the employee name to show details:");
            search_name = Console.ReadLine();

            while (name!=null)
            {

                name = sr.ReadLine();
                age = sr.ReadLine();
                nid = sr.ReadLine();
                salary = sr.ReadLine();
                position = sr.ReadLine();
                if (name !=null && name.ToUpper().Equals(search_name.ToUpper()))
                {
                    found = 1;
                    Console.WriteLine("Name: " + name + " Age:  " + age + " NID: " + nid + " Salary: " + salary + " Position: " + position+"\n");
                    break;
                }
            }

            if(found==0)
            {
                Console.WriteLine("No such emplyee exists.");
            }
            sr.Close();
            Console.ReadLine();
        }


        public static void data_update()
        {
            StreamReader sr = new StreamReader(@"E:/sp_20.txt");

            List<string> name = new List<string>();
            List<string> age = new List<string>();
            List<string> nid = new List<string>();
            List<string> salary = new List<string>();
            List<string> position = new List<string>();


            string search_name, new_salary;
            Console.WriteLine("Enter Employee name and new salary:");
            search_name = Console.ReadLine();
            new_salary = Console.ReadLine();
            string n="abc";


            while (n != null)
            {
                n = sr.ReadLine();

                name.Add(n);
                age.Add(sr.ReadLine());
                nid.Add(sr.ReadLine());
                salary.Add(sr.ReadLine());
                position.Add(sr.ReadLine());
                
            }

            string[] arr_name = name.ToArray();
            string[] arr_age = age.ToArray();
            string[] arr_nid = nid.ToArray();
            string[] arr_salary = salary.ToArray();
            string[] arr_position = position.ToArray();


            for (int i = 0; i < arr_name.Length-1; i++)
            {
                Console.WriteLine(i+". "+ arr_name[i]);
            }

            
            for (int i=0;i<arr_name.Length-1;i++)
            {
                if(search_name.ToUpper().Equals(arr_name[i].ToUpper()))
                {
                    arr_salary[i] = new_salary;
                }
            }
            
            sr.Close();

            StreamWriter sw = new StreamWriter(@"E:/sp_20.txt");


            for (int i = 0; i < arr_name.Length-1; i++)
            {
                if(arr_name[i] == null)
                {
                    continue;
                }
                sw.WriteLine(arr_name[i]);
                sw.WriteLine(arr_age[i]);
                sw.WriteLine(arr_nid[i]);
                sw.WriteLine(arr_salary[i]);
                sw.WriteLine(arr_position[i]);
            }
            sw.Close();

        }

        public static void data_delete()
        {
            StreamReader sr = new StreamReader(@"E:/sp_20.txt");

            List<string> name = new List<string>();
            List<string> age = new List<string>();
            List<string> nid = new List<string>();
            List<string> salary = new List<string>();
            List<string> position = new List<string>();


            string search_name;
            Console.WriteLine("Enter Employee name to delete:");
            search_name = Console.ReadLine();
           
            string n = "abc";


            while (n != null)
            {
                n = sr.ReadLine();

                name.Add(n);
                age.Add(sr.ReadLine());
                nid.Add(sr.ReadLine());
                salary.Add(sr.ReadLine());
                position.Add(sr.ReadLine());

            }

            string[] arr_name = name.ToArray();
            string[] arr_age = age.ToArray();
            string[] arr_nid = nid.ToArray();
            string[] arr_salary = salary.ToArray();
            string[] arr_position = position.ToArray();

            sr.Close();

            StreamWriter sw = new StreamWriter(@"E:/sp_20.txt");


            for (int i = 0; i < arr_name.Length-1; i++)
            {
                //Console.WriteLine(i+". "+ arr_name[i]);

                if (search_name.ToUpper().Equals(arr_name[i].ToUpper()))
                {
                    continue;
                }
                sw.WriteLine(arr_name[i]);
                sw.WriteLine(arr_age[i]);
                sw.WriteLine(arr_nid[i]);
                sw.WriteLine(arr_salary[i]);
                sw.WriteLine(arr_position[i]);
            }
            sw.Close();

        }

    }
}