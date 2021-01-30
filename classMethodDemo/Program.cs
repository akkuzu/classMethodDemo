using System;

namespace classMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Id = "1001";
            user1.FirstName = "Ayça";
            user1.LastName = "Kahraman";

            User user2 = new User();
            user2.Id = "1002";
            user2.FirstName = "Tarık";
            user2.LastName = "Sarı";

            User user3 = new User();
            user3.Id = "1003";
            user3.FirstName = "Esma";
            user3.LastName = "Yıldırım";

            UserManager userManager = new UserManager();
            userManager.Add(user1);
            userManager.Add(user2);
            userManager.Add(user3);

            User[] users = new User[] { user1, user2, user3 };
            foreach (var user in users)
            {
                Console.WriteLine(user.FirstName);
            }
        }

    }
}
