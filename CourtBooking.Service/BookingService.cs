
using System;
using System.Net;
using System.Threading.Tasks;

namespace CourtBooking.Service
{
    public class BookingService
    {
        readonly static string url = @"https://api.aspitcloud.dk/bookings";

        public static string GetSingle(int id = 1)
        {
            try
            {
                string urlForSingle = $"{url}/{id}";
                using(WebClient client = new WebClient())
                {
                    string json = client.DownloadString(urlForSingle);
                    return json;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }

        public static string GetAll()
        {
            string urlForAll = $"{url}";
            try
            {
                using(WebClient client = new WebClient())
                {
                    string json = client.DownloadString(urlForAll);
                    return json;
                }
            }
            catch(Exception ex)
            {
                return ex.Message;
            }
        }
        /*
        private Task<string> CallWebApi(string url)
        {
            using(WebClient client = new WebClient())
            {
                return client.DownloadString(url);
            }
        }
        private Booking UnpackFrom(string json)
        {
            return JsonConvert.DeserializeObject<Booking>(json);
        }*/
    }
}
