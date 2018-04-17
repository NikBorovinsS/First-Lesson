//Author: Мария Дегтяренко
//Task: Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата заполнения анкеты).
//Поле дата заполнения анкеты должно быть проинициализировано только один раз(при создании
//экземпляра данного класса) без возможности его дальнейшего изменения.
//Реализуйте вывод на экран информации о пользователе.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_5
{
    class User
    {
        public string Login { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Age { get; set; }
        private readonly DateTime registrationDate;

        public User(string login, string name, string surname, uint age, DateTime date)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            registrationDate = date;
        }

        public string ShowUser()
        {
            return string.Format("Login: "+Login+"\nName: "+Name+"\nSurname: "+Surname+"\nAge: "+Age+"\nRegistration date: "+registrationDate.ToString("d")+"\n");
        }

    }

    class Classes_5
    {
        static void Main(string[] args)
        {
            User user1 = new User("admin123", "Lucy", "Hale", 25, new DateTime(2007, 10, 31));
            Console.WriteLine(user1.ShowUser());
            Console.ReadKey();
        }
    }
}
