using System;
using System.Net;

namespace MonitorandoHTTPResponse.ClassBody
{
    /// <summary>
    /// Classe base para todas as classes para guardar o corpo da requisição da API.
    /// </summary>
    public class BaseBody
    {
        public static bool IsOnline;
        public static bool IsValid;

        /// <summary>
        /// Método Responsável por ler o status code da API, e validar se a API está ou não online.
        /// </summary>
        public static void ValidateStatusCode(HttpStatusCode code)
        {
            Console.WriteLine("validando codigo de resposta...");
            IsOnline = code == HttpStatusCode.OK;
        }
    }
}
