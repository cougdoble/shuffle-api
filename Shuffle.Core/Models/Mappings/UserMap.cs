﻿using System.Linq;
using AutoMapper;
using Shuffle.Data.Entities;
using Shuffle.Core.Models;

namespace shuffleboard.core.Models.Mappings
{
    public class UserMap : Profile
    {
        public UserMap()
        {
            CreateMap<UserEntity, User>()
                .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
                .ForMember(x => x.Id, opt => opt.MapFrom(x => x.Id));
        }
    }
}