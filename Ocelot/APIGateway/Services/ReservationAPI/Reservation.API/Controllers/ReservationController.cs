using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Reservation.API.Infrustructure;
using Reservation.API.Models;
using System.Collections.Generic;

namespace Reservation.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ReservationController : ControllerBase
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
            return _reservationService.GetResByBkgNumber(Id);
        }

        [HttpGet("GetAll")]
        public List<ReservationDTO> GetAll()
        {
            return _reservationService.GetRes();
        }
    }
}