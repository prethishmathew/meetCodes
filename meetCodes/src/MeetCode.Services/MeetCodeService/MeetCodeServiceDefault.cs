using System;
using System.Threading.Tasks;

namespace meetCodes.Services.MeetCodeService
{
    public class MeetCodeServiceDefault:IMeetCodeService
    {
        public Task<string> GetMeetCodesAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<string> CreateMeetCodesAsync(string meetCode)
        {
            throw new NotImplementedException();
        }
    }
}
