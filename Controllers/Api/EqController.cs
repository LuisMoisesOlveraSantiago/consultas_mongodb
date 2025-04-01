using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("registro-agente")]
    public IActionResult ListarAgencias(){
        //Listar todos los registros de la agencia Torres Realty
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var lista = collection.Find(FilterDefinition<Inmueble>.Empty).ToList();
        return Ok(lista);
    }
}