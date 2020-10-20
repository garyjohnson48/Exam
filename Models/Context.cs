using Microsoft.EntityFrameworkCore;
	namespace Exam.Models
	{ 
    	// the MyContext class representing a session with our MySQL 
    	// database allowing us to query for or save data
    		public class MyContext : DbContext 
    		{ 
        		public MyContext(DbContextOptions options) : base(options) { }
        		// the "Monsters" table name will come from the DbSet variable name
        		public DbSet<User> users { get; set; }
        		public DbSet<Login_User> loggedInUsers { get; set; }
        		public DbSet<Like> likes { get; set; }
        		public DbSet<Idea> ideas { get; set; }
        	
        		
    		}
	}