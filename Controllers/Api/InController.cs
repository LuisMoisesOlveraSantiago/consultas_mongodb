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

    //1
    
    [HttpGet("nombre-agente")]
    public IActionResult NombreAgente(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("Luis Fernández");

        var filtro = Builders<Inmueble>.Filter.In(x => x.NombreAgente, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    //2
    [HttpGet("numero-pisos")]
    public IActionResult NumeroDePisos(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(0);

        var filtro = Builders<Inmueble>.Filter.In(x => x.Pisos, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);

    }

    //3
    [HttpGet("numero-baños")]
    public IActionResult NumeroDeBanos(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(0);

        var filtro = Builders<Inmueble>.Filter.In(x => x.Banos, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);

    }

    //4
    [HttpGet("metros-construccion")]
    public IActionResult MetrosDeConstruccion(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<int> valores = new List<int>();
        valores.Add(0);

        var filtro = Builders<Inmueble>.Filter.In(x => x.MetrosContruccion, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);

    }

    //5
        [HttpGet("mostrar-agencia")]
    public IActionResult Agencia(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        List<string> valores = new List<string>();
        valores.Add("López Bienes Raíces");

        var filtro = Builders<Inmueble>.Filter.In(x => x.Agencia, valores);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);

    }
}
