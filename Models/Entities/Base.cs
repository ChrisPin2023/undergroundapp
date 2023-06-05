using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace underground.api.Models.Entities
{
    public class Base
    {
        public Guid Id { get; set; }
        public string DataCadastro { get; set; }
        public string DataRevisao { get; set; }
    }
}