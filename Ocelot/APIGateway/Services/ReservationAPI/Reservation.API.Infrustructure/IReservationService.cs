using Reservation.API.Models;
using System.Collections.Generic;

namespace Reservation.API.Infrustructure
{
    public interface IReservationService
    {
        public ReservationDTO GetResByBkgNumber(int BkgNumber);
        public List<ReservationDTO> GetRes();

      
    }
}