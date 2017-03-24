using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }
        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto newRental)
        {
            // can use single or default if building a public api & below commented code
            var customer = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);
            //if (customer == null)
            //  return BadRequest("The Customer ID that was passed in is invalid!");

            // the below instead of using the m => m.id
            // the below method will translate into a sql statement like this...
            /*
                SELECT *
                FROM Movies
                WHERE Id IN (1, 2, 3)
            */
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();

            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }

           _context.SaveChanges();

            return Ok();
        }
    }
}
