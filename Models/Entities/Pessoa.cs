using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models.Entities;

namespace Models.Entities
{
    public class Pessoa : Base
    {
        public Pessoa()
        {
            Contactos = new HashSet<Contacto>();
        }
        // Propriedades da tabela pessoa
        

        public string NomePessoa { get; set; }
        public string NumIdentificao { get; set; }
        public DateTime DataNascimento { get; set; }
        public int Idade { get; set; }
        public char Genero { get; set; }
        public string Profissao { get; set; }
        public string GrupoSanguineo { get; set; }

        // chave estrangeira
        public Guid EnderecoId { get; set; }
        public Guid NaturalidadeId { get; set; }

        // relaciomanetos - cardinalidades
        public IEnumerable <Contacto> Contactos;
        public virtual Endereco Endereco { get; set; }  
        public virtual Dador? Dador { get; set; } 
        public virtual Medico? Medico { get; set; } 
        public virtual Tecnico? Tecnico { get; set; }
        public virtual Paciente? Paciente { get; set; }  

    }
}