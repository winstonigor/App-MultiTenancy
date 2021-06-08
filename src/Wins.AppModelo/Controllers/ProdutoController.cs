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
    public class ProdutoController : ControllerBase
    {
      
        private readonly ILogger<ProdutoController> _logger;

        public ProdutoController(ILogger<ProdutoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Produto> Get([FromServices]ApplicationContext db)
        {
            var produtos = db.Produtos.ToArray();

            return produtos;
        }
    }
}
