using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Byos.Models
{
    public interface ITenantsRepository
    {
        Tenants GetTenant(int Id);
    }
}
