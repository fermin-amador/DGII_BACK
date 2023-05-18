using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DGII.Data.Models;
using DGII.Interfaces.Services;

namespace DGII.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComprobantesFiscalesController : ControllerBase
    {
        private readonly IComprobanteFiscalServices _IComprobanteFiscalServices;

        public ComprobantesFiscalesController(IComprobanteFiscalServices IComprobanteFiscalServices)
        {
            _IComprobanteFiscalServices = IComprobanteFiscalServices;
        }


        //Clientes por Empresa
        [HttpPost("GetComprobantesFiscalesByRncCedula/{rncCedula}")]
        public async Task<IActionResult> GetComprobantesFiscalesByRncCedula(string rncCedula)
        {
            try
            {
                var ComprobantesFiscales = await _IComprobanteFiscalServices.GetComprobantesFiscalesByRncCedula(rncCedula);
                if (ComprobantesFiscales.Count() == 0) return Ok("No hay Comprobantes Fiscales asociado con este contribuyente");
                return Ok(ComprobantesFiscales);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);

            }           
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var ComprobantesFiscales = await _IComprobanteFiscalServices.GetAll();
                return Ok(ComprobantesFiscales);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ComprobanteFiscalById(int id)
        {
            try
            {
                var ComprobanteFiscal = await _IComprobanteFiscalServices.Get(id);
                if (ComprobanteFiscal == null) return BadRequest("Comprobante Fiscal no existe");
                return Ok(ComprobanteFiscal);
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
           
        }

        [HttpPost]
        public async Task<IActionResult> AddComprobanteFiscal(ComprobanteFiscal ComprobanteFiscal)
        {
            try
            {
                if (ComprobanteFiscal == null) return BadRequest("Envio una Comprobante Fiscal vacio o imcompleto");
                _IComprobanteFiscalServices.Add(ComprobanteFiscal);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }

            
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateComprobanteFiscal(int id, ComprobanteFiscal ComprobanteFiscal)
        {
            try
            {
                if (ComprobanteFiscal == null) return BadRequest("Envio una Comprobante Fiscal vacio o imcompleto");
                var ComprobanteFiscalDB = await _IComprobanteFiscalServices.Get(id);
                if (ComprobanteFiscalDB == null) return BadRequest("Comprobante Fiscal no existe");
                _IComprobanteFiscalServices.Update(ComprobanteFiscalDB, ComprobanteFiscal);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
           

           
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComprobanteFiscal(int id)
        {
            try
            {
                var ComprobanteFiscalById = await _IComprobanteFiscalServices.Get(id);
                if (ComprobanteFiscalById == null) return BadRequest("ComprobanteFiscal no existe");
                _IComprobanteFiscalServices.Delete(ComprobanteFiscalById);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return BadRequest(ex.Message);
            }
            

        }

  
    }
}
