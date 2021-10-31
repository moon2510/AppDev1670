using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppDevGCD0805.Models
{
	public class User : IdentityUser
	{
		[Required(ErrorMessage ="This field is required")]
		public string FullName { get; set; }
		public int Age { get; set; }
		public string Address { get; set; }

		
	}
}
