using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Domain.DTO;
using AutoMapper;

namespace Service
{
    public static class AutoMapperConfig 
    {
        public static void Intialize()
        {
            AutoMapper.Mapper.Initialize(cfg =>
                {
                    cfg.CreateMap<Employee, EmployeeDTO>()
                        .ForMember(a => a.FirstName, b => b.ResolveUsing(c => c.Person.FirstName))
                        .ForMember(a => a.MiddleName, b => b.ResolveUsing(c => c.Person.MiddleName))
                        .ForMember(a => a.LastName, b => b.ResolveUsing(c => c.Person.LastName));
                });
        }
    }
}