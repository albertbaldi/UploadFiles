using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class Upload
    {
        [Key]
        public virtual int IDUpload { get; set; }

        [Required]
        public virtual string Titulo { get; set; }

        [Required]
        public virtual byte[] Conteudo { get; set; }
    }
}