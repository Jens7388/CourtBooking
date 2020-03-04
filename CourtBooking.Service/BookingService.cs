using CourtBooking.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace CourtBooking.Service
{
    public class BookingService
    {
        readonly string url = @"https://api.aspitcloud.dk/bookings";

        public virtual Booking GetSingle(int id)
        {
            string urlForSingle = $"{url}/{id}";
            string resultTask;

            using(WebClient client = new WebClient())
            {
                resultTask = client.DownloadString(urlForSingle);
            }
            Booking booking = JsonConvert.DeserializeObject<Booking>(resultTask);
            return booking;
        }

        public virtual List<Booking> GetAll()
        {           
            List<Booking> bookings;
            string resultTask;

            using(WebClient client = new WebClient())
            {
                resultTask = client.DownloadString(url);
            }

            bookings = JsonConvert.DeserializeObject<List<Booking>>(resultTask);
            return bookings;
        }
    }
}