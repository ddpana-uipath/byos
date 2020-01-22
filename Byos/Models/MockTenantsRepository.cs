using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Models
{
    public class MockTenantsRepository : ITenantsRepository
    {
        private List<Tenants> _tenantsList;
        public MockTenantsRepository()
        {
            _tenantsList = new List<Tenants>()
            {
                new Tenants() { Id = 1, Name = "Company1" },
                new Tenants() { Id = 2, Name = "Company2" }
            };
        }

        public Tenants GetTenant(int Id)
        {
            return _tenantsList.FirstOrDefault(t => t.Id == Id);
        }
    }
}
