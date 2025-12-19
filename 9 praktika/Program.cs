using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_praktika
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            string name = "анна";
            string Name2 = char.ToUpper(name[0]) + name.Substring(1).ToLower();
            string city = "москва";
            string CITY = city.ToUpper();
            Console.WriteLine(Name2);
            Console.WriteLine(CITY);
            Console.WriteLine($"Привет, {Name2} из {CITY}!");

            ////Задание 2
            string text = "C# это современный язык программирования.";
            Console.WriteLine("Общее количество символов: ");
            int len = text.Length;
            string[] words = text.Split(' ');
            Console.WriteLine(text.Length);
            Console.WriteLine("Количество слов: ");
            int wordCount = words.Length;
            Console.WriteLine(wordCount);
            Console.WriteLine("Индекс: ");
            int position = text.IndexOf("язык");
            Console.WriteLine(position);
            bool start = text.StartsWith("C#");
            Console.WriteLine("Текст начинается с с#: " + start);


            //Задание 3
            string phone = "+79161234567";
            string Country = phone.Substring(0, 2);
            string Operator = phone.Substring(2, 3);
            string number123 = phone.Substring(5, 3);
            string number45 = phone.Substring(8, 2);
            string number67 = phone.Substring(10, 2);
            string phoneFormat2 = $"{Country} ({Operator}) {number123}-{number45}-{number67} ";
            Console.WriteLine(phoneFormat2);


            //Задание 4
            string email = "user.example@gmail.com";
            Console.WriteLine(email);
            if (email.Contains("@"))
            {
                int index = email.IndexOf("@");
                string user = email.Substring(0, index);
                string gmail = email.Substring(index + 1);
                string star = new string('*', user.Length);
                string email2 = $"{star}@{gmail}";
                Console.WriteLine($"Скрытый email: {email2}");
            }


            //Задание 5
            Console.Write("Введите слово: ");
            string word = Console.ReadLine().ToLower();
            int left = 0;
            int right = word.Length - 1;
            bool Palindrom = true;
            while (left < right)
            {
                if (word[left] != word[right])
                {
                    Palindrom = false;
                    break;
                }
                left++;
                right--;
            }
            if (Palindrom)
            {
                Console.WriteLine($"Слово {word} полидром");
            }
            else
            {
                Console.WriteLine($"Слово {word} не полидром");
            }


            //Задание 6
            StringBuilder sb = new StringBuilder("Числа: ");
            for (int i = 1; i <= 10; i++)
            {
                sb.Append(i);
                if (i < 10)
                {
                    sb.Append(',');
                }
            }
            sb.Append('.');
            Console.WriteLine(sb.ToString());


            // Задание 7
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    sb.Append($"{i} x {j} = {i * j}");
                    sb.AppendLine();
                }
                if (i < 5)
                {
                    sb.AppendLine();
                }
            }
            Console.WriteLine(sb.ToString());

            // Задание 8
            string fruits = "яблоко,банан ,aпельсин,киви, груша";
            string[] fruitArray = fruits.Split(',');
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }

            for (int i = 0; i < fruitArray.Length; i++)
            {
                fruitArray[i] = fruitArray[i].Trim(); // убирает пробелы в начале и в конце
            }
            Console.WriteLine();
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
            Console.WriteLine();
            Array.Sort(fruitArray);
            for (int i = 0; i < fruitArray.Length; i++)
            {
                Console.WriteLine(fruitArray[i]);
            }
            Console.WriteLine();
            string result = string.Join("; ", fruitArray);
            Console.WriteLine($"Ожидаемый результат: " + result);

            //Задание 9
            Console.WriteLine("Введите слово на английском строчными буквами");
            string shifr = Console.ReadLine();
            int sdvig = 3;
            StringBuilder sb = new StringBuilder();
            foreach (char c in shifr)
            {
                if (c >= 'a' && c <= 'z')
                {
                    char cezar = (char)(((c - 'a' + sdvig) % 26) + 'a');
                    sb.Append(cezar);
                }
            }
            Console.WriteLine($"Зашифровано: {sb}");

            //Задание 10
            Random random = new Random();
            StringBuilder password = new StringBuilder();
            for (int i = 0; i < 3; i++)
            {
                char lowerLetter = (char)('a' + random.Next(0, 26));
                password.Append(lowerLetter);
            }
            for (int i = 0; i < 3; i++)
            {
                char digit = (char)('0' + random.Next(0, 10));
                password.Append(digit);
            }
            for (int i = 0; i < 2; i++)
            {
                char upLetter = (char)('A' + random.Next(0, 26));
                password.Append(upLetter);
            }
            Console.WriteLine("Пример возможного пароля: " + password);


        }
    }
}
