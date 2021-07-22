using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace enigmaBilleteras.Models
{
    public class miUsuario : IdentityUser
    {
        public string nombre { get; set; }

        public string apellido { get; set; }
    
        public int dni { get; set; }

        public byte[] FotoPerfil { get; set; }
    }

}
