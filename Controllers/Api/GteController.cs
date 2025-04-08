using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gte")]
public class GteController : Controller {
    [HttpGet("mostrar-pisos")]
    public IActionResult NumeroDePisos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //Obtener todas las casa en ventacon mas de 500 metros de construccion
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Pisos, 2);
        
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //2
    [HttpGet("metros-terreno")]
    public IActionResult MetrosTerrenos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Metrosterreno, 500);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //3
        [HttpGet("fecha-publicacion")]
    public IActionResult FechaPublicacion(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.FechaPublicacion, "2025-02-01");
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //4
    [HttpGet("mostrar-costo")]
    public IActionResult Costo(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Costo, 10000);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //5
        [HttpGet("mostrar-baños")]
    public IActionResult banos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Gte(x => x.Banos, 3);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }


}