using AutoMapper;
using EmployeeTaskManagement.DTOs.Auth;
using EmployeeTaskManagement.DTOs.Employee;
using EmployeeTaskManagement.DTOs.Task;
using EmployeeTaskManagement.Models;

namespace EmployeeTaskManagement.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Employee

            CreateMap<ApplicationUser, EmployeeDto>();

            CreateMap<CreateEmployeeDto, ApplicationUser>();

            CreateMap<UpdateEmployeeDto, ApplicationUser>();



            // Task

            CreateMap<CreateTaskDto, EmployeeTask>();

            CreateMap<UpdateTaskDto, EmployeeTask>();


            CreateMap<EmployeeTask, TaskDto>()
                .ForMember(dest => dest.Status,
                    opt => opt.MapFrom(src => src.Status.ToString()))

                .ForMember(dest => dest.AssignedBy,
                    opt => opt.MapFrom(src =>
                        src.AssignedBy.FirstName + " " + src.AssignedBy.LastName))

                .ForMember(dest => dest.AssignedTo,
                    opt => opt.MapFrom(src =>
                        src.AssignedTo.FirstName + " " + src.AssignedTo.LastName));
        }
    }
}