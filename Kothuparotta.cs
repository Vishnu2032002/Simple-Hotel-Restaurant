using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalListPage
{
    public class Kothuparotta
    {
        public HotelProperty giveValues()
        {
            var item = new HotelProperty()
            {
                HotelID = 2,
                HotelName = "Kothuparotta",
                Phone = 123344,
                Address = "Namma Hotel",
                Price = 220

            };
            return item;

        }


    }
}
