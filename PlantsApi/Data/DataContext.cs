namespace PlantsApi.Data;

public class DataContext : DbContext
{
    public DbSet<Plant> Plants { get; set; } = null!;
    public DbSet<Zone> Zones { get; set; } = null!;
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        //Currently use hard-coded value. Later get this using a more secure method.
        optionsBuilder.UseSqlServer("Server=.;Database=PlantsApi;Trusted_Connection=true;TrustServerCertificate=true;");
    }
}