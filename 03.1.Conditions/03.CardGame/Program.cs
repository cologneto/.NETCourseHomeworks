using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CardGame
{
    class Program
    {
        static void Main()
        {
            char symbol = char.Parse(Console.ReadLine());
            switch (symbol)
	        {
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case 'J':
                case 'Q':
                case 'K':
                case 'A':
                    Console.WriteLine("Valid card");
                    break;
		        default:
                    Console.WriteLine("Not valid card");
                    break;
	        }
           
        }
    }
}
