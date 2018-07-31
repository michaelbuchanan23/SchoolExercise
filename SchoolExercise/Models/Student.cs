using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolExercise.Models {
	public class Student {

		public int Id { get; set; }

		[Display(Name = "First Name")]
		public string Firstname { get; set; }

		[Display(Name = "Last Name")]
		public string Lastname { get; set; }
		public int MajorId { get; set; }
		public virtual Major Major { get; set;}
		public int SAT { get; set; }

		public Student() { }
	}
}