using Byos.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Controllers
{
    public class TenantController : Controller
    {
        private readonly ITenantsRepository _tenantsRepository;
        public TenantController(ITenantsRepository tenantsRepository)
        {
            _tenantsRepository = tenantsRepository;
        }
        public string Index()
        {
            return _tenantsRepository.GetTenant(1).Name;
        }
        public string Details(int id)
        {
            return _tenantsRepository.GetTenant(id).Name;
        }

    }
}