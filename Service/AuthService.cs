using auth.DTO;
using auth.Model;
using auth.Repository;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

namespace auth.Service
{
    public class AuthService
    {
       private readonly SHA256 Sha256 = SHA256.Create();
       private readonly UserRepository userRepository;
       public AuthService(UserRepository userRepository)
       {
            this.userRepository = userRepository; 
       }

        private string HashPassword(string? password)
        {
            if (password != null)
            {
                byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
                byte[] hash = Sha256.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
            throw new Exception("Не указан пароль");
        }

        private bool СheckPassword(string password, string password_check)
        {
            byte[] data = System.Text.Encoding.UTF8.GetBytes(password);
            byte[] hash = Sha256.ComputeHash(data);
            return Convert.ToBase64String(hash).Equals(password_check);
        }

        private UserModel ConvertUserDtoCreatedToUserModel(UserDtoCreated userDtoCreated)
        {
            UserModel userModel = new()
            {
                Password = HashPassword(userDtoCreated.Password),
                Email = userDtoCreated.Email,
                Login = userDtoCreated.Login
            };
            return userModel;
        }

        public void Register(UserDtoCreated userDtoCreated)
        {
            UserModel userModel = ConvertUserDtoCreatedToUserModel(userDtoCreated);
            userRepository.CreateUser(userModel);
        }
    }
}
