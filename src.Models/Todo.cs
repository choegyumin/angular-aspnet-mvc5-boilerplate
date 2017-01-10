using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace src.Models
{
	public class Todo
	{
		public int id { get; set; }
		[Required]
		public string title { get; set; }
		[Required]
		public bool completed { get; set; }
	}
}
