using Microsoft.EntityFrameworkCore;



namespace LocalAutos.Models
{
            public class AutoContext : DbContext
            {
                public AutoContext (DbContextOptions<AutoContext> options)
                    : base(options)
                {
                }
        public DbSet<Automobiles> AutoNew {get; set;}   //This creates the webapps database context
        public DbSet<User> UserNew        {get; set;}
            }

}