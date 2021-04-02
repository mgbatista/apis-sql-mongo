using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using proj3SqlMongo.Dto;
using proj3SqlMongo.Services;

namespace proj3SqlMongo.Controllers
{
    public class ClienteReport
    {
        [Route("api/[controller]")]
        [ApiController]
        public class ClientReport
        {

        private DbServices _dbService;
        public ClientReport()
        {
            _dbService = new DbServices();
        }
        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            return await _dbService.GetClienteAsync();
        }

        }
    }
}