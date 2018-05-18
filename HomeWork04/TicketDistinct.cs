using HomeWork04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    class StartStationDistinct : IEqualityComparer<TicketFare>
    {
        public bool Equals(TicketFare x, TicketFare y)
        {
            return x.StartStation == y.StartStation;
        }

        public int GetHashCode(TicketFare obj)
        {
            return obj.StartStation.GetHashCode();
        }
    }

    class EndStationDistinct : IEqualityComparer<TicketFare>
    {
        public bool Equals(TicketFare x, TicketFare y)
        {
            return x.EndStation == y.EndStation;
        }

        public int GetHashCode(TicketFare obj)
        {
            return obj.EndStation.GetHashCode();
        }
    }
}
