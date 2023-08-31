﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace LivrariaControleEmprestimo.DATA.Models
{
    public partial class Livro
    {
        public Livro()
        {
            LivroClienteEmprestimo = new HashSet<LivroClienteEmprestimo>();
        }

        [Key]
        [Display(Name = "Cód.")]
        public int Id { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Column("livroNome")]
        [StringLength(100)]
        [Display(Name = "Livro")]
        public string LivroNome { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Column("livroAutor")]
        [StringLength(100)]
        [Display(Name = "Autor")]
        public string LivroAutor { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Column("livroEditora")]
        [StringLength(100)]
        [Display(Name = "Editora")]
        public string LivroEditora { get; set; }

        [Required(ErrorMessage = "CampoObrigatório !")]
        [Column("livroAnoPublicacao", TypeName = "datetime")]
        [DataType(DataType.Date)]
        [Display(Name = "Publicação")]
        public DateTime LivroAnoPublicacao { get; set; }

        [Required(ErrorMessage ="CampoObrigatório !")]
        [Column("livroEdicao")]
        [StringLength(50)]
        [Display(Name = "Edição")]
        public string LivroEdicao { get; set; }


        [InverseProperty("LceIdLivroNavigation")]
        public virtual ICollection<LivroClienteEmprestimo> LivroClienteEmprestimo { get; set; }
    }
}