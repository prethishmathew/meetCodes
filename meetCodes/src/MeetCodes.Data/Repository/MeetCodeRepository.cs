using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
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
            var number = BitConverter.ToString(Convert.FromBase64String(id)) ;
            return Context.MeetCodes.FirstOrDefault(x => x.Code == BigInteger.Parse(number));
        }
    }
}
