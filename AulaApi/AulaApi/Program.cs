using Newtonsoft.Json;  // Importa o pacote Newtonsoft.Json para manipulação de JSON
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;  // Necessário para realizar requisições HTTP
using System.Text;
using System.Threading.Tasks;  // Necessário para operações assíncronas

namespace AulaApi
{
    internal class Program
    {
        // Método principal assíncrono
        // O 'async' permite o uso de 'await' em operações assíncronas.
        static async Task Main(string[] args)
        {
            // Cria uma instância do HttpClient para fazer requisições HTTP
            HttpClient client = new HttpClient();

            // Define a URL da API que será chamada
            String apiUrl = "https://fakestoreapi.com/products";

            try
            {
                // Faz uma requisição assíncrona GET para a API e aguarda a resposta
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                // Verifica se a resposta da API foi bem-sucedida (código de status 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Lê o conteúdo da resposta como uma string
                    string jsonResult = await response.Content.ReadAsStringAsync();

                    // Converte o JSON recebido para um objeto dinâmico
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(jsonResult);

                    // Linha redundante: esta conversão é feita novamente, o que é desnecessário
                    // JsonConvert.DeserializeObject<dynamic>(jsonResult);

                    // Exibe a resposta completa da API no console (em formato JSON)
                    Console.WriteLine("Resposta da API: ");
                    Console.WriteLine(jsonResult);



                    foreach (var item in jsonObject)
                    {
                         Console.WriteLine($"Nome : {item.title}" +$"Nota:" +
                             $"{item.rating.rate}");
                    }


                }
                else
                {
                    // Caso o código de status não seja de sucesso, exibe o erro no console
                    Console.WriteLine($"Erro na requisição: {response.StatusCode}");
                }
            }
            catch (Exception ex)
            {
                // Se ocorrer alguma exceção (erro), exibe a mensagem de erro
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                // Garante que o HttpClient será descartado após a execução do código
                client.Dispose();
            }
        }
    }
}
