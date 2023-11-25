using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetable.Domain.Models;

namespace Timetable.EntityFramework
{
    internal class TimetableDbContext : DbContext
    {
        DbSet<User> users { get; set; }
        DbSet<Role> roles { get; set; }
        DbSet<Team> teams { get; set; }
        DbSet<Position> positions { get; set; }
        DbSet<TeamRole> teamsRole { get; set; }
        DbSet<Member> members { get; set; }
        DbSet<Shift> shifts { get; set; }
    }
}
