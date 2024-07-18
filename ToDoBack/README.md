Steps to initiate EntityFramework

1. Install the following packages
	dotnet add package Microsoft.EntityFrameworkCore
    dotnet add package Microsoft.EntityFrameworkCore.Design
    dotnet add package Microsoft.EntityFrameworkCore.SqlServer

2. Create database model and dbcontext.
    public class ToDo
    {
        [Key]
        public int ToDoId { get; set; }
        [Required, MaxLength(250)]
        public string Details { get; set; }
        [Required]
        public bool IsCompleted { get; set; }
    }

    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ToDo> ToDos { get; set; }
    }

3. Configure the Database connection (appsettings.json + Program.cs)
           appsettings.cs
           "ConnectionStrings": { "MyAppCs": "Server=localhost\\SQLEXPRESS; Database=MyApp; Integrated Security=True; trustServerCertificate=true" },

           Program.cs
           var connectionString = builder.Configuration.GetConnectionString("MyAppCs");
           builder.Services.AddDbContext<AppDbContext>(options => 
           options.UseSqlServer(connectionString));




