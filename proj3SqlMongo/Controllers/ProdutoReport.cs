using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj3SqlMongo.Dto;
using proj3SqlMongo.Services;

namespace proj3SqlMongo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoReport
    {
        private DbServices _dbService;
        public ProdutoReport()
        {
            _dbService = new DbServices();
        }
        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            return await _dbService.GetProdutoAsync();
        }
    }
}