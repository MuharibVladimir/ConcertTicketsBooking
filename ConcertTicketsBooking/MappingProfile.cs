using AutoMapper;
using Entities.Models;
using Shared;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ConcertTicketsBooking
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Concert, ConcertDto>()
                .ForMember(c => c.Place,
                    opt => opt.MapFrom(x => x.ConcertPlace.Name));

            CreateMap<VoiceType, VoiceTypeDto>().ReverseMap();

            CreateMap<PartyConcertForCreationDto, PartyConcert>();
            CreateMap<PartyConcert, PartyConcertDto>()
                .ForMember(c => c.Place,
                    opt => opt.MapFrom(x => x.ConcertPlace.Name));

        }


    }

}
