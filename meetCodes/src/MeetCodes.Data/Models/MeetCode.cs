using System.ComponentModel.DataAnnotations.Schema;
using mstum.utils;

namespace MeetCodes.Data.Models
{
    public class MeetCode:BaseEntity
    {

        public virtual long Code { get; set; }

        [NotMapped]
        public virtual string CodeString
        {
            get { return Base36.Encode(Code); }
            set
            {
                if (value != null)
                {
                    this.Code = Base36.Decode(value);
                }
                
            }
        }

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
