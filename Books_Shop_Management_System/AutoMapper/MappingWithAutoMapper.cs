using AutoMapper;
using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DTO.Data_transfer_objects.Response_Result_DTO;

namespace Books_Shop_Management_System.AutoMapper
{
    public class MappingWithAutoMapper : Profile
    {
        public MappingWithAutoMapper()
        {
            GenerateResultResponseMapper();

            GenerateBooksMapper();
        }

        private void GenerateBooksMapper()
        {
            CreateMap<Books, GetBooksResultDTO>();
            CreateMap<Books, GetGoldenBooksResultDTO>();

            CreateMap<Books, GetBooksByPriceResultDTO>()
                .ForMember(destination => destination.Total,
                options => options.MapFrom(source => $"This book cost: {source.Price}$"));

            CreateMap<Books, GetBooksTitleAndYearResultDTO>()
                .ForMember(destination => destination.Information,
                options => options.MapFrom(source => $"The title is {source.Title} and the date of realese is {source.ReleaseDate}"));
        }

        private void GenerateResultResponseMapper()
        {
            CreateMap(typeof(ResultResponse<>), typeof(ResultResponse<>));
        }
    }
}
