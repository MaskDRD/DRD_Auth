using auth.Model;
using auth.Repository;
using Microsoft.Extensions.Caching.Memory;

namespace auth.Service
{
    public class UserServer
    {
        private readonly  IMemoryCache cache;
        private readonly UserRepository userRepository;
        private readonly string nameCache = "user-";

        public UserServer(
            IMemoryCache cache, 
            UserRepository userRepository
        )
        {
            this.cache = cache;
            this.userRepository = userRepository;  
        }

        private void saveCacheUserAll()
        {
            List<UserModel> userModelList = this.userRepository.GetUserAll();
            foreach (UserModel userModel in userModelList)
            {
                saveCacheUserId(userModel);
            }
        }

        private void saveCacheUserId(UserModel userModel)
        {
            cache.Set(getKeyUserCath(userModel.Id), userModel);
        }

        private string getKeyUserCath(int id)
        {
            return nameCache + id;
        }

        public UserModel getUser(int id)
        {
            string key = getKeyUserCath(id);
            if (cache.Get<UserModel>(key) != null)
            {
                return cache.Get<UserModel>(key);
            }
            return null;            
        }
    }
}
