using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolExercise.Models
{
    public class SchoolDBContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public SchoolDBContext() : base("name=SchoolDBContext")
        {
        }

		public System.Data.Entity.DbSet<SchoolExercise.Models.Major> Majors { get; set; }

		public System.Data.Entity.DbSet<SchoolExercise.Models.Student> Students { get; set; }

		public System.Data.Entity.DbSet<SchoolExercise.Models.Class> Classes { get; set; }

		public System.Data.Entity.DbSet<SchoolExercise.Models.Enrolled> Enrolleds { get; set; }
	}
}
