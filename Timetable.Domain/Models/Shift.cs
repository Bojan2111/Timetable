using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable.Domain.Models
{
    public class Shift
    {
        public string? Id { get; set; }

        public int Month { get; set; }

        public DateTime Date { get; set; }

        public string? MemberId { get; set; }

        public string? Type { get; set; }
    }
}
