﻿using Jun.Admin.Service.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Jun.Admin.Service.Contract
{
   public interface IRoleService
    {
        ResponseData<List<RoleDto>> GetRoleList();
    }
}
