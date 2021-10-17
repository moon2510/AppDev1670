using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Models
{
	public class TrainerProfile
	{
		[Key] 
		public string UserId { get; set; }
		[ForeignKey("UserId")]

		public User User { get; set; }

		public ICollection<AssignTrainerCourse> AssignTrainerCourses { get; set; }
		public string Specialty { get; set; }
		

	}
}
