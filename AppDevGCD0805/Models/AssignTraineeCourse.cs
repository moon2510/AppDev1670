using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Models
{
	public class AssignTraineeCourse
	{
		public string UserId { get; set; }
		public TraineeProfile TraineeProfile { get; set; }

		public int CourseId { get; set; }
		public Course Course { get; set; }
	}
}
