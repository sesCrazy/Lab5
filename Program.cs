using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Изменение
            var num = Console.ReadLine();
            var phone = "12345678901234";
            Regex regex = new Regex(@"^\(?([0-9]{7})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$");
            if (regex.IsMatch(num))
            {
                var formatedPhone = regex.Replace(num, "($1) $2-$3");
                Console.WriteLine(formatedPhone);
            }
            else
            {
                Console.WriteLine("Повторите попытку");
                Console.WriteLine("Недопустимый формат номера");
            }
            Console.ReadLine();
            
        }
    }
}
