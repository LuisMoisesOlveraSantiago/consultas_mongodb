using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/Nin")]

public class NinController : Controller{ 
    [HttpGet("nombre-agencia")]
    public IActionResult NombreAgencia(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("Fernández Inmuebles");
        valores.Add("García Propiedades");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Agencia, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    //2
    [HttpGet("numero-costos")]
    public IActionResult NumeroCosto(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(33421);
        valores.Add(31795);

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.Costo, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    //3
    [HttpGet("fecha-publicacion")]
    public IActionResult FechaDePublicacion(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("2025-02-04");
        valores.Add("2025-02-22");
        valores.Add("2025-02-16");

        var filtro = Builders<Inmueble>.Filter.Nin(x => x.FechaPublicacion, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

}