using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Employee.Domain.Model.Dtos;
using Employee.Domain.Model.Entities;

namespace Employee.Service.Mappers
{
    public class MappingProfile :Profile
    {
        public MappingProfile() 
        {

            CreateMap<EmpTable, EmpTableDto>().ReverseMap();
        }
    }
}
