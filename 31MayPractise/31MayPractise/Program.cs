using System;

namespace _31MayPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Human human1 = new Human("Elnur Khalilov") { Age = 21 };

            Console.WriteLine(human1.Name);
            Console.WriteLine(human1.Surname);


            Console.WriteLine(human1.GeneratePassword());



            string sentence = "salam p227 telebeleri necesiniz";

            string[] arr = sentence.Split(' ');
            int count = 0;
            int digitCounter = 0;
            foreach (var item in arr)
            {
                //if (item.Contains('a'))
                //{
                //    count++;
                //}

                for (int i = 0; i < item.Length; i++)
                {
                    if (Char.IsDigit(item[i]))
                    {
                        digitCounter++;
                    }
                }
            }



            Console.WriteLine(count);
            Console.WriteLine(digitCounter);
            Console.WriteLine(arr.Length);
        }
    }
}
