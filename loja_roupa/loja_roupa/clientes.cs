using loja_roupa;
using Roupabox;
using RoupaBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Clientes
    {
        List<clienteCad> listaClientes = new List<clienteCad>();
        public clienteCad cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();
            var Cliente = new clienteCad(nomeCli);

            Console.WriteLine("\n Digite o CPF do cliente: ");
            string cpfCli = Console.ReadLine();
            Cliente.cpfCli = cpfCli;
            while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))
            {
                Console.WriteLine("CPF invalido. faz de novo!");
                cpfCli = Console.ReadLine();
            }

            Console.WriteLine("\n Digite o Telefone do cliente: ");
            string telCli = Console.ReadLine();
            Cliente.telCli = telCli;

            Console.WriteLine("\n Digite o Idade do cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());
            Cliente.idadeCli = idadeCli;

            Console.WriteLine("\n Digite o E-mail do cliente: ");
            string mailCli = Console.ReadLine();
            Cliente.mailCli = mailCli;

            Console.WriteLine("\n Digite o Sexo caso tenha: ");
            string sexCli = Console.ReadLine();
            Cliente.sexoCli = sexCli;

            Console.WriteLine("\n Digite a rua da casa do cliente: ");
            string ruaCli = Console.ReadLine();
            Cliente.ruaCli = ruaCli;

            Console.WriteLine("\n Digite o complemento do cliente: ");
            string compleCli = Console.ReadLine();
            Cliente.cepCli = compleCli;

            Console.WriteLine("\n Digite o numero da casa do cliente: ");
            int numCli = int.Parse(Console.ReadLine());
            Cliente.numCli = numCli;

            Console.WriteLine("\n Digite o estado do cliente: ");
            string estaCli = Console.ReadLine();
            Cliente.estCli = estaCli;

            Console.WriteLine("\n Digite o CEP do cliente: ");
            string cepCli = Console.ReadLine();
            Cliente.cepCli = cepCli;

            listaClientes.Add(Cliente);
            Console.WriteLine("\nCliente cadastrado com sucesso!!!");
            foreach (var Clientes in listaClientes)
            {
                Console.WriteLine($"Nome: {Cliente.nomeCli}, " + $"cpf: {Cliente.cpfCli}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();


            cabecalho variavelCabecalho = new cabecalho();
            variavelCabecalho.exibir_cabecalho();

            ExibirMenu varmenu = new ExibirMenu();
            //varmenu.Menu();

            return Cliente;
        }
    }
}
