using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/ne")]
public class NeController : Controller {
    [HttpGet("tienen-patio")]
    public IActionResult TienePatio(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");


        var filtro = Builders<Inmueble>.Filter.Ne(x => x.TienePatio, true);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //2
    [HttpGet("tipo")]
    public IActionResult Tipo(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Tipo, "Terreno" );
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //3
    [HttpGet("operacion")]
    public IActionResult Operacion(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Operacion, "Renta" );
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //4
    [HttpGet("nombre-agente")]
    public IActionResult NombreAgente(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.NombreAgente, "Carlos García" );
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }
    
    //5
    [HttpGet("agencia")]
    public IActionResult Agencia(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Ne(x => x.Agencia, "Inmobiliaria Pérez" );
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

}
