using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MeetCodes.Data.Models;

namespace meetCodes.Services.MeetCodeService
{
    public interface IMeetCodeService
    {
        Task<MeetCode> GetMeetCodesAsync(string id);
        Task<MeetCode> CreateMeetCodesAsync(MeetCode meetCode);
    }
}
