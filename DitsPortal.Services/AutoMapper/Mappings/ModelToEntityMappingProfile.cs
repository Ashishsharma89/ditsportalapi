using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
using DitsPortal.DataAccess;
using DitsPortal.DataAccess.DBEntities.Base;
//using DitsPortal.API.DBEntities;

namespace DitsPortal.Services.AutoMapper.Mappings
{
    public class ModelToEntityMappingProfile: Profile
    {
        public ModelToEntityMappingProfile()
        {
            // Request Mapping
            CreateMap<UserRegisterRequest, User>();
            CreateMap<LeaveRequest, Leaves>();

            // Response Mapping
            CreateMap<User, UserResponse>();
            CreateMap<Leaves, LeaveResponse>();
            CreateMap<User, UserResponse>();
            CreateMap<UserResponse, User>();
            CreateMap<Leaves, LeaveRequest>();


        }
    }
}
