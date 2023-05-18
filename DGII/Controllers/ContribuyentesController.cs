using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DGII.Data;
using DGII.Data.Models;
using DGII.Interfaces.Services;

namespace DGII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContribuyentesController : ControllerBase
    {
        private readonly IContribuyenteServices _IContribuyenteServices;

        public ContribuyentesController(IContribuyenteServices IContribuyenteServices)
        {
            _IContribuyenteServices = IContribuyenteServices;
        }


        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var Contribuyentes = await _IContribuyenteServices.GetAll();
                return Ok(Contribuyentes);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ClienteById(int id)
        {
            try
            {
                var contribuyente = await _IContribuyenteServices.Get(id);
                if (contribuyente == null) return BadRequest("Contribuyente no existe");
                return Ok(contribuyente);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddContribuyente(Contribuyente contribuyente)
        {
            try
            {
                if (contribuyente == null) return BadRequest("Envio un Contribuyente vacio o imcompleto");
                _IContribuyenteServices.Add(contribuyente);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateContribuyente(int id,Contribuyente contribuyente)
        {
            try
            {
                if (contribuyente == null) return BadRequest("Envio un Contribuyente vacio o imcompleto");
                var ContribuyenteDB = await _IContribuyenteServices.Get(id);
                if (ContribuyenteDB == null) return BadRequest("Contribuyente no existe");
                _IContribuyenteServices.Update(ContribuyenteDB, contribuyente);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

           
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContribuyente(int id)
        {
            try
            {
                var ContribuyenteById = await _IContribuyenteServices.Get(id);
                if (ContribuyenteById == null) return BadRequest("Contribuyente no existe");
                _IContribuyenteServices.Delete(ContribuyenteById);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            


        }

      
    }
}
