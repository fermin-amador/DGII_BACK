using Microsoft.EntityFrameworkCore;
using DGII.Data.Models;
using DGII.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Data.Repositories
{
    public class ComprobanteFiscalRepository : IComprobanteFiscalRepository
    {
        private readonly DgiiDbContext _context;
        public ComprobanteFiscalRepository(DgiiDbContext context)
        {
            _context = context;
        }

        public async Task<ComprobanteFiscal> Get(int id)
        {
            return await _context.ComprobantesFiscales.FindAsync(id);
        }

        public async Task<IEnumerable<ComprobanteFiscal>> GetAll()
        {
            return await _context.ComprobantesFiscales.ToListAsync();
        }

        public void Add(ComprobanteFiscal entity)
        {
            _context.ComprobantesFiscales.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(ComprobanteFiscal entity)
        {
            _context.ComprobantesFiscales.Remove(entity);
            _context.SaveChanges();
        }

        public void Update(ComprobanteFiscal dbEntity, ComprobanteFiscal entity)
        {
            dbEntity.rncCedula = entity.rncCedula;
            dbEntity.ncf = entity.ncf;
            dbEntity.monto = entity.monto;
            dbEntity.itbis18 = entity.itbis18;
            
            _context.ComprobantesFiscales.Update(dbEntity);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<ComprobanteFiscal>> GetComprobantesFiscalesByRncCedula(string rncCedula)
        {
            return await _context.ComprobantesFiscales.Where(x => x.rncCedula == rncCedula).ToListAsync();
        }
    }
}
