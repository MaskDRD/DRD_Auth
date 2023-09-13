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
            if (cache.Get<UserModel>(GetKeyUserCath(1))?.Id == null)
            {
                SaveCacheUserAll();
            }
        }

        private void SaveCacheUserAll()
        {
            List<UserModel> userModelList = this.userRepository.GetUserAll();
            foreach (UserModel userModel in userModelList)
            {
                SaveCacheUserId(userModel);
            }
        }

        public void SaveCacheUserId(UserModel userModel)
        {
            cache.Set(GetKeyUserCath(userModel.Id), userModel);
        }

        private string GetKeyUserCath(int id)
        {
            return nameCache + id;
        }

        public UserModel? GetUser(int id)
        {
            string key = GetKeyUserCath(id);
            if (cache.Get<UserModel>(key) != null)
            {
                return cache.Get<UserModel>(key);
            }
            return null;            
        }
    }
}
