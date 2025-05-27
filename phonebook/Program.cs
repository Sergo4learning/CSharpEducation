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


        }
    }
}
