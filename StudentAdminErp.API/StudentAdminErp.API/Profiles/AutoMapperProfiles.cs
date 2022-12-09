using AutoMapper;
using StudentAdminErp.API.DomainModels;
using DataModel = StudentAdminErp.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminErp.API.Profiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<DataModel.Student, Student>()
                .ReverseMap();

            CreateMap<DataModel.Gender, Gender>()
                .ReverseMap();

            CreateMap<DataModel.Address, Address>()
                .ReverseMap();
        }
    }
}
