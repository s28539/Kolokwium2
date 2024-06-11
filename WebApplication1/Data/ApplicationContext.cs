using Microsoft.EntityFrameworkCore;

namespace WebApplication1;

public class ApplicationContext : DbContext
{
    protected ApplicationContext()
    {
    }

    public ApplicationContext(DbContextOptions options) : base(options)
    {
    }
}