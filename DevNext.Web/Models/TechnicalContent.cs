using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DevNext.Web.Models
{
    public class TechnicalContent
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(500)]
        public String Title { get; set; }

        [DataType(DataType.Url)]
        public String Url { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Slides")]
        public String SlidesUrl { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Demo Code")]
        public String DemoCodeUrl { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CreatedBy { get; set; }
    }
}