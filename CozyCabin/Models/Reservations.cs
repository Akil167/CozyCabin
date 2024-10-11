using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyCabin.Models
{
	public class Reservations
	{
		public int reservationID { get; set; }
		public int userID { get; set; }
		public int chaletID { get; set; }
		public DateOnly check_In { get; set; }
		public DateOnly check_Out { get; set; }
		public int totalPrice { get; set; }
		public string status { get; set; }
		public DateTime createdAt { get; set; }

		public Reservations(int reservationID, int userID, int chaletID, DateOnly check_In, DateOnly check_Out, int totalPrice, string status, DateTime createdAt)
		{
			this.reservationID = reservationID;
			this.userID = userID;
			this.chaletID = chaletID;
			this.check_In = check_In;
			this.check_Out = check_Out;
			this.totalPrice = totalPrice;
			this.status = status;
			this.createdAt = createdAt;

		}

		public Reservations() { }

	}

	
	

}
