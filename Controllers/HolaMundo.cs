using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FormularioAsignacion.Controllers
{
    public class HolaMundo : Controller
    {
        public string Index()
        {
            return "Hola Mundo";
        }
    }
}
