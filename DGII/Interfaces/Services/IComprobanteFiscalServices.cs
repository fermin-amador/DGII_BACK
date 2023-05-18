using DGII.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Interfaces.Services
{
    public interface IComprobanteFiscalServices:IGenericServices<ComprobanteFiscal>
    {
        Task<IEnumerable<ComprobanteFiscal>> GetComprobantesFiscalesByRncCedula(string rncCedula);
    }
}
