using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorandoHTTPResponse.ClassBody
{
    public class Correios
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
