using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Models
{
    public class Message : BaseEntity
    {
        [Required, MaxLength(200)]
        public string SenderName { get; set; }
        [Required, MaxLength(200), EmailAddress]
        public string SenderEmail { get; set; }
        [Required]
        public string MessageText { get; set; }
        public DateTime Date { get; set; }
    }
}
