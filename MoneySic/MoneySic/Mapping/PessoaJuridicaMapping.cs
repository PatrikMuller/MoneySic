using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate.Mapping;
using MoneySic.Models;

namespace MoneySic.Mapping
{
    public class PessoaJuridicaMapping : SubclassMap<PessoaJuridica>
    {

        public PessoaJuridicaMapping()
        {
            Map(o => o.Cnpj);
            Map(o => o.Ie);
            Map(o => o.Fantasia);
            Map(o => o.DataConstituicao);
        }

    }
}