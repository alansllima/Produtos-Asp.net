using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage ="Campo Obrigatório")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public String Sobrenome { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage ="Digite um email válido")]
        [DisplayName("E-mail")]
        public String Email { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }

       public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

       // public bool ClienteEspecial(Cliente cliente) => cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;
    }
}