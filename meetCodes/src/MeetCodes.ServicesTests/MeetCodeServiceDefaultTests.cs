using System.Collections.Generic;
using AutoMapper;
using meetCodes.Services.MeetCodeService;
using MeetCodes.Data.Models;
using MeetCodes.Data.TestSources;
using MeetCodes.Data.UnitOfWork;
using MeetCodes.MeetCodeDTO;
using MeetCodes.MeetCodeDTO.TestSource;
using Moq;
using Xunit;

namespace MeetCodes.ServicesTests
{
    public class MeetCodeServiceDefaultTests
    {
        public MeetCodeServiceDefaultTests()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<MeetCode, MeetCodesDto>();
                cfg.CreateMap<MeetCodesDto, MeetCode>();
            });
        }
        [Theory]
        //[MemberData(nameof(GenerateMeetCode))]
        [ClassData(typeof(TestSourceMeetCode))]
        public async void TestMeetMethodGetMeetCodesAsync(MeetCode meetCode)
        {
           
            var mockUow = new Mock<IUnitOfWork>();
            mockUow.Setup(t => t.MeetCodeRepository.GetById(It.IsAny<string>())).Returns(meetCode);
            var service = new MeetCodeServiceDefault(mockUow.Object);
            var rmeetCode = await service.GetMeetCodesAsync("test");
            Assert.Equal(meetCode.CodeString, rmeetCode.CodeString);
        }

        [Theory]
        //[MemberData(nameof(GenerateMeetCode))]
        [ClassData(typeof(TestSourceMeetCodesDto))]
        public async void TestMeetMethodCreateMeetCodesAsync(MeetCodesDto meetCode)
        {
            
            Mock<IUnitOfWork> mockUow = new Mock<IUnitOfWork>();
            mockUow.Setup(t => t.MeetCodeRepository.Insert(It.IsAny<MeetCode>()));
            var service = new MeetCodeServiceDefault(mockUow.Object);
            var rmeetCode = await service.CreateMeetCodesAsync(meetCode);
            Assert.Equal(meetCode.CodeString, rmeetCode.CodeString);
        }




        public static IEnumerable<object[]> GenerateMeetCode => new[]
        {
            new object[] {
                new MeetCode()
                    { Address1 = "33", Description = "Test", State = "MN", ZipCode = "56431", CodeString = "PradsPlace" } },
             
        };

        public static IEnumerable<object[]> GenerateMeetCodesDto => new[]
        {
            new object[] {
                new MeetCodesDto()
                    { Address1 = "33", Description = "Test", State = "MN", ZipCode = "56431", CodeString = "PradsPlace" } },

        };
    }
}
