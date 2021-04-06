using Diary.Models.Configurations;
using Diary.Models.Domains;
using System;
using System.Data.Entity;
using System.Linq;

namespace Diary
{
    public class ApplicationDbContext : DbContext
    {
        static string _serverAdress = Properties.Settings.Default.serverAdress;
        static string _serverName = Properties.Settings.Default.serverName;
        static string _dataBaseName = Properties.Settings.Default.dataBaseName;
        static string _userId = Properties.Settings.Default.userId;
        static string _password = Properties.Settings.Default.password;
        static string _connectionString = $"Server={_serverAdress}{_serverName};Database={_dataBaseName};User Id={_userId};Password={_password}";
        /*
        static string _serverAdress = Properties.Settings.Default.serverAdress "(local)";
        static string _serverName = "\\SQLEXPRESS";
        static string _dataBaseName = "Diary;";
        static string _userId = "diary";
        static string _password = "123";
        
        public ApplicationDbContext()
            : base("name=ApplicationDbContext")
        {
  
        }
        */

        public ApplicationDbContext()
     : base(_connectionString )
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new GroupConfiguration());
            modelBuilder.Configurations.Add(new RatingConfiguration());

        }
    }

}