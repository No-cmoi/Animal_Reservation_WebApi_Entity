using System;
using System.ComponentModel.DataAnnotations;

namespace Animalerie_MVC.Web.Models
{
	public class Animal
	{


		[Key]
		public int Id { get; set; }

		public string Name { get; set; }

		public string Species { get; set; }

	}
}

