using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;


namespace CozyCabin.Models
{
	internal class DAL
	{
		SqlConnection con;
		SqlCommand com;
		public string strcon = "Data Source=DESKTOP-73CU594\\SQLEXPRESS;Initial Catalog=Project2024;Integrated Security=True";
		DataSet ds;
		SqlDataAdapter da;
		SqlDataReader reader;


		/*public List<Reservations> pendingReservations()
		{
			List<Reservations> list = new List<Reservations>();
			Reservations res = null;
			con = new SqlConnection(strcon);
			com = new SqlCommand("select * from Reservations where status=@a", con);
			com.Parameters.AddWithValue("@a", "pending");
			con.Open();
			SqlDataReader reader = com.ExecuteReader();

			while (reader.Read())
			{
				res = new Reservations(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), DateOnly.FromDateTime(reader.GetDateTime(3)), DateOnly.FromDateTime(reader.GetDateTime(4)), reader.GetInt32(5), reader.GetString(6), reader.GetDateTime(7));
				list.Add(res);
			}
			con.Close();
			return list;

		}*/


        public List<Chalet> chaletCards()
        {
            List<Chalet> list = new List<Chalet>();
            Chalet res = null;
            con = new SqlConnection(strcon);
            com = new SqlCommand("select chaletMainImage,chaletName,address,noGuests,pricePerNight from Chalets", con);
            con.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
                res = new Chalet(reader.GetString(0),reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4));
                list.Add(res);
            }
            con.Close();
            return list;

        }


        public List<string> cardsImages()
        {
            List<string> images = new List<string>();
            string res = null;
            con = new SqlConnection(strcon);
            com = new SqlCommand("select imageURL from Images where altText=@a", con);
            com.Parameters.AddWithValue("@a", "mainImage");
            con.Open();
            SqlDataReader reader = com.ExecuteReader();

            while (reader.Read())
            {
               
                images.Add(res);
            }
            con.Close();
            return images;

        }
    }
}
