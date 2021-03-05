using System;
using System.Linq;

namespace ConsoleApp37_2
{
    class Program
    {
        static void Main(string[] args)
        {
            using (firstdbContext db = new firstdbContext())
            {
                var users = db.Users.ToList();                  
                Console.WriteLine("Список объектов: ");
                foreach (User u in users)                       
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            Console.ReadKey();
        }
    }
}

