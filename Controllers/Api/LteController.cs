using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/lte")]
public class LteController : Controller {
    [HttpGet("numeros-baños")]
    public IActionResult NumeroDeBanos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Banos, 2);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //2
    [HttpGet("numeros-pisos")]
    public IActionResult NumeroDePisos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Pisos, 2);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //3
    [HttpGet("numeros-costos")]
    public IActionResult Costos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Costo, 885107);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //4
    [HttpGet("metros-terrenos")]
    public IActionResult MetroDeTerreno(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.Metrosterreno, 657);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //5
    [HttpGet("metros-contruccion")]
    public IActionResult MetroDeConstruccion(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Lte(x => x.MetrosContruccion, 746);
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    
}