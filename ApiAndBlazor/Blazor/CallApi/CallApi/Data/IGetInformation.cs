using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CallApi.Data
{
    public interface IGetInformation
    {
       public Task<List<MInformation>> GetInfo();
    }
}
