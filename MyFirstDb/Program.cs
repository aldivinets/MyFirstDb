using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstDb.DataModel;

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
                Work(choice);
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

        public static void Work(int choice)
        {
            switch (choice)
            {
                case 1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Country: ");
                    string country = Console.ReadLine();
                    Console.Write("Capacity: ");
                    int capacity = Convert.ToInt32(Console.ReadLine());
                    Create(name, country, capacity);
                    Console.WriteLine("OK!");
                    break;
              /*  case 2:
                    Read();
                    break;
                case 3:
                    Read();
                    Console.Write("Enter number:");
                    int upd = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Name: ");
                    string n_name = Console.ReadLine();
                    Console.Write("Country: ");
                    string n_country = Console.ReadLine();
                    Console.Write("Capacity: ");
                    int n_capacity = Convert.ToInt32(Console.ReadLine());
                    Update(upd, n_name, n_country, n_capacity);
                    Console.WriteLine("Update!");
                    break;
                case 4:
                    Read();
                    Console.Write("Enter number:");
                    int del = Convert.ToInt32(Console.ReadLine());
                    Delete(del);
                    Console.WriteLine("Delete!");
                    break; */
                case 5:
                    Console.WriteLine("Bye!");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Enter other number!");
                    break;
            }
        }
        public static void Create(string name, string country, int capacity)
        {
            using (TeamContext db = new TeamContext())
            {
                Team team = new Team { Name = name, Country = country, Capacity = capacity };
                db.Teams.Add(team);
                db.SaveChanges();
            }
        }
    }
}
