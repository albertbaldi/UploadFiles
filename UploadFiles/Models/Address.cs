using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UploadFiles.Models
{
    class Address
    {
        [Key]
        public int IDAddress { get; set; }

        public string Name { get; set; }

    }
}
