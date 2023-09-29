using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Magazine
{
    class Magazine
    {
        private string name;
        private int yearFounded;
        private string description;
        private string contactPhone;
        private string email;

        public Magazine(string name, int yearFounded, string description, string contactPhone, string email)
        {
            this.name = name;
            this.yearFounded = yearFounded;
            this.description = description;
            this.contactPhone = contactPhone;
            this.email = email;
        }

        public void InputData()
        {
            Console.Write("Введите название журнала: ");
            name = Console.ReadLine();

            Console.Write("Введите год основания журнала: ");
            if (int.TryParse(Console.ReadLine(), out int year))
            {
                yearFounded = year;
            }
            else
            {
                Console.WriteLine("Некорректный ввод для года.");
                yearFounded = 0;
            }

            Console.Write("Введите описание журнала: ");
            description = Console.ReadLine();

            Console.Write("Введите контактный телефон: ");
            contactPhone = Console.ReadLine();

            Console.Write("Введите email: ");
            email = Console.ReadLine();
        }

        public void DisplayData()
        {
            Console.WriteLine("Название журнала: " + GetName());
            Console.WriteLine("Год основания: " + GetYearFounded());
            Console.WriteLine("Описание журнала: " + GetDescription());
            Console.WriteLine("Контактный телефон: " + GetContactPhone());
            Console.WriteLine("Email: " + GetEmail());
        }

        public string GetName()
        {
            return name;
        }

        public int GetYearFounded()
        {
            return yearFounded;
        }

        public string GetDescription()
        {
            return description;
        }

        public string GetContactPhone()
        {
            return contactPhone;
        }

        public string GetEmail()
        {
            return email;
        }
    }

    class Program
    {
        static void Main()
        {

            Magazine magazine = new Magazine("", 0, "", "", "");
            magazine.InputData();
            Console.WriteLine("\nИнформация о журнале:");
            magazine.DisplayData();
            Console.ReadLine();
        }
    }

}
