using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotalListPage
{
    class NonVeg
    {
        
        string hotel;

        public List<object> display(int hotelID)
        {

            var values = new List<object>();
            switch (hotelID)
            {
                case 1:
                    var item = new Masterbriyani().giveValues();
                  
                    values.Add(item.HotelID);
                    values.Add(item.HotelName);
                    values.Add(item.Phone);
                    values.Add(item.Address);
                    values.Add(item.Price);
                    break;
                case 2:
                    var items = new Kothuparotta().giveValues();

                    values.Add(items.HotelID);
                    values.Add(items.HotelName);
                    values.Add(items.Phone);
                    values.Add(items.Address);
                    values.Add(items.Price);
                    break;

                case 3:
                    var itemss = new MuttonBriyani().giveValues();

                    values.Add(itemss.HotelID);
                    values.Add(itemss.HotelName);
                    values.Add(itemss.Phone);
                    values.Add(itemss.Address);
                    values.Add(itemss.Price);
                    break;
                default:
                    Console.WriteLine("default value");
                    break;
            }
            return values;
        }

        
    }
}
