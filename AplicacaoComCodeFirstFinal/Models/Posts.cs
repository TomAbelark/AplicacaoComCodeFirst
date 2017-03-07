using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AplicacaoComCodeFirstFinal.Models
{
    public class Posts
    {
        [Key]
        [Display(Name = "Código", Description = "Codigo do Post)")]
        public long lPostId { get; set; }
        [Display(Name = "Titulo do Post", Description = "Titulo)")]
        public string sTituloPost { get; set; }

        [Display(Name = "Resumo do Post", Description = "Titulo)")]
        public string sResumoPost { get; set; }

        [Display(Name = "Conteudo do Post", Description = "Titulo)")]
        public string sConteudoPost { get; set; }

        [Display(Name = "Data da Postagem", Description = "Titulo)")]
        public DateTime dDataPostagem { get; set; }

        [Display(Name = "Codigo Categoria", Description = "Titulo)")]
        public int iCategoriaId { get; set; }

        [Display(Name = "Codigo Categoria", Description = "Titulo)")]
        [ForeignKey("iCategoriaId")]
        public virtual Categorias Categorias { get; set; }


    }
}