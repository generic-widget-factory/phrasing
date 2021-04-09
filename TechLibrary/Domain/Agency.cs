using System;
using System.ComponentModel.DataAnnotations;

namespace TechLibrary.Domain
{
    public class Agency
    {
        [Key]
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public int ApplySubsidy { get; set; }
        public decimal SubsidyAmount { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
