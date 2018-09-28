using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main()
        {
            string holder;
            string a;
            string b;
            string c;
            string concatenate;
            string sentence = "";



            Console.WriteLine("Concatenation is a thing.");
            a = Console.ReadLine();
            b = Console.ReadLine();
            c = Console.ReadLine();
            concatenate = a + b + c;
            Console.WriteLine(concatenate);

            Console.WriteLine("Write a sentence to be put into U P P E R C A S E");
            holder = Console.ReadLine();
            Console.WriteLine(holder.ToUpper());

            Console.WriteLine("Write a paragraph one sentence at a time.");
            do
            {
                holder = Console.ReadLine();
                if (holder != "fin")
                {
                    sentence += holder;
                }

            } while (holder != "fin");
            Console.WriteLine(sentence);
            Console.ReadLine();


        }
    }
}
