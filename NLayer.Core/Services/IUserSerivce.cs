using NLayer.Core.DTOs;
using NLayer.Core.Model;

namespace NLayer.Core.Services
{
    public interface IUserSerivce : IService<User>
    {
        Task<CustomResponseDto<UserDto>> GetUserAsync(string name, string password);
    }
}
