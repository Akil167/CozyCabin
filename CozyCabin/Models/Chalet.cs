using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CozyCabin.Models
{
    public class Chalet
    {

        public int chaletID { get; set; }
        public string chaletName{ get; set; }
        public string address { get; set; }
        public string location { get; set; }
        public string chaletMainImage { get; set; }
        public string description { get; set; }
        public int pricePerNight{ get; set; }
        public string amenities { get; set; }
        public int noGuests { get; set; }

        

        public Chalet(string chaletMainImage, string chaletName, string address, int noGuests, int pricePerNight) {
            
            this.chaletMainImage = chaletMainImage;
            this.chaletName = chaletName;
            this.address = address;
            this.noGuests = noGuests;
            this.pricePerNight = pricePerNight;

        }

    }
}
