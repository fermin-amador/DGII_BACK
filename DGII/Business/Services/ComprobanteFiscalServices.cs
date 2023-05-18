using DGII.Data.Models;
using DGII.Interfaces.Repositories;
using DGII.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Business.Services
{
    public class ComprobanteFiscalServices : IComprobanteFiscalServices
    {
        private readonly IComprobanteFiscalRepository _IComprobanteFiscalRepository;
        public ComprobanteFiscalServices(IComprobanteFiscalRepository IComprobanteFiscalRepository)
        {
            _IComprobanteFiscalRepository = IComprobanteFiscalRepository;
        }


        public async Task<ComprobanteFiscal> Get(int id)
        {
            return await _IComprobanteFiscalRepository.Get(id);
        }
        public async Task<IEnumerable<ComprobanteFiscal>> GetAll()
        {
            return await _IComprobanteFiscalRepository.GetAll();
        }
        public void Add(ComprobanteFiscal entity)
        {
            _IComprobanteFiscalRepository.Add(entity);
        }
        public void Delete(ComprobanteFiscal entity)
        {
            _IComprobanteFiscalRepository.Delete(entity);
        }
        public void Update(ComprobanteFiscal entityDB, ComprobanteFiscal entity)
        {
            _IComprobanteFiscalRepository.Update(entityDB, entity);
        }

        public Task<IEnumerable<ComprobanteFiscal>> GetComprobantesFiscalesByRncCedula(string RncCedula)
        {
            return _IComprobanteFiscalRepository.GetComprobantesFiscalesByRncCedula(RncCedula);
        }
    }
}
