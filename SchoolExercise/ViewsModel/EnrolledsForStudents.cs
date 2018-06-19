using SchoolExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolExercise.ViewsModel {
	public class EnrolledsForStudents {

		public Student Student { get; set; } //instance of student that we want
		public IEnumerable<Enrolled> Enrolleds { get; set; } //list of classes enrolled in

		public EnrolledsForStudents() { }
	}
}