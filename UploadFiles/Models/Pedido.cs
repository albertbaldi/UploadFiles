using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class Pedido
    {
        [Key]
        public virtual int IDPedido { get; set; }

        [Required]
        public virtual string Descricao { get; set; }

        public virtual ICollection<Produto> Itens { get; set; }
    }
}