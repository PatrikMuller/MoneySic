using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneySic.Models
{
    public class Endereco
    {
        public virtual int IdEndereco { get; set; }
        public virtual string Rua { get; set; }
        public virtual string Numero { get; set; }
        public virtual string Bairro { get; set; }
        public virtual string Complemento { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string Cep { get; set; }
    }
}