using System;
using MeetCodes.Data.InterFace;

namespace MeetCodes.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        MeetCodesContext Context { get; set; }
        IMeetCodeRepository MeetCodeRepository { get; set; }
        void Save();

    }
}
