﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppButaca.dominio
{
    public class CustomerEntity : BaseEntity
    {

        [Required]
        [MaxLength(20)]
        //[Index(IsUnique = true)]
        public string DocumentNumber { get; set; }

        [Required]
        [MaxLength(30)]
        public string Name { get; set; }

        [Required]
        [MaxLength(30)]
        public string Lastname { get; set; }

        [Required]
        public short Age { get; set; }

        [MaxLength(20)]
        public string PhoneNumber { get; set; }

        [MaxLength(100)]
        public string Email { get; set; }


    }

}
