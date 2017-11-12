using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using MoneySic.Infrastructure;
using MoneySic.Models;
using NHibernate;

namespace MoneySic.DataAccess
{
    public class PessoaAccess
    {

        public void Adiciona(Pessoa obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Save(obj);
                tx.Commit();
            }
        }

        public Pessoa BuscaPorId(int id)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                return session.Get<Pessoa>(id);
            }
        }

        public void Remove(Pessoa obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Delete(obj);
                tx.Commit();
            }
        }

        public void Atualiza(Pessoa obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public void Grava(Pessoa obj)
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                ITransaction tx = session.BeginTransaction();
                session.Merge(obj);
                tx.Commit();
            }
        }

        public IList<Pessoa> Lista()
        {
            using (ISession session = NHibernateHelper.AbreSessao())
            {
                string hql = "select p from Pessoa p";
                IQuery query = session.CreateQuery(hql);
                return query.List<Pessoa>();
            }
        }

    }
}