using DockerTest.Models;
using Microsoft.EntityFrameworkCore;

namespace DockerTest.Contexts
{
    public class TestContext: DbContext
    {
        public TestContext(DbContextOptions<TestContext> options) : base(options)
        {
                
        }
        public DbSet<WelcomeMessage> WelcomeMessages { get; set; }
    }
}
