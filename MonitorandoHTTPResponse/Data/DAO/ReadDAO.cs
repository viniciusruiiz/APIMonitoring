using MonitorandoHTTPResponse.Data.Config;
using MonitorandoHTTPResponse.Data.Model;
using NHibernate;

namespace MonitorandoHTTPResponse.Data.DAO
{
    /// <summary>
    /// Classe responsável pelos CRUDS de leitura de dados (no caso, apenas inserir)
    /// </summary>
    public class ReadDAO : IDAO<Read>
    {
        public void Insert(Read obj)
        {
            using (ISession session = SessionFactory.OpenSession())
            using (ITransaction transaction = session.BeginTransaction())
            {
                session.Save(obj);

                transaction.Commit();
            }
        }
    }
}
