using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDb
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello!");
            do
            {
                int choice = Menu();
              //  Work(choice);
            } while (true);
        }
        public static int Menu()
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create;");
            Console.WriteLine("2. Read;");
            Console.WriteLine("3. Update;");
            Console.WriteLine("4. Delete;");
            Console.WriteLine("5. Exit;");
            Console.Write("Your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }
    }
}
