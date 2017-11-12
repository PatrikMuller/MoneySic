using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using FluentNHibernate.Mapping;
using MoneySic.Models;

namespace MoneySic.Mapping
{
    public class PessoaMapping : ClassMap<Pessoa>
    {
        
        public PessoaMapping()
        {
            Id(pessoa => pessoa.IdPessoa).GeneratedBy.Sequence("Pessoa_IdPessoa_Seq");
            Map(pessoa => pessoa.Nome);
        }
        
    }
}