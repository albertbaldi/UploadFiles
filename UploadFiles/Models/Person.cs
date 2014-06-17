using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UploadFiles.Models
{
    public class Person
    {
        [Key]
        public int IDPerson { get; set; }
        
        [Required]
        public string Name { get; set; }

    }
}