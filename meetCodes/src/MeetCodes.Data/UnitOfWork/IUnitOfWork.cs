using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using MeetCodes.Data.InterFace;
using Microsoft.EntityFrameworkCore;

namespace MeetCodes.Data.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        MeetCodesContext Context { get; set; }
        IMeetCodeRepository MeetCodeRepository { get; set; }
        void Save();

    }
}
