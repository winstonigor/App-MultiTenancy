using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wins.AppModelo.Data;
using Wins.AppModelo.Domain;

namespace Wins.AppModelo.Controllers
{
    [ApiController]
    [Route("{tenant}/[controller]")]
    public class PessoaController : ControllerBase
    {
      
        private readonly ILogger<PessoaController> _logger;

        public PessoaController(ILogger<PessoaController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Pessoa> Get([FromServices]ApplicationContext db)
        {
            var pessoas = db.Pessoas.ToArray();

            return pessoas;
        }
    }
}
