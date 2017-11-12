using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MoneySic.Infrastructure;
using MoneySic.Models;
using NHibernate;

namespace MoneySic.DataAccess
{
    public class PessoaJuridicaAccess
    {

        public PessoaJuridica Ler(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<PessoaJuridica>(id);
            }
        }

        public IList<PessoaJuridica> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                string hql = "select p from PessoaJuridica p";
                IQuery query = session.CreateQuery(hql);
                return query.List<PessoaJuridica>();
            }
        }

        public void Grava(PessoaJuridica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

    }
}