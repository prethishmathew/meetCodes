using System.Linq;
using mstum.utils;
using MeetCodes.Data.InterFace;
using MeetCodes.Data.Models;

namespace MeetCodes.Data.Repository
{

    public class MeetCodeRepository : GenericRepository<MeetCodesContext, MeetCode>, IMeetCodeRepository
    {

        public MeetCodeRepository(MeetCodesContext context) : base(context)
        {
            
        }

        public virtual MeetCode GetById(string id)
        {
            var number = Base36.Decode(id) ;
            //Performance : Dont replace with single call to FirstOrdefault.
            var data = Context.MeetCodes.Where(x => x.Code.Equals(number));
            return data.FirstOrDefault();
        }
    }
}
