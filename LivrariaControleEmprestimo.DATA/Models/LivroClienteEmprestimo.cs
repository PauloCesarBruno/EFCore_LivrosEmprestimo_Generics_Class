﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class LivroClienteEmprestimo
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Display(Name = "Código do cliente")]
        public int LceIdCliente { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Display(Name = "Código do livro")]
        public int LceIdLivro { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Column(TypeName = "datetime")]
        [DataType(DataType.Date)]
        [Display(Name = "Data da Saída")]
        public DateTime LceDataEmprestimo { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Column(TypeName = "datetime")]
        [DataType(DataType.Date)]
        [Display(Name = "Data do Retorno")]
        public DateTime LceDataEntrega { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Display(Name = "Foi Entregue ?")]
        public bool LceEntregue { get; set; }

       
        [ForeignKey(nameof(LceIdCliente))]
        [InverseProperty(nameof(Cliente.LivroClienteEmprestimo))]
        public virtual Cliente LceIdClienteNavigation { get; set; }

        [ForeignKey(nameof(LceIdLivro))]
        [InverseProperty(nameof(Livro.LivroClienteEmprestimo))]
        public virtual Livro LceIdLivroNavigation { get; set; }
    }
}