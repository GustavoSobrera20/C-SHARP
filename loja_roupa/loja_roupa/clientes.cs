using loja_roupa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace RoupaBox
{
    internal class clientes
    {
        public void cadCliente()
        {
           




            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("Digite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();

            Console.WriteLine(" Digite o CPF do cliente: ");
            long cpfCli = long.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o telefone do cliente: ");
            long telCli = long.Parse(Console.ReadLine());

            Console.WriteLine(" Digite a idade do cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o e-mail do cliente: ");
            string emailCli = Console.ReadLine();
            while (!emailCli.Contains("@"))
            {
                Console.WriteLine("o endereço de email não é valido, tente novamente!");
                emailCli = Console.ReadLine();
            }

            Console.WriteLine(" Digite o sexo do cliente: ");
            string sexoCli = Console.ReadLine();

            Console.WriteLine(" Digite a rua/avenida do cliente: ");
            string ruaCli = Console.ReadLine();

            Console.WriteLine(" Digite o complemento da rua, caso tenha: ");
            string compCli = Console.ReadLine();

            Console.WriteLine(" Digite o número da casa do cliente: ");
            int numCli = int.Parse(Console.ReadLine());

            Console.WriteLine(" Digite o bairro do cliente: ");
            string bairroCli = Console.ReadLine();

            Console.WriteLine(" Digite a cidade do cliente: ");
            string cidCli = Console.ReadLine();

            Console.WriteLine(" Digite o estado do cliente: ");
            string estCli = Console.ReadLine();

            Console.WriteLine(" Digite o CEP do cliente: ");
            int cepCli = int.Parse(Console.ReadLine());

            Console.WriteLine("Cliente cadastrado com sucesso!!!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal.");
            Console.ReadLine();

            Console.Clear();

            cabecalho varcabecalho = new cabecalho();
            varcabecalho.exibir_cabecalho();

            Produtos varPro = new Produtos();
            clientes varCli = new clientes();



            Menu varmenu = new menu();
            varmenu.exibir_menu();

           }
        }
    }
