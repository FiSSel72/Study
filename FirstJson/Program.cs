using Newtonsoft.Json;
using System;
using System.IO;

namespace FirstJson
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = File.Exists("user.json")? JsonConvert.DeserializeObject<User>(File.ReadAllText("user.json")): new User 
            {
                age = 17,
                FirstName = "Artem",
                LastName = "Golovchenko"
                
            };

            user.age++;

            File.WriteAllText("user.json", JsonConvert.SerializeObject(user));

            Console.ReadKey();
        }
    }
}
