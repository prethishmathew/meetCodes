using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetCodes.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace MeetCodes.Data
{
    public class MeetCodesContext:DbContext
    {
        public MeetCodesContext(DbContextOptions options) :base(options)
        {
            
        }

        public DbSet<MeetCode> MeetCodes { get; set; }
    }
}
