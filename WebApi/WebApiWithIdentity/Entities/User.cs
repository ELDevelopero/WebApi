﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiWithIdentity.Entities
{
            public class User
        {
            [Required]
            public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public byte PasswordHash { get; set; }

        [Required]
        public byte PasswordSalt { get; set; }
    }

        
    
}
