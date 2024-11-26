using RoupaBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace loja_roupa
{
    internal class Produtos
    {
        List<produtoCad> Listaprodutos = new List<produtoCad>();


        public produtoCad cadProduto()
        {

            Console.Clear();
            Console.WriteLine("Cadastro de Produtos:");

            Console.WriteLine("\n Digite a descrição do produto:");
            string descPro = Console.ReadLine();

            var Produto = new produtoCad(descPro);

            Console.WriteLine("\n Digite o nome da marca do produto:");
            string marcaPro = Console.ReadLine();
            Produto.MarcaPro = marcaPro;


            Console.WriteLine("\n Digite o tamanho do produto:");
            string tamPro = Console.ReadLine();
            Produto.TamPro = tamPro;


            Console.WriteLine("\n Digite a cor do produto:");
            string corPro = Console.ReadLine();
            Produto.CorPro = corPro;


            Console.WriteLine("\n Digite a categoria do produto:");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro;


            Console.WriteLine("\n Digite o valor do produto:");
            double valPro = double.Parse(Console.ReadLine());
            Produto.ValPro = valPro;


            Console.WriteLine("\n Digite o peso do produto:");
            double pesoPro = int.Parse(Console.ReadLine());
            Produto.PesoPro = pesoPro;

            Listaprodutos.Add(Produto);

            Console.WriteLine($"produto cadastrado com sucesso!!!");
            foreach (var produto in Listaprodutos)
            {
                Console.WriteLine($"Desrição:  {produto.DescPro}, " + $"Valor:{produto.ValPro} ");
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();

            cabecalho variavelCabecalho = new cabecalho();
            variavelCabecalho.exibir_cabecalho();

            Produtos varPro = new Produtos();
            ExibirMenu variavelMenu = new ExibirMenu();

            return Produto;
        }
    }
}