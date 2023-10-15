using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalListPage
{
    public class MuttonBriyani
    {
        public HotelProperty giveValues()
        {
            var item = new HotelProperty()
            {
                HotelID = 3,
                HotelName = "Mutton Briyani",
                Phone = 123344,
                Address = "Namma Hotel",
                Price = 540

            };
            return item;

        }
    }
}
