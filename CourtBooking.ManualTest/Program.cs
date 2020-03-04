using CourtBooking.Entities;
using CourtBooking.Service;
using System;
using System.Collections.Generic;

namespace CourtBooking.ManualTest
{
    class Program
    {
        public static BookingService bookingService = new BookingService();

        public static void Main()
        {
            WriteAll();
        }
        public static void WriteAll()
        {
            List<Booking> bookings = bookingService.GetAll();

            foreach(Booking booking in bookings)
            {
                Console.WriteLine(booking);
            }
        }
        public static void WriteSingle()
        {
            Booking booking = bookingService.GetSingle(1);
            Console.WriteLine(booking);
        }
    }
}