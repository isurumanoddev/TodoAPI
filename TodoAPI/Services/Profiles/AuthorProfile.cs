using AutoMapper;
using TodoAPI.Models;
using TodoAPI.Services.Models;

namespace TodoAPI.Services.Profiles
{
    public class AuthorProfile : Profile  // 1. inherit from profile
    {
        //   2.  constructor

        // 3. create map
        public AuthorProfile()
        {
            CreateMap<Author, AuthorDTO>()

                // address did not map , Solution => Make a Projection

                .ForMember(destinationMember => destinationMember.Address,
                    Options => Options.MapFrom(sourceMember =>
                        $"{sourceMember.HomeNumber},{sourceMember.Street},{sourceMember.Street}"));

            CreateMap<CreateAuthorDTO, Author>();

        }
    }
}
