﻿using FluentNHibernate.Mapping;
using SCGS.CORE.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCGS.CORE.Map
{
    public class EnderecoMap : ClassMap<Endereco>
    {

        public EnderecoMap()
        {
            Id(x => x.Id);

            Map(x => x.CEP);
            Map(x => x.Complemento);
            Map(x => x.Logradouro);
            Map(x => x.Numero);
            Map(x => x.TipoLogradouro).CustomType<TipoLogradrouro>();

            References(x => x.Cidade)
                .Cascade.None();

            References(x => x.MicroArea)
             .Cascade.None();

            Table("endereco");

        }
    }
}
