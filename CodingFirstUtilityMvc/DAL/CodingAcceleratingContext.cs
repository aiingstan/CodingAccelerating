using System;
using CodingFirstUtilityMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace CodingFirstUtilityMvc.DAL
{
    public class CodingAcceleratingContext: DbContext
    {
        public CodingAcceleratingContext(DbContextOptions<CodingAcceleratingContext> options): base(options)
        {
        }

        public DbSet<Model> Models { get; set; }
        public DbSet<Field> Fields { get; set; }
    }
}
