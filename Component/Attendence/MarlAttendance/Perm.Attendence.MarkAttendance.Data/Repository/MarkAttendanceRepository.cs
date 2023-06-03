﻿using Microsoft.AspNetCore.Http;
using Perm.DataAccessLayer.Database.SqlServer;
using Perm.DataAccessLayer.DataRepository.Core;
using Perm.Model.Attendance;

namespace Perm.Attendence.MarkAttendance.Data.Repository
{
    public class MarkAttendanceRepository : Repository<MarkAttendanceModel>, IMarkAttendanceRepository
    {
        public MarkAttendanceRepository(PermDataContext dataContext, IHttpContextAccessor httpContextAccessor) : base(dataContext, httpContextAccessor)
        {
        }

        public async Task AddMarkAttendance(MarkAttendanceModel markAttendanceModel)
        {
            await AddAsync(markAttendanceModel);
            await Context.CommitChangesAsync();
        }

        public async Task UpdateMarkAttendance(MarkAttendanceModel markAttendanceModel)
        {
            Update(markAttendanceModel);
            await Context.CommitChangesAsync();
        }

        public async Task DeleteMarkAttendance(long markAttendanceID)
        {
            Delete(new MarkAttendanceModel { MarkAttendanceID = markAttendanceID });
            await Context.CommitChangesAsync();
        }


    }
}
