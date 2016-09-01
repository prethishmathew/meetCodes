using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace MeetCodes.Data.Models
{
    public class MeetCode:BaseEntity
    {
        public virtual BigInteger Code { get; set; }
        public virtual decimal Longitude { get; set; }
        public virtual decimal Latitude { get; set; }
        
    }
}
