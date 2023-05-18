using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DGII.Data.Models
{
    [Table("Contribuyentes")]
    public class Contribuyente
    {
        [Key]
        public int contribuyenteId { get; set; }
        public string rncCedula { get; set; }
        public string nombre { get; set; }
        public string tipo { get; set; }
        public string estatus { get; set; }
     
    }
}
