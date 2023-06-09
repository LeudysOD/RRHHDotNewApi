using AutoMapper;
using PracticingProject.Dtos;
using PracticingProject.Entities;

namespace PracticingProject.Profiles
{

    public class EmployeProfiles:Profile
    {
   
        public EmployeProfiles()
        {
            CreateMap<Employe, EmployeDto>().ReverseMap();
        }

       

    }
}
