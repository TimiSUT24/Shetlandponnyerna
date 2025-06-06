﻿using HairdresserClassLibrary.DTOs;

namespace Hairdresser.Services.Interfaces
{
    public interface IBookingService
    {
        Task<List<DateTime>> GetAllAvailableTimes(string hairdresserId, int treatmentId, DateTime day);

        Task<BookingResponseDto> BookAppointment(string customerId, BookingRequestDto request);

        Task<BookingDto> CancelBooking(string customerId, int bookingId);
        Task<BookingResponseDto> GetBookingByIdAsync(int bookingId, string customerId);

        Task<BookingResponseDto> RebookBooking(string customerId, int bookingId, BookingRequestDto bookingRequestDto);
    }
}
