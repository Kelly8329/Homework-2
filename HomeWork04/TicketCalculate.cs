using HomeWork04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    class Result
    {
        public bool HasValue { get; set; }
        public decimal Fare { get; set; }
    }

    class TicketCalculator
    {

        private bool _isReturn;
        private bool _isDiscount;
        public Result GetFare(string start, string end, bool isReturn, bool isDiscount, bool isToSouth)
        {
            _isReturn = isReturn;
            _isDiscount = isDiscount;
            TicketFare ticketFare;
            ticketFare = GetBaseTicketFare(start, end, isToSouth);

            if (ticketFare == null)
            {
                return new Result { HasValue = false };
            }
            else
            {
                var fare = Math.Ceiling(GetDiscount(GetReturn(ticketFare.Fare)));
                return new Result { HasValue = true, Fare = fare };
            }


        }

        private static TicketFare GetBaseTicketFare(string start, string end, bool isToSouth)
        {
            TicketFare ticketFare;
            if (isToSouth)
            {
                ticketFare = PriceList.GetTicketList().FirstOrDefault((x) => x.StartStation == start && x.EndStation == end);
            }
            else
            {
                ticketFare = PriceList.GetTicketList().FirstOrDefault((x) => x.EndStation == start && x.StartStation == end);
            }
            return ticketFare;
        }

        private decimal GetReturn(decimal fare)
        {
            if (_isReturn)
            {
                return fare * 2 * 0.9m;
            }
            else
            {
                return fare;
            }
        }

        private decimal GetDiscount(decimal fare)
        {
            if (_isDiscount)
            {
                return fare * 0.9m;
            }
            else
            {
                return fare;
            }
        }
    }
}
