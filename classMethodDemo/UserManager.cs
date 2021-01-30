using System;
using System.Collections.Generic;
using System.Text;

namespace classMethodDemo
{
    class UserManager
    {
        public void Add ( User user )
        {
            Console.WriteLine("Sisteme başarıyla kaydoldunuz. " + user.FirstName );
        }

        public void DeleteUser (User user)
        {
            Console.WriteLine(user.FirstName + user.LastName + "Hesabınız başarıyla silindi.");

        }

        public void ListUser ( User user) 
        {
            {
                Console.WriteLine(user.Id);
            }
        }

        




    }
}
