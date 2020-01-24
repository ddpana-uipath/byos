﻿using Byos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public string Index()
        {
            return _userRepository.GetUser(1).Name;
        }
        public string Details(int id)
        {
            return _userRepository.GetUser(id).Name;
        }

    }
}