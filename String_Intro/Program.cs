using System;

namespace String_Intro
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var fullName = "Milo MacPhail ";
            Console.WriteLine("Trim: '{0}'", fullName.Trim());
            Console.WriteLine("Trim: '{0}'", fullName.Trim().ToUpper());

            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            var names = fullName.Split(' ');
            Console.WriteLine("First Name: " + names[0]);
            Console.WriteLine("Last Name: " + names[1]);


            Console.WriteLine(fullName.Replace("Milo MacPhail", "Charlotte Campbell"));

            if (string.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            Console.WriteLine(price.ToString("C"));

        }
    }
}