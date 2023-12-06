using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KakoytoMessenger.Models;
using Microsoft.EntityFrameworkCore;

namespace KakoytoMessenger.Data
{
    public class MessangerDbContext : DbContext
    {
        public MessangerDbContext(DbContextOptions<MessangerDbContext> options) : base(options)
        {
            
        }

        public DbSet<Message> Messages { get; set; }
    }
}