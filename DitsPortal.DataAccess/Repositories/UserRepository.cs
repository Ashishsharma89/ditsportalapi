using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DitsPortal.Common.Requests;
using DitsPortal.Common.Responses;
using DitsPortal.DataAccess.Data;
using DitsPortal.DataAccess.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace DitsPortal.DataAccess.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        ApplicationDBContext ObjContext;
        private MainResponse _response;

        private readonly IMapper _mapper;

        public UserRepository(ApplicationDBContext context) : base(context)
        {
            ObjContext = context;
        }
        public async Task<ProfileResponse> GetUser(GetUserRequest getUserRequest)
        {
            ProfileResponse userResponse = new ProfileResponse();
            if (getUserRequest.UserId != 0)
            {
                var Recored = await (
                    from user in ObjContext.Users
                    join gc1 in ObjContext.GlobalCodes on user.Gender equals gc1.GlobalCodeId into gcode1
                    from gcd1 in gcode1.DefaultIfEmpty()
                    join gc2 in ObjContext.GlobalCodes on user.BloodGroup equals gc2.GlobalCodeId into gcode2
                    from gcd2 in gcode2.DefaultIfEmpty()
                    join gc3 in ObjContext.GlobalCodes on user.Designation equals gc3.GlobalCodeId into gcode3
                    from gcd3 in gcode3.DefaultIfEmpty()
                    where user.UserId == getUserRequest.UserId && user.IsDeleted == false
                    select new ProfileResponse
                    {
                        //token = user.ResetToken,
                        UserId = user.UserId,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        UserName = user.UserName,
                        Email = user.Email,
                        DateOfBirth = user.DateOfBirth,
                        Gender = new Genders
                        {
                            GenderName = gcd1 != null ?  gcd1.CodeName : "",
                            Id = gcd1 != null ? gcd1.GlobalCodeId : 0
                        },
                        Designation = new Designations
                        {
                            Id = gcd3 != null ? gcd3.GlobalCodeId : 0,
                            DesignationName = gcd3 != null ? gcd3.CodeName : ""
                        },
                        Phone = user.Phone,
                        AlternateNumber = user.AlternateNumber,
                        OfficialEmail = user.OfficialEmail,
                        Skype = user.Skype,
                        PAN = user.PAN,
                        BloodGroup = new BloodGroups
                        {
                            Id = gcd2 != null ? gcd2.GlobalCodeId : 0,
                            BloodGroupName = gcd2 != null ? gcd2.CodeName : ""
                        },
                        dateofjoining = user.DateOfJoining,
                        DateOfLeaving = user.DateOfLeaving,
                        MediaId = user.MediaId,
                        LastLoggedIn = user.LastLoggedIn,
                    }).FirstOrDefaultAsync();
                userResponse = Recored;
                return userResponse;
            }
            else
            {
                return userResponse;
            }
        }

        public Task InserUpdateUserRoles(UserRolesRequest userRolesRequest)
        {
            throw new NotImplementedException();
        }
    }
}
