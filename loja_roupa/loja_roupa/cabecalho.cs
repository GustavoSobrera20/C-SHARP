using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace RoupaBox

{

    internal class cabecalho

    {

        public void exibir_cabecalho() 

        {

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("==============================");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Autor: gustavo sobrera");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("==============================");

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"
 
    ██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
    ██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
    ██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
    ██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
    ██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
    ╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");

            Console.ResetColor();

            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("==============================");

            Console.ResetColor();

            ExibirMenu menu = new ExibirMenu();

        }

    }

}
