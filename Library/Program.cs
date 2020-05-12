using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class Human
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public void InBase(string NameAndSurname)
        {
            string[] cut = NameAndSurname.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Name = cut[0];
            Surname = cut[1];
            
        }
        public string Display()
        {
            string temp  = Name + " " + Surname;
            return temp;
        }
    }

    class Author : Human
    {
        public string BookName { get; set; }
    }
    class User : Human
    {
        public string MyBook { get; set; }
           
    }

    static class Program
    {
        public static List<Author> authors = new List<Author>();
        public static List<User> users = new List<User>();
        public static List<User> InfoBase = new List<User>();
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Menu());
        }
    }
}
