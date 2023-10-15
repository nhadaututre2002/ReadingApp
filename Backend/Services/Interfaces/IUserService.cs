using Backend.Dto;
using Backend.Dto.Users;
using Backend.Entities;



namespace Backend.Services.Interfaces
{
    public interface IUserService
    {
        void Create(CreateUserDto input);
        List<UserPriceDto> GetAll();
        Users GetbyId(int id);
        string Login(LoginDto input);
        void Update(UpdateUserDto input);
        void UpdateUser(Users input);
        void DeleteUser(int id);


            
    }
}
