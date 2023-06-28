using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsProblems
{
    internal class WhileLoop
    {
        public void FlipCoinGame()
        {
            int head = 0;
            int tail = 0;
            Random r = new Random();
            while (head != 20 && tail != 20)
            {
                int option = r.Next(1, 3);
                switch (option)
                {
                    case 1:
                        head += 1;
                        break;
                    case 2:
                        tail += 1;
                        break;
                }
            }
            if (head == 20)
            {
                Console.WriteLine("Hurray!! Head Wins. Head count is " + head + " and Tail is " + tail);
            }
            else
            {
                Console.WriteLine("Hurray!! Tail Wins. Tail count is " + tail + " and Head is " + head);
            }
        }
        public void ReverseWord()
        {
            Console.Write("Enter a word: ");
            string word = Console.ReadLine();

            string reversedWord = "";
            int index = word.Length - 1;

            while (index >= 0)
            {
                reversedWord += word[index];
                index--;
            }

            Console.WriteLine("Reversed word: " + reversedWord);
        }
        public void NaturalNumber()
        {
            int n = 1;
            int sum = 0;
            while (n<=5)
            {
                sum += n;
                n++;
            }
            Console.WriteLine(sum);
        }
    }

}
