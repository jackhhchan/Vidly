using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required][StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; } //FK for MembershipType
        public MembershipType MembershipType { get; set; }
    }
}