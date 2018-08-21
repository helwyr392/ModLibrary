using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModLibrary.Models
{
    public class Programs
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int client_recID { get; set; }

        [Required]
        [MaxLength(100)]
        public string program_name { get; set; }

        [Required]
        [MaxLength(255)]
        public string file_path { get; set; }

        [Required]
        [MaxLength(20)]
        public string environment { get; set; }

        [Required]
        [MaxLength(20)]
        public string current_version { get; set; }
        public DateTime modified_date { get; set; }

        [MaxLength(50)]
        public string framework { get; set; }

        [MaxLength(100)]
        public string Type { get; set; }

        [MaxLength(150)]
        public string DBConnection { get; set; }

        [MaxLength(150)]
        public string RanBy { get; set; }

        [MaxLength(200)]
        public string LiveLocation { get; set; }
    }
}