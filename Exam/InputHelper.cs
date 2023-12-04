using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class InputHelper
    {
        public static string ReadString(string inputMessage)
        {
            Console.WriteLine(inputMessage);
            string? value = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(value))
            {
                return value;
            }

            Console.WriteLine("Попробуйте еще раз.");
            return ReadString(inputMessage);
        }

        public static int ReadNumber(string inputMessage)
        {
            string value = ReadString(inputMessage);
            if (int.TryParse(value, out int number))
            {
                return number;
            }

            Console.WriteLine("Веддите корректное число");
            return ReadNumber(inputMessage);
        }

    }
}