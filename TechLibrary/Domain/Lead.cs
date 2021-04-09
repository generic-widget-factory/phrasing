using System;
using System.ComponentModel.DataAnnotations;

namespace TechLibrary.Domain
{
    public class Lead
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string InsuranceProduct { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
