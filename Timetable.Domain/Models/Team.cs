﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable.Domain.Models
{
    public class Team
    {
        public string? Id { get; set; }

        public string? Name { get; set; }
        public string? ShiftPattern { get; set; }
        public int CurrentMonth { get; set; }
        public DateTime? CurrentStartDate { get; set; }
        public DateTime? NextMonthStartDate { get; set; }
    }
}
