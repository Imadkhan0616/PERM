﻿using Perm.Admin.Permission.Component.ApiModel;
using Perm.Admin.Permission.Data.Repository.Abstraction;
using Perm.Common.APIModel;
using Perm.Core.RequestManager.Processor;

namespace Perm.Admin.Permission.Component.Service
{
    [Authenticate]
    public class DeletePermissionService : ServiceBase
    {
        private readonly IPermissionRepository _permissionRepository;

        public DeletePermissionService(IPermissionRepository permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public override HttpMethod HttpMethod => HttpMethod.Delete;
        public override string URL => "/api/Permission/Delete";

        protected async override Task<ResponseModel<T>> ExecuteComponentAsync<T>(IRequestModel requestModel)
        {
            ReqDeletePermissionModel reqModel = CastToObject<ReqDeletePermissionModel>(requestModel);

            await _permissionRepository.DeletePermission(reqModel.PermissionID);

            return new ResponseModel<T>();
        }
    }
}