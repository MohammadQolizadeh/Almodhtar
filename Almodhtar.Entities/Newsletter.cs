using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Almodhtar.Entities
{
    public class Newsletter
    {
        public Newsletter()
        {

        }
        public Newsletter(string email)
        {
            Email = email;
        }

        [Key]
        public string Email { get; set; }
        public DateTime? RegisterDateTime { get; set; }
        public bool IsActive { get; set; }
    }
}
