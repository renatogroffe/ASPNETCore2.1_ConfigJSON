using Microsoft.AspNetCore.Mvc;
using APIDadosBrasil.Models;

namespace APIDadosBrasil.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadosController : ControllerBase
    {
        [HttpGet]
        public DadosPais Get([FromServices]DadosPais dados)
        {
            return dados;
        }
    }
}