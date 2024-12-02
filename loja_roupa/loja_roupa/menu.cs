using loja_roupa;
using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    internal class ExibirMenu
    {
        public void Menu(Produtos varPro, Clientes varCli)

        {
            List<produtoCad> listaP = new List<produtoCad>();
            List<clienteCad> listac = new List<clienteCad>();    
            Console.WriteLine("\nDigite 0 para sair");
            Console.WriteLine("\nDigite 1 para cadastro de clientes");
            Console.WriteLine("\nDigite 2 para listar clientes");
            Console.WriteLine("\nDigite 3 para cadastro de produtos");
            Console.WriteLine("\nDigite 4 para listar produtos");
            Console.WriteLine();
            Console.WriteLine("Digite a opção escolhida");
            int OpcoesMenu = int.Parse(Console.ReadLine());

            switch (OpcoesMenu)
            {
                case 0:

                    Console.WriteLine("");
                    break;

                case 1:

                    varCli.cadCliente();
                    break;

                case 2:

                    Console.WriteLine("");
                    break;

                case 3:

                    varPro.cadProduto();
                    break;

                case 4:
                    varPro.ListaProdutos(); 

                    break;

            }
        }
    }
}