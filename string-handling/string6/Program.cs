using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kirjoita jotain: ");
            string userInput;
            userInput = Console.ReadLine().ToUpper();
            int maara = 0;
            string vokaalit = "AEIOUYÄÖ";


            for (int i = 0; i < userInput.Length; i++)
            {
                for (int j = 0; j < vokaalit.Length; j++)
                {
                    if (vokaalit[j] == userInput[i])
                    {
                        maara++;
                        break;
                    }
                }
            }


            Console.WriteLine($"Tekstissäsi {userInput} on {maara} vokaalia.");
            Console.ReadKey();
        }
    }
}