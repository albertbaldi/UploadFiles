using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace UploadFiles.Models
{
    class PhoneNumber
    {
        [Key]
        public int IDPhoneNumber { get; set; }

        public string Number { get; set; }
    }
}
