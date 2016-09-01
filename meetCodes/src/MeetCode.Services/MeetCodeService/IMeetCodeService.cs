using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meetCodes.Services.MeetCodeService
{
    public interface IMeetCodeService
    {
        Task<string> GetMeetCodesAsync(string id);
        Task<string> CreateMeetCodesAsync(string meetCode);
    }
}
