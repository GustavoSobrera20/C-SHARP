using System;
using System.Threading;

namespace exercitando
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r\n███████╗██╗░░██╗███████╗██████╗░░█████╗░██╗░█████╗░██╗░█████╗░░██████╗" +
                             "\r\n██╔════╝╚██╗██╔╝██╔════╝██╔══██╗██╔══██╗██║██╔══██╗██║██╔══██╗██╔════╝" +
                            "\r\n█████╗░░░╚███╔╝░█████╗░░██████╔╝██║░░╚═╝██║██║░░╚═╝██║██║░░██║╚█████╗░" +
                           "\r\n██╔══╝░░░██╔██╗░██╔══╝░░██╔══██╗██║░░██╗██║██║░░██╗██║██║░░██║░╚═══██╗" +
                          "\r\n███████╗██╔╝╚██╗███████╗██║░░██║╚█████╔╝██║╚█████╔╝██║╚█████╔╝██████╔╝" +
                         "\r\n╚══════╝╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═╝░╚════╝░╚═╝░╚════╝░╚═════╝░");

            Console.WriteLine("autor: Gustavo Sobrera Nunes Dos Santos");
            Console.WriteLine("menu");
            Console.WriteLine("digite 0 para sair");
            Console.WriteLine("digite 1 para entrar na atividade 1");
            Console.WriteLine("digite 2 para entrar na atividade 2");
            Console.WriteLine("digite 3 para entrar na atividade 3");
            Console.WriteLine("digite 4 para entrar na atividade 4");
            Console.WriteLine("digite 5 para entrar na atividade 5");
            Console.WriteLine("digite 6 para entrar na atividade 6");

            int opcaoEscolhida = int.Parse(Console.ReadLine());

            switch (opcaoEscolhida)
            {
                case 0:
                    Console.WriteLine("saindo...");
                    return;
                case 1:
                    Atividade1();
                    break;
                case 2:
                    Atividade2();
                    break;
                case 3:
                    Atividade3();
                    break;
                case 4:
                    Atividade4();
                    break;
                case 5:
                    Atividade5();
                    break;
                case 6:
                    Atividade6();
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }

        public static void Atividade1()
        {
            Console.WriteLine("forneça seu numero para verificar se ele é positivo ou negativo");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            if (numeroEscolhido > 0)
            {
                Console.WriteLine("seu numero é positivo");
            }
            else if (numeroEscolhido < 0)
            {
                Console.WriteLine("seu numero é negativo");
            }
            else
            {
                Console.WriteLine("seu numero é zeroooo.");
            }
        }


        public static void Atividade2()
        {

            Console.WriteLine("forneça a sua idade para verificarmos se você é maior de idade ou menor de idade");
            int NumeroEscolhido = int.Parse(Console.ReadLine());

            if (NumeroEscolhido >= 18)
            {
                Console.WriteLine("você é maior de idade meu pequeno jovem ");
            }
            else if (NumeroEscolhido <= 18)
            {
                Console.WriteLine("você é menor de idade meu pequeno garoto(a)");
            }
            else
            {
                Console.WriteLine("não reconhecido");
            }
        }

        public static void Atividade3()
        {
            Console.WriteLine("forneça seu numero para verificarmos se ele é impar ou par");
            int NumeroEscolhido = int.Parse(Console.ReadLine());
            if (NumeroEscolhido % 2 == 0)
            {
                Console.WriteLine("seu numero é par");
            }
            else
            {
                Console.WriteLine("seu numero é impar");
            }
        }


        public static void Atividade4()
        {
            Console.WriteLine("forneça sua letra para verificarmos se ela é uma vogal ou consoante");
            char letra = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("sua letra é uma Vogal");
            }
            else
            {
                Console.WriteLine("não é uma Vogal");
            }
        }

        public static void Atividade5()
        {

            Console.WriteLine("forneça sua idade para verificarmos se você esta aprovado ou reprovado no sistema");
            int numeroEscolhido = int.Parse(Console.ReadLine());

            if (numeroEscolhido >= 7)
            {
                Console.WriteLine("você esta aprovado no sistema");
            }
            if (numeroEscolhido >= 5 && numeroEscolhido < 7)
            {
                Console.WriteLine("esta em recuperação");
            }
            else if (numeroEscolhido >= 0 && numeroEscolhido <= 4)
            {
                Console.WriteLine("você esta reprovado no sistema");
            }
            /*6. Faça um programa que leia a nota de um aluno e informe se ele está aprovado (nota maior ou igual a 7), em recuperação (nota entre 5 e 7) ou reprovado (nota menor que 5).*/
        }



        public static void Atividade6()
        {
            Console.Clear();
            Console.WriteLine("Verificar quantos dias tem o mês");
            Console.WriteLine("Escreva o numero do mês");
            int mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Tem 31 dias");
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Tem 30 dias");
            }
            else if (mes == 2)
            {
                Console.WriteLine("Tem 28 dias (se o ano for bissexto tem 29 dias)");
            }
            else
            {
                Console.WriteLine("Mes invalido, digite um numero entre 1 e 12");
                return;
            }
           

        }
    }
}
