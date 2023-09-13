using auth.Model;

namespace auth.Repository
{
    public class UserRepository
    {
        private readonly ApplicationContext aplicationContext;

        public UserRepository(ApplicationContext aplicationContext) {
            this.aplicationContext = aplicationContext;
        }

        public List<UserModel> GetUserAll()
        {
            return aplicationContext.userModel.ToList();
        }

        public int CreateUser(UserModel userModel)
        {
            aplicationContext.userModel.Add(userModel);
            return aplicationContext.SaveChanges();
        }

    }
}
