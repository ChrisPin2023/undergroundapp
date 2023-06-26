using Microsoft.AspNetCore.Mvc;
using Services.Clients;
using Services.DTOS.Hospital;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HospitalController : ControllerBase
    {
        private readonly HospitalClient _client;

        public HospitalController(HospitalClient client)
        {
            _client = client;
        }

        [HttpGet]
        public IActionResult Exibir()
        {
            try
            {
                var listaHosp = _client.ExibirTodos();
                return Ok(listaHosp);
            }
            catch(Exception ex)
            {
                return NotFound($"{ex.Message}");
            }  
        }
    
        [HttpPost]
        public async Task<IActionResult> InserirAsync(AddHospitalDTO t)
        {
            await _client.Inserir(t);
            return Ok("Novo Dado Inserido");
        }

    }
}