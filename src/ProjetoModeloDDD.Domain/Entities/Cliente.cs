using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
   public class Cliente
    {
   
        public int ClienteId { get; set; }

        public String Nome { get; set; }

        public String Sobrenome { get; set; }

        public String Email { get; set; }

        public DateTime DataCadastro { get; set; }
   
        public bool Ativo { get; set; }

        public virtual IEnumerable<Produto> Produtos { get; set; }

        public bool ClienteEspecial(Cliente cliente) => cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
    }
}
