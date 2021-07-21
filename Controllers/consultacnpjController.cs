using api_consulta_cnpj.Utils;
using Microsoft.AspNetCore.Mvc;

namespace api_consulta_cnpj.Controllers
{
    [ApiController]
    [ApiVersion("1")]
    [Route("api/v{version:apiVersion}/[action]")]
    [Produces("application/json")]
    public class consultacnpjController : ControllerBase
    {
        private readonly Consulta _consulta;

        public consultacnpjController(Consulta _consulta) => this._consulta = _consulta;

        [HttpGet()]
        public IActionResult Ping() => Ok("Pong");

        [HttpGet("{cnpj}")]
        public IActionResult ConsultaCnpj(string cnpj)
        {
            if (!Validacao.ValidarCnpj(cnpj))
                return BadRequest("CNPJ Inválido");
            else return Ok(_consulta.Consultar(cnpj));
        }
    }
}