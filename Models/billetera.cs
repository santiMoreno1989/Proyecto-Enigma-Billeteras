using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace enigmaBilleteras.Models
{
    public class billetera
    {
        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string marca { get; set; }

        public int precio { get; set; }

        public string colorDisponible { get; set; }

        public string CalidadMaterial { get; set; }
    }
}
