using Microsoft.EntityFrameworkCore;
using Gambl.Models;

namespace Gambl.Data
{
    
    public class  DataContext :DbContext{
        public DataContext(DbContextOptions<DataContext>options):base(options)
    {
        
    }
        public DbSet<UserInfo> Users { get; set; }
        public DbSet<UserInfo> UserInfos=>Set<UserInfo>();
        public DbSet<CourseInfo> CourseInfos=>Set<CourseInfo>();
        public DbSet<InstructorInfo> InstructorInfos=>Set<InstructorInfo>();
    }

    
}