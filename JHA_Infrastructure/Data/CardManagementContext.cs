using JHA_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JHA_Infrastructure.Data
{
    public class CardManagementContext : DbContext
    {
        public CardManagementContext(DbContextOptions<CardManagementContext> options) : base(options)
        {

        }
        public DbSet<CardDetails> CardDetails { get; set; }

    }
}
