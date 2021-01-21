﻿using API.Extensions;
using AutoMapper;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using TennisMingle.API.Data;
using TennisMingle.API.DTOs;
using TennisMingle.API.Entities;
using TennisMingle.API.Interfaces;

namespace TennisMingle.API.Controllers
{
    [Route("api/{tennisClubId}/booking")]
    public class BookingController : BaseApiController
    {
        private readonly IUserRepository _userRepository;
        private readonly ITennisCourtRepository _tennisCourtRepository;
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;
        public BookingController(IBookingService bookingService, IMapper mapper,
            IUserRepository userRepository, ITennisCourtRepository tennisCourtRepository)
        {
            _tennisCourtRepository = tennisCourtRepository;
            _userRepository = userRepository;
            _bookingService = bookingService;
            _mapper = mapper;
        }
 
        [HttpGet]
        [Route("{bookingId}", Name = "GetBooking")]
        public async Task<ActionResult<Booking>> GetBooking(int bookingId)
        {
            return Ok(await _bookingService.GetBookingAsync(bookingId));
        }
        
        [HttpPost]
        public async Task<ActionResult> BookTennisCourt(int tennisClubId, BookingDto booking)
        {
            BookingDto newBooking;
            Booking bookingToCreate = null;
            if (await _bookingService.CheckAvailability(booking, tennisClubId))
            {
      
                var user = await _userRepository.GetUserByUsernameAsync(booking.UserName);

      
                if (user != null)
                {
                    newBooking = new BookingDto
                    {
                        UserId = user.Id,
                        DateStart = booking.DateStart,
                        DateEnd = booking.DateEnd,
                        TennisCourtId = booking.TennisCourtId,
                        FirstName = booking.FirstName,
                        LastName = booking.LastName,
                        PhoneNumber = booking.PhoneNumber

                    };
                }
                else 
                {
                    newBooking = new BookingDto
                    {
                        DateStart = booking.DateStart,
                        DateEnd = booking.DateEnd,
                        TennisCourtId = booking.TennisCourtId,
                        FirstName = booking.FirstName,
                        LastName = booking.LastName,
                        PhoneNumber = booking.PhoneNumber

                    };
                }
                _mapper.Map(newBooking, bookingToCreate);
                
                _bookingService.Book(bookingToCreate);
                if (await _bookingService.SaveAllAsync())
                {
                    var lastBooking = await _bookingService.GetLastBooking();
                    return CreatedAtRoute("GetBooking", new {tennisClubId = tennisClubId, bookingId = bookingToCreate.Id }, lastBooking);
                }
            }
            return BadRequest("Unavailable on that time");
        }

        [HttpPut]
        public async Task<ActionResult> UpdateBooking(BookingUpdateDto bookingUpdateDto)
        {
            var booking = await _bookingService.GetBookingAsync(bookingUpdateDto.Id);

            _mapper.Map(bookingUpdateDto, booking);

            _bookingService.UpdateBooking(bookingUpdateDto);

            if (await _bookingService.SaveAllAsync()) return NoContent();

            return BadRequest("Failed to modify booking");
        }

        [HttpDelete]
        [Route("{bookingId}")]

        public async Task<ActionResult> DeleteBooking(int bookingId)
        {

            _bookingService.DeleteBooking(bookingId);

            if (await _bookingService.SaveAllAsync()) return NoContent();

            return BadRequest("Failed to delete booking");
        }
    }
}

