using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parliamentarian.Models
{
    public class Amendment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string SectionAffected { get; set; }
        public string ProposedBy { get; set; }
        public string AmendmentText { get; set; }
        public DateTime ProposedDate { get; set; }
        public DateTime? PassedDate { get; set; }
        public string? AmendmentStatus { get; set; }

        public Amendment() { }
    }
}
