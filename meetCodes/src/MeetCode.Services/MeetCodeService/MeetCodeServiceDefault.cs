using System.Threading.Tasks;
using AutoMapper;
using MeetCodes.Data.Models;
using MeetCodes.Data.UnitOfWork;
using MeetCodes.MeetCodeDTO;
namespace meetCodes.Services.MeetCodeService
{
    public class MeetCodeServiceDefault:IMeetCodeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MeetCodeServiceDefault(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<MeetCodesDto> GetMeetCodesAsync(string id)
        {            
            return await Task.Run(() => 
                Mapper.Map<MeetCode, MeetCodesDto>(_unitOfWork.MeetCodeRepository.GetById(id)));
        }

        public async Task<MeetCodesDto> CreateMeetCodesAsync(MeetCodesDto meetCodeDto)
        {
            await Task.Run(() => _unitOfWork.MeetCodeRepository.Insert(Mapper.Map<MeetCodesDto, MeetCode>(meetCodeDto)));
            return meetCodeDto;
        }

       
    }
}
