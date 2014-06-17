using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class Produto
    {
        [Key]
        public virtual int IDProduto { get; set; }

        [Required]
        public virtual string Nome { get; set; }
    }
}