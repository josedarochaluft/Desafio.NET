using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    public class CalculaJurosController : ControllerBase
    {
        [Route("calculajuros")]
        [HttpGet]
        public decimal Get(decimal ValorInicial, int Meses)
        {
            return CalculaJuros.Total(ValorInicial, Meses);
        }

        [Route("showmethecode")]
        [HttpGet]
        public string GetUrl()
        {
            return "https://github.com/josedarochaluft/Desafio.NET"; 
        }
    }

    
}
