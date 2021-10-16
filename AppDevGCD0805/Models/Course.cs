using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Models
{
	public class Course
	{
		
		public int Id { get; set; }
		public string Name { get; set; }

		public string Description { get; set; }
		public int CategoryId { get; set; }
		public Category Category { get; set; }
	}
}
