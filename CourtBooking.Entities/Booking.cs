﻿using System;

namespace CourtBooking.Entities
{
    public class Booking
    {
        protected int id;
        protected int courtNumber;
        protected DateTime bookingTime;
        protected int booker;

        public Booking(int id, int courtNumber, DateTime bookingTime, int booker)
        {
            Id = id;
            CourtNumber = courtNumber;
            BookingTime = bookingTime;
            Booker = booker;
        }

        public virtual int Id
        {
            get
            {
                return id;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateInts(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(id), validationResult.errorMessage);
                }
                if(value != id)
                {
                    id = value;
                }
            }
        }

        public virtual int CourtNumber
        {
            get
            {
                return courtNumber;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateInts(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(courtNumber), validationResult.errorMessage);
                }
                if(value != courtNumber)
                {
                    courtNumber = value;
                }
            }
        }

        public virtual DateTime BookingTime
        {
            get
            {
                return bookingTime;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateBookingTime(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(bookingTime), validationResult.errorMessage);
                }
                if(value != bookingTime)
                {
                    bookingTime = value;
                }
            }
        }

        public virtual int Booker
        {
            get
            {
                return booker;
            }
            set
            {
                (bool isValid, string errorMessage) validationResult = ValidateInts(value);
                if(!validationResult.isValid)
                {
                    throw new ArgumentOutOfRangeException(nameof(booker), validationResult.errorMessage);
                }
                if(value != booker)
                {
                    booker = value;
                }
            }
        }

        public override string ToString()
        {
            return $"ID: {id}, Court number: {courtNumber}, Booking time: {bookingTime}, Booker: {booker}";
        }

        public virtual (bool, string) ValidateInts(int integer)
        {
            if(id < 0)
            {
                return (false, "Ingen af tallene må være under 0!");
            }
            else
            {
                return (true, String.Empty);
            }
        }

        public virtual (bool, string) ValidateBookingTime(DateTime bookingTime)
        {
            if(bookingTime.Year == DateTime.MinValue.Year)
            {
                return (false, "BookingTime er ugyldig!");
            }
            else
            {
                return (true, String.Empty);
            }
        }
    }
}