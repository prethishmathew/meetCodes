using System.Threading.Tasks;
using MeetCodes.MeetCodeDTO;

namespace meetCodes.Services.MeetCodeService
{
    public interface IMeetCodeService
    {
        Task<MeetCodesDto> GetMeetCodesAsync(string id);
        Task<MeetCodesDto> CreateMeetCodesAsync(MeetCodesDto meetCode);
    }
}
