using System.Collections;
using System.Collections.Generic;

namespace MeetCodes.MeetCodeDTO.TestSource
{
    public class TestSourceMeetCodesDto : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // ...
            yield return new object[]
            {
                new MeetCodesDto()
                    {Address1 = "33", Description = "Test", State = "MN", ZipCode = "56431", CodeString = "PradsPlace"}
            };

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

