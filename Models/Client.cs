using System;
using System.ComponentModel.DataAnnotations;

namespace Animalerie_MVC.Web.Models
{
	public class Client
	{

		[Key]
		public int Id { get; set; }

		public string Firstname { get; set; }

		public string Lastname { get; set; }

	}
}

