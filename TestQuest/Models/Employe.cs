using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TestQuest.Models
{
    public class Employe
    {
        //public int Id { get; set; }
        [Key]
        public string EmployeName { get; set; }
        public string Password { get; set; }
    }
}
