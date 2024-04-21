using EasyReg_BackEnd.Entities;
using Microsoft.EntityFrameworkCore;

namespace EasyReg_BackEnd.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options) 
        {
                    
        }
        public DbSet<Student> Students { get; set; }
    }
}
