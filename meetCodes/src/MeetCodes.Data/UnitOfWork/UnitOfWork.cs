using System;
using MeetCodes.Data.InterFace;
using MeetCodes.Data.Repository;

namespace MeetCodes.Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public UnitOfWork(MeetCodesContext context)
        {
            Context = context;
            MeetCodeRepository = new MeetCodeRepository(Context);
        }
        public MeetCodesContext Context { get; set; }
        public IMeetCodeRepository MeetCodeRepository { get; set; }
        public void Save()
        {
            Context.SaveChanges();
        }

        private bool _disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this._disposed = true;
        }
    }
}
