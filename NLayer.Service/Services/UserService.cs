using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Model;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Service.Services
{
    public class UserService : Service<User>, IUserSerivce
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserService(IGenericRepository<User> repository,IUnitOfWork unitOfWork, IUserRepository userRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<UserDto>> GetUserAsync(string name, string password)
        {
            //return await _userRepository.GetUserAsync(name, password);
            var users = await _userRepository.GetUserAsync(name, password);

            var userDto = _mapper.Map<UserDto>(users);

            return CustomResponseDto<UserDto>.Success(200, userDto);
        }
    }
}
