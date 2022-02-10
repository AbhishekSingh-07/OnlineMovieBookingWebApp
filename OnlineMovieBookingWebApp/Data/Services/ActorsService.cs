using Microsoft.EntityFrameworkCore;
using OnlineMovieBookingWebApp.Data.Base;
using OnlineMovieBookingWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMovieBookingWebApp.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
       

        public ActorsService(AppDbContext context) : base(context) { }
    }
}
