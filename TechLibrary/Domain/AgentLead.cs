using System;
using System.ComponentModel.DataAnnotations;

namespace TechLibrary.Domain
{
    public class AgentLead
    {
        [Key]
        public int Id { get; set; }
        public int AgentId { get; set; }
        public int AgencyId { get; set; }
        public int LeadId { get; set; }
        public string ChannelType { get; set; }
        public decimal? Cost { get; set; }
        public bool? IsCredited { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
