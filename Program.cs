using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;
using ProjektCS;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
            using(var connection = new MyDbContext())
            {
                Console.WriteLine("Po³¹czenie z baz¹ danych zosta³o nawi¹zane.");


                ApplicationConfiguration.Initialize();
                Application.Run(new Form1(connection));
                //Application.Run(new Form3());

            }
            //optionsBu
        }
    }
    public class MyDbContext : DbContext
    {
        string serverAddress = "localhost";
        string dataBase = "ProjektCS";
        string userId = "postgres";
        string password = "1234";

        public DbSet<Filmy> Film { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server="+serverAddress+";Database="+dataBase+";User ID="+userId+";Password="+password+";");
        }
    }
    [Table("filmy")]
    public class Filmy
    {
        [Key]
        public int id { get; set; }

        [Required]
        [MaxLength(200)]
        public string tytul { get; set; }

        [Column(TypeName = "date")]
        public DateTime data_wydania { get; set; }

        [MaxLength(200)]
        public string gatunki { get; set; } // np. "komedia, dramat"

        public string sciezkadoobrazu { get; set; }

    }


}