using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP.NETCore.WithEF.Models;

    public class StudentDBContext : DbContext
    {
        public StudentDBContext (DbContextOptions<StudentDBContext> options)
            : base(options)
        {
        }

        public DbSet<ASP.NETCore.WithEF.Models.Student> Student { get; set; } = default!;
    }
