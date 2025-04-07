using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/in")]

public class InController : Controller{ 
    [HttpGet("listar-propidades-agencia-agente")]

    public IActionResult ListarPropidadesAgenciaAgente([FromQuery]string agencia, [FromQuery]List<string> agentes){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db  = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x => x.Agencia, agencia);
        var filtroAgentes = Builders<Inmueble>.Filter.In(x => x.NombreAgente, agentes);
        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroAgencia, filtroAgentes);
        var list = collection.Find(filtroCompuesto).ToList();
        return Ok(list);
    }
}
