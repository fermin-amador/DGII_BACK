using DGII.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Interfaces.Repositories
{
    public interface IComprobanteFiscalRepository : IGenericRepository<ComprobanteFiscal>
    {
        Task<IEnumerable<ComprobanteFiscal>> GetComprobantesFiscalesByRncCedula(string rncCedula);
    }
}
