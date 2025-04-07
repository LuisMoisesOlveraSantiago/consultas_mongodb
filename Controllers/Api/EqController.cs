using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/eq")]
public class EqController : Controller {
    [HttpGet("registro-agente")]
    public IActionResult ListarAgencias(string agencia, string? agente){
        //Listar todos los registros de la agencia Torres Realty
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");
        
        //Que la gencia se de la inmobiliaria perez 
        var filtroAgencia = Builders<Inmueble>.Filter.Eq(x=> x.Agencia, agencia);

        if(!string.IsNullOrWhiteSpace(agente)){
            var filtroAgente = Builders<Inmueble>.Filter.Eq(x => x.NombreAgente,  agente);
            var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroAgencia, filtroAgente);
            var lista = collection.Find(filtroCompuesto).ToList();

            return Ok(lista);
        }

        else{
            var lista = collection.Find(filtroAgencia).ToList();

            return Ok(lista);

        }
        
    }

    //2
    [HttpGet("registro-tipo")]
    public IActionResult ListarTipos(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x=> x.Tipo, "Casa");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    //3
    [HttpGet("registro-operacion")]
    public IActionResult ListarOperaciones(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x=> x.Operacion, "Renta");
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    //4
    [HttpGet("registro-baños")]
    public IActionResult ListarBanos(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x=> x.Banos, 2);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

    //5
    [HttpGet("registro-pisos")]
    public IActionResult ListarPisos(){

        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Eq(x=> x.Pisos, 2);
        var lista = collection.Find(filtro).ToList();

        return Ok(lista);
    }

}
