using RFT.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RFT
{
    public class Location
    {
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
    }

    public static class Helper
    {
        public static List<LocationGroup> GroupLocations(List<Location> locations)
        {
            var grouped = new List<LocationGroup>();

            foreach (var loc in locations)
            {
                var foundGroup = grouped.FirstOrDefault(group =>
                    group.Locations.Any(existingLoc => CalculateDistance(loc.Latitude, loc.Longitude, existingLoc.Latitude, existingLoc.Longitude) <= 20));

                if (foundGroup != null)
                {
                    foundGroup.Locations.Add(loc);
                }
                else
                {
                    grouped.Add(new LocationGroup { Locations = new List<Location> { loc } });
                }
            }

            return grouped;
        }


        public static double CalculateDistance(double lat1, double lon1, double lat2, double lon2)
        {
            const double R = 6371; // Earth's radius in KM
            var lat = (lat2 - lat1) * Math.PI / 180.0;
            var lon = (lon2 - lon1) * Math.PI / 180.0;

            var a = Math.Sin(lat / 2) * Math.Sin(lat / 2) +
                    Math.Cos(lat1 * Math.PI / 180.0) * Math.Cos(lat2 * Math.PI / 180.0) *
                    Math.Sin(lon / 2) * Math.Sin(lon / 2);

            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c; // Distance in KM
        }

        public static List<HeatPoint> GetHeatPoints(List<LocationGroup> groupedLocations)
        {
            return groupedLocations.Select(group => new HeatPoint
            {
                AvgLatitude = group.Locations.Average(loc => loc.Latitude),
                AvgLongitude = group.Locations.Average(loc => loc.Longitude),
                Intensity = group.Locations.Count
            }).ToList();
        }
    }

    public class LocationsRepository
    {
        private readonly AppDbContext _context;

        public LocationsRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Location> GetLocations()
        {
            var result = _context.Locations.ToList();

            return result;
        }

        public List<HeatPoint> GetHeatPointsFromSql()
        {
            return _context.HeatPoints.ToList();
        }
    }

    public class LocationGroup
    {
        public List<Location> Locations { get; set; }
    }

    public class HeatPoint
    {
        public double AvgLatitude { get; set; }
        public double AvgLongitude { get; set; }
        public int Intensity { get; set; }
    }
}
