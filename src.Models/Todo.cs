using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Newtonsoft.Json;

namespace src.Models
{
	public class Todo
	{
		public int Id { get; set; }
		[Required]
		public string Title { get; set; }
		[Required]
		public bool Completed { get; set; }
	}
}
