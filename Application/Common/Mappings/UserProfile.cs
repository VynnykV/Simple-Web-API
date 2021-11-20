using Application.Users.Queries.GetUserDetails;
using AutoMapper;
using Domain;

namespace Application.Common.Mappings
{
    public class UserProfile: Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDetailsVm>()
                .ForMember(userVm => userVm.Id,
                opt => opt.MapFrom(user => user.Id))
                .ForMember(userVm => userVm.Username,
                opt => opt.MapFrom(user => user.Username));
        }
    }
}
