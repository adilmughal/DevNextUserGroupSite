using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevNext.Web.Models
{
    [Table("UserGroupEvents")]
    public class UserGroupEvent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        [Display(Name = "Event Title")]
        public String Title { get; set; }

        [Required]
        [Display(Name = "Start Date & Time")]
        public DateTime StartDateTime { get; set; }

        [Required]
        [Display(Name = "End Date & Time")]
        public DateTime EndDateTime { get; set; }

        [Display(Name = "This is Virtual Event")]
        public bool IsVirtualEvent { get; set; }

        [MaxLength(1000)]
        [Display(Name = "Location")]
        public String Address { get; set; }

        public String City { get; set; }

        public String Country { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Event URL")]
        public String Url { get; set; }

        [Required]
        [MaxLength(2000)]
        public String Description { get; set; }

        public virtual ICollection<UserProfile> RegisteredUsers { get; set; }
    }
}