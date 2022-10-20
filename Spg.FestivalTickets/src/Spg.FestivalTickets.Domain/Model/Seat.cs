using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.FestivalTickets.Domain.Model
{
    public enum Categories { A, B, C, D, E, F }
    public class Seat
    {
        public int SeatNumber { get; set; }
        public Event Events { get; set; } = default!;
        public Categories Category { get; set; }
    }
}
