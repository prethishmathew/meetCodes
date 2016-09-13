using MeetCodes.Data.Models;

namespace MeetCodes.Data.InterFace
{
    public interface IMeetCodeRepository:IGenericRepository<MeetCode>
    {
        MeetCode GetById(string id);
    }
}
