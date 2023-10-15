using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalListPage
{
    public class Masterbriyani
    {

        public HotelProperty giveValues()
        {
            var item = new HotelProperty()
            {
                HotelID = 1,
                HotelName = "Chicken Briyani",
                Phone = 123344,
                Address = "Namma Hotel",
                Price = 300

            };
            return item;
          
        }
    }
}
