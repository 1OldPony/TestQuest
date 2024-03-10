using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestQuest.Models.ViewModels
{
    public class LetModel
    {
        public string Header { get; set; }
        public string Text { get; set; }
        public Employe ToWhom { get; set; }
        public Employe FromWhom { get; set; }
    }
}
