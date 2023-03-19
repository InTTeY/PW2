using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography;
using System.Text;

namespace PW2_3
{
    class CesarChifr
    {
        public char[] message;
        public int key;
        private char[] abc = { 'а', 'б', 'в', 'г', 'д', 'е', 'ё', 'ж', 'з', 'и', 'й', 'к', 'л', 'м', 'н', 'о', 'п', 'р', 'с', 'т', 'у', 'ф', 'х', 'ц', 'ч', 'ш', 'щ', 'ъ', 'ы', 'ь', 'э', 'ю', 'я' };

        public string Encrypt()
        {
            int number_symbol;
            int bias;
            string result;
            for (int i = 0; i < message.Length; i++)
            {
                int j;
                for (j = 0; j < abc.Length; j++)
                {
                    if (message[i] == abc[j])
                    {
                        break;
                    }
                }
                if (j < 33)
                {
                    number_symbol = j;
                    bias = number_symbol + key;
                    if (bias > 32)
                    {
                        bias = bias - 33;
                    }
                    message[i] = abc[bias];
                }
            }
            result = new string(message);
            return result;
        }
        public string Decipher()
        {
            int number_symbol;
            int bias;
            string result;
            for (int i = 0; i < message.Length; i++)
            {
                int j;
                for (j = 0; j < abc.Length; j++)
                {
                    if (message[i] == abc[j])
                    {
                        break;
                    }
                }
                if (j < 33)
                {
                    number_symbol = j;
                    bias = number_symbol + (33 - key);

                    if (bias > 32)
                    {
                        bias = bias - 33;
                    }
                    message[i] = abc[bias];
                }
            }
            result = new string(message);
            return result;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Чтобы выполнить шифрование введите: для шифрования - (ш) или Encrypt( e ), для расшифрования - (р) или Decipher( d ): ");
            string answer = Convert.ToString(Console.ReadLine());
            CesarChifr cesar = new CesarChifr();
            if (answer == "ш" || answer == "Ш" || answer == "e" || answer == "E" || answer == "Encrypt" || answer == "encrypt")
            {
                Console.WriteLine("!!!Шифр производится только в нижнем регистре(автоматический перевод) на русском языке!!!");
                Console.Write("Введите строку для шифрования: ");
                string m = Convert.ToString(Console.ReadLine());
                m = m.ToLower();
                char[] message = m.ToCharArray();
                cesar.message = message;
                Console.Write("Введите ключ: ");
                cesar.key = Convert.ToInt32(Console.ReadLine());
                string result = cesar.Encrypt();
                Console.WriteLine("Зашифрованная строка: " + result);
            }
            else
            {
                if (answer == "р" || answer == "Р" || answer == "d" || answer == "D" || answer == "Decipher" || answer == "decipher")
                {
                    Console.WriteLine("!!!Дешифрация производится только в нижнем регистре(автоматический перевод)!!!");
                    Console.Write("Введите строку для расшифрования: ");
                    string m = Convert.ToString(Console.ReadLine());
                    m = m.ToLower();
                    char[] message = m.ToCharArray();
                    cesar.message = message;
                    Console.Write("Введите ключ: ");
                    cesar.key = Convert.ToInt32(Console.ReadLine());
                    string result = cesar.Decipher();
                    Console.WriteLine("Расшифрованная строка: " + result);
                }
                else
                {
                    Console.WriteLine("Вы не выбрали действие. Производится заверщение программы");
                }
            }
        }
    }
}