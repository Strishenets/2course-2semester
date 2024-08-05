using System;
using System.Text;

namespace OOP_11
{
    internal class Program
    {
        static string EncryptText(string text, int shift)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    char encryptedChar = (char)(c + shift);
                    if ((char.IsLower(c) && encryptedChar > 'z') || (char.IsUpper(c) && encryptedChar > 'Z'))
                    {
                        encryptedChar = (char)(c - (26 - shift));
                    }
                    result += encryptedChar;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }
        static string DecryptText(string text, int shift)
        {
            return EncryptText(text, -shift);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your fullname: ");
            string sentence = Console.ReadLine();
            string[] SNP = sentence.Split(' ');
            string Surname = SNP[0], Name = SNP[1], Patronymic = SNP[2];
            Console.OutputEncoding = Encoding.UTF8;

        
 
            int SurnameLength, NameLength, PatronymicLength;
            SurnameLength = Surname.Length;
            NameLength = Name.Length;
            PatronymicLength = Patronymic.Length;

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"Surname length: {SurnameLength}\nName length: {NameLength}\nPatronymic length: {PatronymicLength}");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Surname length: {SurnameLength}");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Performed by a student of the specialty Software Engineering\nGroup 22007b");
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("Enter the text to encrypt:");
            string inputText = Console.ReadLine();

            string encryptedText = EncryptText(inputText, 2);
            Console.WriteLine("Encrypted text: " + encryptedText);

            string decryptedText = DecryptText(encryptedText, 2);
            Console.WriteLine("Decrypted text: " + decryptedText);
            Console.WriteLine("--------------------------------------------------\n\n");
        }

    }
}
