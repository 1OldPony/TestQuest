using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestQuest.Models
{
    public class Letter
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public DateTime Date { get; set; }
        public Employe ToWhom { get; set; }
        public Employe FromWhom { get; set; }
    }
}
