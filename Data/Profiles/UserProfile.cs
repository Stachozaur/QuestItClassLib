using AutoMapper;
using Job.it_classes.Data.Entities;
using Job.it_ClassLib.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Job.it_ClassLib.Data.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserDTO>()
                .ReverseMap();

            CreateMap<User, CreateUpdateUserDTO>()
                .ReverseMap()
                .ForMember(c => c.Role, opt => opt.Ignore());
        }
    }
}
