using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using meetCodes.Services.MeetCodeService;
using MeetCodes.Data.Models;
using MeetCodes.Data.UnitOfWork;
using Moq;
using Xunit;

namespace MeetCodes.ServicesTests
{
    public class MeetCodeServiceDefaultTests
    {

        [Theory]
        [MemberData(nameof(GenerateMeetCode))]

        public async void TestMeetMethodGetMeetCodesAsync(MeetCode meetCode)
        {
            IUnitOfWork uow;
            Mock<IUnitOfWork> mockUOW = new Mock<IUnitOfWork>();
            mockUOW.Setup(t => t.MeetCodeRepository.GetById(It.IsAny<string>())).Returns(meetCode);
            var service = new MeetCodeServiceDefault(mockUOW.Object);
            var rmeetCode = await service.GetMeetCodesAsync("test");
            Assert.Equal(12345, meetCode.Code);
        }

        [Theory]
        [MemberData(nameof(GenerateMeetCode))]

        public async void TestMeetMethodCreateMeetCodesAsync(MeetCode meetCode)
        {
            IUnitOfWork uow;
            Mock<IUnitOfWork> mockUOW = new Mock<IUnitOfWork>();
            mockUOW.Setup(t => t.MeetCodeRepository.Insert(It.IsAny<MeetCode>()));
            var service = new MeetCodeServiceDefault(mockUOW.Object);
            var rmeetCode = await service.CreateMeetCodesAsync(meetCode);
            Assert.Equal(12345, meetCode.Code);
        }




        public static IEnumerable<object[]> GenerateMeetCode
        {
            get
            {
               
                return new[]
                {
                new object[] {
                    new MeetCode()
                    { Address1 = "33", Description = "Test", State = "MN", ZipCode = "56431", Code = 12345 } },
             
                };
            }
        }

    }
}
