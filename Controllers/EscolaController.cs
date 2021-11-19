using System;
using Microsoft.AspNetCore.Mvc;

namespace aula18112021.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EscolaController : ControllerBase
    {
        [HttpGet]
        public Object Get()
        {
            return new {
                nome = "Etec Adolpho Berezin",
                anoFundacao = 1995,
                cidade = "Mongaguá"
            };
        }
    }
}