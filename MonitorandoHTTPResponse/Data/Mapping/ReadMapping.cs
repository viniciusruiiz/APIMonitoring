using FluentNHibernate.Mapping;
using MonitorandoHTTPResponse.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonitorandoHTTPResponse.Data.Mapping
{
    /// <summary>
    /// Classe responsável por mapear os dados entre a Classe de leitura e a tabela de leitura do banco
    /// </summary>
    public class ReadMapping : ClassMap<Read>
    {
        public ReadMapping()
        {
            Table("API_LEITURA");
            Id(c => c.Id).GeneratedBy.Identity().Unique();
            Map(c => c.Active);
            Map(c => c.Valid);
            Map(c => c.ReadMoment);
        }
    }
}
