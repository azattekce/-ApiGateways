using Reservation.API.Infrustructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber)
        {
            return new ReservationDTO
            {
                Id = 10,
                Amount = 30,
                BkgDate = DateTime.Now,
                CheckingDate = DateTime.Now,
                CheckOutDate = DateTime.Now,
                ReservationNumber = 20
            };
        }


         public List<ReservationDTO> GetRes()
        {
            return new List<ReservationDTO>{
                new ReservationDTO {
                    Id = 10,
                    Amount = 100,
                    BkgDate = DateTime.Now,
                    CheckingDate = DateTime.Now,
                    CheckOutDate = DateTime.Now,
                    ReservationNumber = 10
                },

                   new ReservationDTO {
                    Id = 20,
                    Amount = 200,
                    BkgDate = DateTime.Now,
                    CheckingDate = DateTime.Now,
                    CheckOutDate = DateTime.Now,
                    ReservationNumber = 20
                },
                      new ReservationDTO {
                    Id = 30,
                    Amount = 300,
                    BkgDate = DateTime.Now,
                    CheckingDate = DateTime.Now,
                    CheckOutDate = DateTime.Now,
                    ReservationNumber = 30
                }

            };
        }
    }
}