using RealEstateApp.Api.Entity;

namespace RealEstateApp.Api.DTO.UserDTO
{
    public class UserInfoDTO
    {
        public string Username { get; set; }
        public string PhoneNumber { get; set; }


        public UserInfoDTO()
        {
            Username = string.Empty;
            PhoneNumber = string.Empty;
        }
        public UserInfoDTO(User user)
        {
            Username = user.Username;
            PhoneNumber = user.PhoneNumber;
        }
    }
}
