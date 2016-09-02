using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetCodes.Data.Models;

namespace MeetCodes.Data.InterFace
{
    public interface IMeetCodeRepository:IGenericRepository<MeetCode>
    {
        MeetCode GetById(string id);
    }
}
