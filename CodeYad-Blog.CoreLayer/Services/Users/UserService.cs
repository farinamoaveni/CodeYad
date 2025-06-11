using CodeYad_Blog.CoreLayer.DTOS.Users;
using CodeYad_Blog.CoreLayer.Utilities;
using CodeYad_Blog.DataLayer.Context;
using CodeYad_Blog.DataLayer.Entities;



namespace CodeYad_Blog.CoreLayer.Services.Users
{
    public class UserService : IUserService
    {
        private readonly BlogContext _context;

        public UserService(BlogContext context)
        {
            _context = context;
        }

        public OperationResult RegisterUser(UserRegisterDto registerDto)
        {
            try
            {
                var isUserNameExist = _context.Users.Any(u => u.UserName == registerDto.UserName);

                if (isUserNameExist)
                    return OperationResult.Error("نام کاربری تکراری است");

                var passwordHash = registerDto.Password.EncodeToMd5();
                var newUser = new User()
                {
                    FullName = registerDto.FullName,
                    IsDelete = false,
                    UserName = registerDto.UserName,
                    Role = UserRole.User,
                    CreationDate = DateTime.Now,
                    Password = passwordHash
                };

                _context.Users.Add(newUser);
                int recordsAffected = _context.SaveChanges();

                if (recordsAffected > 0)
                    return OperationResult.Success();
                else
                    return OperationResult.Error("خطا در ذخیره کاربر");
            }
            catch (Exception ex)
            {
                // Log the exception
                return OperationResult.Error($"خطای سیستمی: {ex.Message}");
            }
        }

        public UserDto LoginUser(loginUserDto loginDto)
        {
            var passwordHashed = loginDto.Password.EncodeToMd5();
            var user = _context.Users
                .FirstOrDefault(u => u.UserName == loginDto.UserName && u.Password == passwordHashed);

            if (user == null)
                return null;

            var userDto = new UserDto()
            {
                FullName = user.FullName,
                Password = user.Password,
                Role = user.Role,
                UserName = user.UserName,
                RegisterDate = user.CreationDate,
                UserId = user.Id
            };
            return userDto;
        }
    }
}

