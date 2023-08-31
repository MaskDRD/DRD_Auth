﻿using auth.Model;

namespace auth.Repository
{
    public class UserRepository
    {
        private readonly ApplicationContext aplicationContext;

        public UserRepository(ApplicationContext aplicationContext) {
            this.aplicationContext = aplicationContext;
        }

        public void CreateUser(UserModel userModel)
        {
            aplicationContext.userModel.Add(userModel);
            aplicationContext.SaveChanges();
        }

    }
}
