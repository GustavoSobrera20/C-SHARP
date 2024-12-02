using loja_roupa;
using Roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoupaBox
{
    public class Program
    {
        public static void Main(string[] args)
        {
            cabecalho varcabecalho = new cabecalho();
            varcabecalho.exibir_cabecalho();

            Produtos varPro = new Produtos();
            Clientes varCli = new Clientes();

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varPro, varCli);

 


        }
    }
}