using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using Aplicacion.Repository;
using AutoMapper;
using Persistencia.Entities;

namespace API.profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Addresstype, AddresstypeDto>().ReverseMap();
            CreateMap<City, CityDto>().ReverseMap();
            CreateMap<Client,ClientDto>().ReverseMap();
            CreateMap<Contacttype,ContacttypeDto>().ReverseMap();
            CreateMap<Contract,ContractDto>().ReverseMap();
            CreateMap<Contracttype,ContracttypeDto>().ReverseMap();
            CreateMap<Country,CountryDto>().ReverseMap();
            CreateMap<Department,DepartamentDto>().ReverseMap();
            CreateMap<Employee,EmployeeDto>().ReverseMap();
            CreateMap<Person,PersonDto>().ReverseMap();
            CreateMap<Personaddress,Personaddress>().ReverseMap();
            CreateMap<Personcategory,PersoncategoryDto>().ReverseMap();
            CreateMap<Persontype,PersontypeDto>().ReverseMap();
            CreateMap<Schedule,ScheduleDto>().ReverseMap();
            CreateMap<Shift,ShiftDto>().ReverseMap();
        }
    }
}