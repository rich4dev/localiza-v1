using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LocalizaV1.Dominio;
using NHibernate;
using NHibernate.Criterion;

namespace LocalizaV1.Persistencia
{
    public class ClienteDAO:BaseDAO<Cliente, int>
    {

        public ICollection<Cliente> BuscarPorDNI(string dni)
        {
            using (ISession sesion = NHibernateHelper.ObtenerSesion())
            {
                ICriteria busquedaDni = sesion.CreateCriteria(typeof(Cliente));
                busquedaDni.Add(Restrictions.Eq("dni", dni));
                return busquedaDni.List<Cliente>();
            }
        }


    }
}