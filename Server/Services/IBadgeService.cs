using Scout.Shared;
using Scout.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Scout.Server.Services
{
    public interface IBadgeService
    {
        Task<ServiceResponse<List<Badge>>> Get();
    }
}
