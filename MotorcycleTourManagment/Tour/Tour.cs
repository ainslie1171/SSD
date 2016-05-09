using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorcycleTourManagment
{
    class Tour
    {
        public string TourName;
        public string StartLocation;
        public string EndLocation;
        public string StartHotel;
        public string EndHotel;
        public string Route;
        public string RouteNotes;
        public string TourLeader;

        public string GetInfo()
        {
            return TourName + "','" + StartLocation + "','" + EndLocation + "','" + StartHotel + "','" + EndHotel + "','" + Route + "','" + RouteNotes + "','" + TourLeader;
        }
    }
}
