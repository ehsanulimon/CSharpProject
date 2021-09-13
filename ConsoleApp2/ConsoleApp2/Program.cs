using System;
using System.IO;
//______-_

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//__________________________
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            data_W();
            data_r();
        }
        public static void data_W()
        {

            if (!File.Exists(@"B:/sp-2020.txt"))
            {
                File.Create(@"B:/sp-2020.txt").Close();
            }
            String name, age, nid, salary, position;
            Console.WriteLine(" please enter name, age, nid, salary, position");
            name = Console.ReadLine();
            age = Console.ReadLine();
            nid = Console.ReadLine();
            salary = Console.ReadLine();
            position = Console.ReadLine();
            try
            {

                StreamWriter sw = File.AppendText(@"B:/sp-2020.txt");

                sw.WriteLine(name);
                sw.WriteLine(age);
                sw.WriteLine(nid);
                sw.WriteLine(salary);
                sw.WriteLine(position);

                sw.Close();


            }
            catch(FileNotFoundException ex)
            {
                Console.WriteLine(ex);
            }
            

        }
        public static void data_r()
        {
            StreamReader sr = new StreamReader(@"B:/sp-2020.txt");
            String name="abc", age, nid, salary, position;
           
            while (name!= null)
            {
                name = sr.ReadLine();
                age = sr.ReadLine();
                nid = sr.ReadLine();
                salary = sr.ReadLine();
                position = sr.ReadLine();
                if(name!= null)
                {
                    Console.WriteLine("name : " + name + "\n age : " + age + "\n nid : " + nid + " \n salary : " + salary + " \n position : " + position);
                }
                
            }
            Console.ReadLine();
        }
       
        
    }
}
