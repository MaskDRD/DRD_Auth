using auth.Model;

namespace auth.Repository
{
    public class UserRepository
    {
        private ApplicationContext aplicationContext;

        public UserRepository(ApplicationContext aplicationContext) {
            this.aplicationContext = aplicationContext;
        }

        public void createUser(UserModel userModel)
        {
            aplicationContext.Add(userModel);
        }

    }
}
