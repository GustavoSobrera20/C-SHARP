using RoupaBox;
using System;
using System.Collections.Generic;

namespace loja_roupa
{
    internal class Produtos
    {
        List<produtoCad> Listaprodutos = new List<produtoCad>();

        public produtoCad cadProduto(ExibirMenu exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Produtos:");

            Console.WriteLine("\nDigite a descrição do produto:");
            string descPro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(descPro)) // Verificação de descrição vazia
            {
                Console.WriteLine("Descrição inválida, tente novamente.");
                return null;
            }

            var Produto = new produtoCad(descPro);

            Console.WriteLine("\nDigite o nome da marca do produto:");
            string marcaPro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(marcaPro)) // Verificação de marca vazia
            {
                Console.WriteLine("Marca inválida, tente novamente.");
                return null;
            }
            Produto.MarcaPro = marcaPro;

            Console.WriteLine("\nDigite o tamanho do produto:");
            string tamPro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(tamPro)) // Verificação de tamanho vazio
            {
                Console.WriteLine("Tamanho inválido, tente novamente.");
                return null;
            }
            Produto.TamPro = tamPro;

            Console.WriteLine("\nDigite a cor do produto:");
            string corPro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(corPro)) // Verificação de cor vazia
            {
                Console.WriteLine("Cor inválida, tente novamente.");
                return null;
            }
            Produto.CorPro = corPro;

            Console.WriteLine("\nDigite a categoria do produto:");
            string catPro = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(catPro)) // Verificação de categoria vazia
            {
                Console.WriteLine("Categoria inválida, tente novamente.");
                return null;
            }
            Produto.catPro = catPro;

            double valPro;
            Console.WriteLine("\nDigite o valor do produto:");
            if (!double.TryParse(Console.ReadLine(), out valPro) || valPro <= 0) // Verificação de valor válido
            {
                Console.WriteLine("Valor inválido, tente novamente.");
                return null;
            }
            Produto.ValPro = valPro;

            double pesoPro;
            Console.WriteLine("\nDigite o peso do produto:");
            if (!double.TryParse(Console.ReadLine(), out pesoPro) || pesoPro <= 0) // Verificação de peso válido
            {
                Console.WriteLine("Peso inválido, tente novamente.");
                return null;
            }
            Produto.PesoPro = pesoPro;

            Listaprodutos.Add(Produto);

            Console.WriteLine($"Produto cadastrado com sucesso!!!");

            cabecalho variavelCabecalho = new cabecalho();
            variavelCabecalho.exibir_cabecalho();

            ExibirMenu menu = new ExibirMenu();

            return Produto;
        }

        public void ListaProdutos()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos Cadastrados");

            if (Listaprodutos.Count == 0) // Verificação de lista vazia
            {
                Console.WriteLine("Nenhum produto cadastrado.");
            }
            else
            {
                foreach (var produto in Listaprodutos)
                {
                    Console.WriteLine($"Descrição: {produto.DescPro}, Valor: {produto.ValPro}, Peso: {produto.PesoPro}");
                }
            }

            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();

            cabecalho variavelCabecalho = new cabecalho();
            variavelCabecalho.exibir_cabecalho();
        }
    }
}
