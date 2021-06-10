﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAA.Services.IService;
using NAA.Data.Models.Domain;
using NAA.Data.Models.Repository;
using NAA.Data.IDAO;
using NAA.Data.DAO;

namespace NAA.Services.Service
{
    public class UserService : IUserService
    {
        private IUserDAO userDAO;
        public UserService()
        {
            userDAO = new UserDAO();
        }
        public IList<User> GetUsers()
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUsers(context);
            }
        }
        public User GetUser(string userId)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUser(userId, context);
            }
        }
        public User GetUserByEmailAddress(string emailAddress)
        {
            using (var context = new NAAContext())
            {
                return userDAO.GetUser(emailAddress, context);
            }
        }
    }
}