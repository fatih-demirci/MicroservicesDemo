using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int bkgNumber)
        {
            return new ReservationDTO()
            {
                Id = new Random().Next(1000),
                Amount = new Random().Next(10000),
                CheckinDate = DateTime.Now.AddDays(30),
                CheckoutDate = DateTime.Now.AddDays(37),
                BkgDate = DateTime.Now,
                BkgNumber = bkgNumber
            };
        }
    }
}
