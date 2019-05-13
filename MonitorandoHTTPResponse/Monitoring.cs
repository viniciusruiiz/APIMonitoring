using MonitorandoHTTPResponse.ClassBody;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorandoHTTPResponse
{
    class Monitoring
    {
        private static bool _isOnline;
        private static bool _isValidApi;

        /// <summary>
        /// Método Responsável por ler o status code da API, e validar se a API está ou não online.
        /// </summary>
        private static void ValidateStatusCode(HttpStatusCode code)
        {
            Console.WriteLine("validando codigo de resposta...");
            _isOnline = code == HttpStatusCode.OK;
        }

        /// <summary>
        /// Método Responsável por ler o corpo da API, e validar se a resposta é o esperado
        /// </summary>
        private static void ValidateResponse(string response)
        {
            Console.WriteLine("validando corpo de resposta...");

            Correios api = JsonConvert.DeserializeObject<Correios>(response);

            //Conversar sobre deixar específico ou genérico
            _isValidApi = api.Cep == "03901-010" && api.Logradouro == "Avenida dos Nacionalistas";
        }

        static async Task Main()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response;

                    while (true)
                    {
                        response = await client.GetAsync("https://viacep.com.br/ws/03901010/json/");//Faz a requisição

                        ValidateStatusCode(response.StatusCode);//Valida o status code retornado da requisição

                        if (_isOnline)
                        {
                            Console.WriteLine("API Online!");
                        }
                        else
                        {
                            Console.WriteLine("API Offline :(");
                        }

                        ValidateResponse(await response.Content.ReadAsStringAsync());//Valida o corpo da requisição

                        if (_isValidApi)
                        {
                            Console.WriteLine("Resposta da API validada!");
                        }
                        else
                        {
                            Console.WriteLine("Resposta da API ínvalida! :(");
                        }

                        Thread.Sleep(3000);//Tempo de delay de monitoramento, a validar.

                        Console.WriteLine("");//Quebra de linha para o próximo monitoramento
                    }
                }
                catch (HttpRequestException e)
                {
                    //tratamento de exceção
                    Console.WriteLine("\nOcorreu uma exceção!");
                    Console.WriteLine("Mensagem :{0} ", e.Message);
                }
            }
        }
    }
}
