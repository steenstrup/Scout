using System.Collections.Generic;
using System.Threading.Tasks;
using Scout.Shared.Models;

namespace Scout.Server.Services
{
    public interface IScoutService
    {
        Task<ServiceResponse<List<Scoutt>>> Get();

        void Put(Scoutt scout);

    }
}
