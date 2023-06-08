using SupperHeroAPI.Models;

namespace SupperHeroAPI.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
