namespace MeetCodes.MeetCodeDTO
{
    public class MeetCodesDto: ResultBase
    {        
        public virtual string CodeString { get; set; }        
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
