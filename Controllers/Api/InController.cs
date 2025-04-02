using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]

public class InController : Controller{ 
    [HttpGet("listar-propidades-agencia-agente")]

    public IActionResult ListarPropidadesAgenciaAgente(){
        MongoClient client = new MongoClient(CadenasConexion.MONGO_DB);
        var 
    }
}
