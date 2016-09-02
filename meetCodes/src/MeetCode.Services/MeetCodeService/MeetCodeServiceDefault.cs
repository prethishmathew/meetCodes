using System;
using System.Threading.Tasks;
using MeetCodes.Data.Models;
using MeetCodes.Data.UnitOfWork;

namespace meetCodes.Services.MeetCodeService
{
    public class MeetCodeServiceDefault:IMeetCodeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MeetCodeServiceDefault(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<MeetCode> GetMeetCodesAsync(string id)
        {
            return await Task.Run(() => _unitOfWork.MeetCodeRepository.GetById(id));
        }

        public async Task<MeetCode> CreateMeetCodesAsync(MeetCode meetCode)
        {
            await Task.Run(() => _unitOfWork.MeetCodeRepository.Insert(meetCode));
            return meetCode;
        }

       
    }
}
