using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Models
{
	public class TraineeProfile
	{
		[Key]
		public string UserId { get; set; }
		[ForeignKey("UserId")]

		public User User { get; set; }

		public DateTime DateOfBirth { get; set; }
		public string Education { get; set; }
		public ICollection<AssignTraineeCourse> AssignTraineeCourses { get; set; }

	}
}
