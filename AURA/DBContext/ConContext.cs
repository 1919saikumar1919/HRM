using AURA.Models;
using HRM.Models;
using Microsoft.EntityFrameworkCore;

namespace HRM.DBContext
{
    public class ConContext : DbContext
    {
        public ConContext(DbContextOptions<ConContext>options): base(options) 
        {


         
        }
        public DbSet<Parsons> Parsons { get; set; }
        public DbSet<Candidates> Candidates { get; set; }
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Employees> Employees { get; set; }
    }
}
