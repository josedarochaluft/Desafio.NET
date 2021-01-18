using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("taxaJuros")]
    public class TaxaDeJurosController : ControllerBase
    {
        [HttpGet]
        public float Get()
        {
            return TaxaDeJuros.Juros;
        }
    }
}
