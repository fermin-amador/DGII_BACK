using Microsoft.EntityFrameworkCore;
using DGII.Data.Models;
using DGII.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Data.Repositories
{
    public class ContribuyenteRepository : IContribuyenteRepository
    {
        private DgiiDbContext _context;
        public ContribuyenteRepository(DgiiDbContext context)
        {
            _context = context;
        }

        public async Task<Contribuyente> Get(int id)
        {
          
            return await _context.Contribuyentes.FindAsync(id);
            
        }

        public async Task<IEnumerable<Contribuyente>> GetAll()
        {
            return await _context.Contribuyentes.ToListAsync();
        }

        public void Add(Contribuyente entity)
        {
            _context.Contribuyentes.Add(entity);
            _context.SaveChanges();

        }

        public void Delete(Contribuyente entity)
        {
            _context.Contribuyentes.Remove(entity);
            _context.SaveChanges();
        }
        public void Update(Contribuyente dbEntity, Contribuyente entity)
        {
          
            dbEntity.rncCedula = entity.rncCedula;
            dbEntity.nombre = entity.nombre;
            dbEntity.tipo = entity.tipo;
            dbEntity.estatus = entity.estatus;
            
            _context.Contribuyentes.Update(dbEntity);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Contribuyente>> GetContribuyentesByRncCedula(string rncCedula)
        {
            return await _context.Contribuyentes.Where(x => x.rncCedula == rncCedula).ToListAsync();
        }
    }
}
