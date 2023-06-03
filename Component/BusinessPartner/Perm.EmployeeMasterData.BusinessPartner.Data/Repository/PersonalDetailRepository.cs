﻿using Microsoft.AspNetCore.Http;
using Perm.DataAccessLayer.Database.SqlServer;
using Perm.DataAccessLayer.DataRepository.Core;
using Perm.EmployeeMasterData.BusinessPartner.Data.Repository.Abstraction;
using Perm.Model.EmployeeMasterData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perm.EmployeeMasterData.BusinessPartner.Data.Repository
{
    public class PersonalDetailRepository : Repository<PersonalDetailModel>, IPersonalDetailRepository
    {
        public PersonalDetailRepository(PermDataContext dataContext, IHttpContextAccessor httpContextAccessor) : base(dataContext, httpContextAccessor)
        {
        }
    }
}
