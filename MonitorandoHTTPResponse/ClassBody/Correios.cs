using Newtonsoft.Json;
using System;

namespace MonitorandoHTTPResponse.ClassBody
{
    public class Correios : BaseBody
    {
        #region .: Attributes
        public string Cep { get; set; }
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Unidade { get; set; }
        public string IBGE { get; set; }
        public string Gia { get; set; }
        #endregion

        #region .: Methods
        /// <summary>
        /// Método Responsável por ler o corpo da API, e validar se a resposta é o esperado
        /// </summary>
        public static void ValidateResponseBody(string response)
        {
            Console.WriteLine("validando corpo de resposta...");

            Correios api = JsonConvert.DeserializeObject<Correios>(response);

            //Conversar sobre deixar específico ou genérico
            IsValid = api.Cep == "03901-010" && api.Logradouro == "Avenida dos Nacionalistas";
        }

        public override string ToString()
        {
            Cep = ValidateResponse(Cep);
            Logradouro = ValidateResponse(Logradouro);
            Complemento = ValidateResponse(Complemento);
            Bairro = ValidateResponse(Bairro);
            Complemento = ValidateResponse(Complemento);
            Bairro = ValidateResponse(Bairro);
            Localidade = ValidateResponse(Localidade);
            UF = ValidateResponse(UF);
            Unidade = ValidateResponse(Unidade);
            IBGE = ValidateResponse(IBGE);
            Gia = ValidateResponse(Gia);

            return string.Format("API: Correios\n\nCEP: {0}\nLogradouro: {1}\nComplemento: {2}\nBairro: {3}\nLocalidade: {4}\nUF: {5}\nUnidade: {6}\nIBGE: {7}\nGia: {8}",
                Cep,
                Logradouro,
                Complemento,
                Bairro,
                Localidade,
                UF,
                Unidade,
                IBGE,
                Gia);
        }
        #endregion

        #region .: Utils
        private string ValidateResponse(string responseItem)
        {
            return responseItem.Equals(string.Empty) ? "Não registrado/Não existe" : responseItem;
        }
        #endregion
    }
}
