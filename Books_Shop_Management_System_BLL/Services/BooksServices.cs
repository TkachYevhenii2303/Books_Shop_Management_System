using AutoMapper;
using Books_Shop_Management_System_BLL.Services.Interfaces;
using Books_Shop_Management_System_DAL.Entities;
using Books_Shop_Management_System_DAL.Unit_of_Work_Pattern.Interfaces;
using Books_Shop_Management_System_DTO.Data_transfer_objects.Response_Result_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books_Shop_Management_System_BLL.Services
{
    public class BooksServices : IBooksServices
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        public BooksServices(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;

            _mapper = mapper;
        }

        public async Task<ResultResponse<IEnumerable<GetBooksResultDTO>>> GetBooksByAgeRestricitonAsync(string ageRestriction)
        {
            var result = await _unitOfWork.BooksRepository.GetBooksByAgeRestricitonAsync(ageRestriction);

            return _mapper.Map<ResultResponse<IEnumerable<Books>>, ResultResponse<IEnumerable<GetBooksResultDTO>>>(result);
        }

        public async Task<ResultResponse<IEnumerable<GetBooksByPriceResultDTO>>> GetBooksByPriceAsync()
        {
            var result = await _unitOfWork.BooksRepository.GetBooksByPriceAsync();

            return _mapper.Map<ResultResponse<IEnumerable<Books>>, ResultResponse<IEnumerable<GetBooksByPriceResultDTO>>>(result);
        }

        public async Task<ResultResponse<IEnumerable<GetGoldenBooksResultDTO>>> GetGoldenBooksAsync()
        {
            var result = await _unitOfWork.BooksRepository.GetGoldenBooksAsync();

            return _mapper.Map<ResultResponse<IEnumerable<Books>>, ResultResponse<IEnumerable<GetGoldenBooksResultDTO>>>(result);
        }
    }
}
