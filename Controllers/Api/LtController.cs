using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lt")]
public class LtController : Controller {
    [HttpGet("metros-terreno")]
    public IActionResult MetrosTerrenos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Metrosterreno, 400);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //2
    [HttpGet("mostrar-costo")]
    public IActionResult Costo(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Costo, 100000);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //3
    [HttpGet("mostrar-pisos")]
    public IActionResult Pisos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Pisos, 2);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //4
        [HttpGet("metros-contruccion")]
    public IActionResult MetrosContruccion(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.MetrosContruccion, 100);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //5
    [HttpGet("mostrar-Banos")]
    public IActionResult Banos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        var filtro = Builders<Inmueble>.Filter.Lt(x => x.Banos, 2);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

}