using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MoneySic.Infrastructure;
using MoneySic.Models;
using NHibernate;

namespace MoneySic.DataAccess
{
    public class PessoaFisicaAccess
    {

        public void Adiciona(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Save(obj);
                tx.Commit();
            }
        }

        public PessoaFisica BuscaPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<PessoaFisica>(id);
            }
        }

        public void Remove(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public void Atualiza(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public void Grava(PessoaFisica obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public IList<PessoaFisica> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                string hql = "select p from PessoaFisica p";
                IQuery query = session.CreateQuery(hql);
                return query.List<PessoaFisica>();
            }
        }

    }
}