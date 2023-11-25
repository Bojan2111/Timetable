using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable.Domain.Models
{
    public class Member
    {
        public string? Id { get; set; }

        public string? UserId { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string? PositionId { get; set; }

        public string? TeamId { get; set; }

        public int YearOfEmployment { get; set; }

        public string? License { get; set; }

        public string? Address { get; set; }

        public string? City { get; set; }

        public string? ZipCode { get; set; }

        public string? Phone { get; set; }

        public string? ReligiousHoliday { get; set; }

        public string? TeamRoleId { get; set; }

        public string? Email { get; set; }
    }
}
