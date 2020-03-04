
using CourtBooking.Service;
using System;

namespace CourtBooking.ManualTest
{
    class Program
    {
        static void Main()
        {
            BookingService.GetSingle(1);
            BookingService.GetAll();
        }
    }
}
