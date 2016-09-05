using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Threading.Tasks;

namespace MeetCodes.Data.Models
{
    public class MeetCode:BaseEntity
    {

        public virtual long Code { get; set; }
        public virtual string Description { get; set; }
        public virtual string Address1 { get; set; }
        public virtual string Address2 { get; set; }
        public virtual string City { get; set; }


        public virtual string State { get; set; }
        public virtual string ZipCode { get; set; }    
        public virtual decimal Longitude { get; set; }
        public virtual decimal Latitude { get; set; }
        
    }
}
