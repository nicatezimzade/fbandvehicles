using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace facebook
{
    class User
    {
        public string Name;
        public string Surname;
        public string Email;
        public string DateOfBirth;
        public bool isSingle;

        public Post[] Posts;
        public User()
        {
            Console.WriteLine("Yeni user daxil oldu");
        }
        public User(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Console.WriteLine($"{name} {surname}");
        }
        public User(string name, string surname, string email, string dateofbirth, bool issingle):this(name, surname)
        {
            Email = email;
            DateOfBirth = dateofbirth;
            isSingle = issingle;

            Console.WriteLine($"{name} {surname} {email} {dateofbirth} {issingle}");
        }
    }
}
