using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using ProjektCS;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;

namespace ProjektC_
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Wczytaj konfiguracjê z pliku appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .Build();

            string connectionString = config.GetConnectionString("DefaultConnection");

            using (var connection = new MyDbContext(connectionString))
            {
                Console.WriteLine("Po³¹czenie z baz¹ danych zosta³o nawi¹zane.");

                ApplicationConfiguration.Initialize();
                Application.Run(new Form1(connection));
            }
        }
    }

    public class MyDbContext : DbContext
    {
        private readonly string _connectionString;

        public MyDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<Filmy> Film { get; set; }
        public DbSet<Aktorzy> Aktorzy { get; set; }
        public DbSet<Rezyserzy> Rezyserzy { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_connectionString);
        }
    }

    [Table("filmy")]
    public class Filmy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string tytul { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_wydania { get; set; }

        [MaxLength(200)]
        public string gatunki { get; set; } // np. "komedia, dramat"

        public string sciezkadoobrazu { get; set; }

        public int aktor_id { get; set; } // Foreign key to Aktorzy

        public int rezyser_id { get; set; } // Foreign key to Rezyserzy

        public string sciezka_do_pliku { get; set; } // Œcie¿ka do pliku wideo
    }

    [Table("aktorzy")]
    public class Aktorzy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string imie { get; set; }

        [Required]
        [MaxLength(200)]
        public string nazwisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_urodzenia { get; set; }
    }

    [Table("rezyserzy")]
    public class Rezyserzy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string imie { get; set; }

        [Required]
        [MaxLength(200)]
        public string nazwisko { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_urodzenia { get; set; }
    }
}