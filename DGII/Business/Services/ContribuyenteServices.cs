using DGII.Data.Models;
using DGII.Data.Repositories;
using DGII.Interfaces.Repositories;
using DGII.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Services
{
    public class ContribuyenteServices:IContribuyenteServices
    {
        private readonly IContribuyenteRepository _IContribuyenteRepository;
        public ContribuyenteServices(IContribuyenteRepository IContribuyenteRepository)
        {
            _IContribuyenteRepository = IContribuyenteRepository;
        }

        public async Task<Contribuyente> Get(int id)
        {
            return await _IContribuyenteRepository.Get(id);
        }
        public async Task<IEnumerable<Contribuyente>> GetAll()
        {
            return await _IContribuyenteRepository.GetAll();
        }
        public void Add(Contribuyente entity)
        {
            _IContribuyenteRepository.Add(entity);  
        }

        public void Delete(Contribuyente entity)
        {
            _IContribuyenteRepository.Delete(entity);
        }
        public void Update(Contribuyente entityDB,Contribuyente entity)
        {
            _IContribuyenteRepository.Update(entityDB, entity);  
        }

        public async Task<IEnumerable<Contribuyente>> GetContribuyentesByRncCedula(string rncCedula)
        {
            return await _IContribuyenteRepository.GetContribuyentesByRncCedula(rncCedula);
        }
    }
}
