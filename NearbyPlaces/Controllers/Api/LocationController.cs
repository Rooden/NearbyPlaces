using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Http;
using Google.Maps;
using Google.Maps.Geocoding;
using NearbyPlaces.Dto;
using NearbyPlaces.Models;

namespace NearbyPlaces.Controllers.Api
{
    public class LocationController : ApiController
    {
        [HttpGet]
        public IEnumerable<LocationDto> FindNearbyLocations(string locationName)
        {
            var coordinates = GetCoordinatesFromAddress(locationName);

            using (var context = new ApplicationDbContext())
            {
                var res = context.Places.ToList();
                var list = new List<LocationDto>();

                foreach (var place in res)
                {
                    var distance = GetDistanceFromLatLonInKm(coordinates, new LatLng(place.Latitude, place.Longitude));

                    if (distance <= 0.5)
                    {
                        list.Add(new LocationDto
                        {
                            Address = place.Name,
                            Longitude = place.Longitude,
                            Latitude = place.Latitude,
                            Distance = distance
                        });
                    }
                }

                return list;
            }
        }

        private LatLng GetCoordinatesFromAddress(string address)
        {
            GoogleSigned.AssignAllServices(new GoogleSigned("AIzaSyDNyG3Se0JEtTj20OiN4qea8rKcvaYHdjI"));

            var request = new GeocodingRequest { Address = address };
            var response = new GeocodingService().GetResponse(request);

            if (response.Status != ServiceResponseStatus.Ok || !response.Results.Any())
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            return response.Results.First().Geometry.Location;
        }

        private double GetDistanceFromLatLonInKm(LatLng startPoint, LatLng endPoint)
        {
            double Deg2Rad(double deg) => deg * (Math.PI / 180);
            int r = 6371; // Radius of the earth in km

            var dLat = Deg2Rad(endPoint.Latitude - startPoint.Latitude);
            var dLon = Deg2Rad(endPoint.Longitude - startPoint.Longitude);
            var a =
                    Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                    Math.Cos(Deg2Rad(startPoint.Latitude)) * Math.Cos(Deg2Rad(endPoint.Latitude)) *
                    Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            var d = r * c; // Distance in km
            return d;
        }
    }
}
