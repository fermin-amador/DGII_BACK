using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Data.Models
{
    [Table("ComprobantesFiscales")]
    public class ComprobanteFiscal
    {
        [Key]
        public int ComprobanteFiscalId { get; set; }
        public string rncCedula { get; set; }
        public string ncf { get; set; }
        public decimal monto { get; set; }
        public decimal itbis18 { get; set; }

    }
}
