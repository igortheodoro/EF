using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLibrary.Models
{
    public class Person
    {   
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        public int Age { get; set; }
        public IList<Address> Addresses { get; set; } = new List<Address>();
        public IList<Email> EmailAddresses { get; set; } = new List<Email>();
    }
}
