using System;
using System.IO;

namespace phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void create_file();
            {
                string cur_file = "phonebook.txt";
                if (File.Exists(cur_file))
                {
                    return;
                }
                else
                {
                    FileStream fs = new FileStream("phonebook.txt.", FileMode.Create);
                    fs.Close();
                }
                return;
            }
            Abonent get_number();
            {
                Abonent piple = new Abonent();
                Console.WriteLine("Введите имя абонента:");
                piple.Name = Console.ReadLine();
                Console.WriteLine("Введите номер абонента:");
                piple.phone_number = Convert.ToInt32(Console.ReadLine());
            }
            Abonent get_abonent_by_number(int num);
            {
                Abonent abon = new Abonent();
                Console.WriteLine("");

            }
        }
    }
}
