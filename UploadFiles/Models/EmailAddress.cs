using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UploadFiles.Models
{
    class EmailAddress
    {
        [Key]
        public int IDEmailAddress { get; set; }

        public string Email { get; set; }

    }
}
