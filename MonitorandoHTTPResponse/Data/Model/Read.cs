using System;

namespace MonitorandoHTTPResponse.Data.Model
{
    /// <summary>
    /// Classe responsável por ser um objeto de modelo c# com todos os atributos contidos no banco, como um clone
    /// da tabela existente do banco convertido em uma classe
    /// </summary>
    public class Read
    {
        public virtual int Id { get; set; }
        public virtual bool Active { get; set; }
        public virtual bool Valid { get; set; }
        public virtual DateTime ReadMoment { get; set; }
    }
}
