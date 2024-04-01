using System;
using System.ComponentModel.DataAnnotations;

namespace Animalerie_MVC.Web.Models
{
	public class Reservation
	{

		[Key]
		public int Id { get; set; }
		public DateTime ReservationDate { get; set; }

		public int AnimalId { get; set; }
		public Animal Animal { get; set; }

		public int ClientId { get; set; }
		public Client Client { get; set; }

	}
}

