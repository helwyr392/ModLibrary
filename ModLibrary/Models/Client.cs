using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ModLibrary.Models
{
    public class Client
    {
        [Required]
        public int id { get; set; }

        [Required]
        [MaxLength(60)]
        public string client_name { get; set; }

        [Required]
        [MaxLength(50)]
        public string address { get; set; }

        [Required]
        [MaxLength(20)]
        public string city { get; set; }

        [Required]
        [MaxLength(20)]
        public string state { get; set; }

        [Required]
        [MaxLength(10)]
        public string zip_code { get; set; }

        [MaxLength(50)]
        public string primary_contact { get; set; }

        [MaxLength(15)]
        public string phone { get; set; }

        [MaxLength(10)]
        public string phone_ext { get; set; }

        [MaxLength(50)]
        public string email { get; set; }

        [MaxLength(20)]
        public string dot_net_ver { get; set; }

        [MaxLength(20)]
        public string macola_ver { get; set; }

        [MaxLength(20)]
        public string sage_ver { get; set; }

        [MaxLength(20)]
        public string wisys_ver { get; set; }

        [MaxLength(20)]
        public string crystal_ver { get; set; }

        [MaxLength(20)]
        public string office_ver { get; set; }

        [MaxLength(20)]
        public string sql_ver { get; set; }

        [MaxLength(20)]
        public string os_ver { get; set; }

        [MaxLength(20)]
        public string third_party_ver { get; set; }

        public int company_recID { get; set; }

        [MaxLength(20)]
        public string company_ID { get; set; }
    }
}