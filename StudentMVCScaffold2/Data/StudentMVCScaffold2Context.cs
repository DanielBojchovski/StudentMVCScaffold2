using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentMVCScaffold2.Models;

namespace StudentMVCScaffold2.Data
{
    public class StudentMVCScaffold2Context : DbContext
    {
        public StudentMVCScaffold2Context (DbContextOptions<StudentMVCScaffold2Context> options)
            : base(options)
        {
        }

        public DbSet<StudentMVCScaffold2.Models.Student> Student { get; set; } = default!;
    }
}
