using FaceManagement.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FaceManagement.Server.Context
{
    public class FaceContext : DbContext
    {
        public DbSet<Face> Faces { get; set; }

        public FaceContext(DbContextOptions<FaceContext> options) : base(options)
        {

        }

    }
}
