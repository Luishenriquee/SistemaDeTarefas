using Microsoft.AspNetCore.Mvc;
using SistemaDeTarefas.Models;

namespace SistemaDeTarefas.Controllers
{
    public class TarefaController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<TarefaModel>>> BuscarTarefas()
        {
            return Ok();
        }
    }
}
