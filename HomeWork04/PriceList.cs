using HomeWork04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
    class PriceList
    {
        public static List<TicketFare> GetTicketList()
        {
            var result = new List<TicketFare>
            {
                new TicketFare{StartStation = "台北", EndStation = "新竹", Fare = 177},
                new TicketFare{StartStation = "台北", EndStation = "台中", Fare = 375},
                new TicketFare{StartStation = "台北", EndStation = "嘉義", Fare = 598},
                new TicketFare{StartStation = "台北", EndStation = "台南", Fare = 738},
                new TicketFare{StartStation = "台北", EndStation = "高雄", Fare = 842},
                new TicketFare{StartStation = "新竹", EndStation = "台中", Fare = 197},
                new TicketFare{StartStation = "新竹", EndStation = "嘉義", Fare = 421},
                new TicketFare{StartStation = "新竹", EndStation = "台南", Fare = 560},
                new TicketFare{StartStation = "新竹", EndStation = "高雄", Fare = 755},
                new TicketFare{StartStation = "台中", EndStation = "嘉義", Fare = 224},
                new TicketFare{StartStation = "台中", EndStation = "台南", Fare = 363},
                new TicketFare{StartStation = "台中", EndStation = "高雄", Fare = 469},
                new TicketFare{StartStation = "嘉義", EndStation = "台南", Fare = 139},
                new TicketFare{StartStation = "嘉義", EndStation = "高雄", Fare = 245},
                new TicketFare{StartStation = "台南", EndStation = "高雄", Fare = 106},
            };

            return result;
        }
    }
}
