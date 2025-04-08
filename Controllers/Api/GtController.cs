using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

[ApiController]
[Route("api/gt")]
public class GtController : Controller {
    [HttpGet("casas-venta-metros-terreno")]
    public IActionResult CasasEnVentaConMasDeXMetrosTerreno(int metrosContruccion){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        //Obtener todas las casa en ventacon mas de 500 metros de construccion
        var filtroCasas = Builders<Inmueble>.Filter.Eq(x => x.Tipo, "Casa");
        var filtroVenta = Builders<Inmueble>.Filter.Eq(x => x.Operacion, "Venta");
        var filtroMetros = Builders<Inmueble>.Filter.Gt(x => x.MetrosContruccion, metrosContruccion);

        var filtroCompuesto = Builders<Inmueble>.Filter.And(filtroCasas, filtroVenta, filtroMetros  );
        var list = collection.Find(filtroCompuesto).ToList();

        return Ok(list);
    }

    //1
    [HttpGet("metros-terreno")]
    public IActionResult MetrosTerrenos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Metrosterreno, 500);
        
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //2
    [HttpGet("pisos")]
    public IActionResult Pisos(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Pisos, 2);
        
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }
    //3
    
    [HttpGet("fecha-publicacion")]
    public IActionResult FechaPublicacion(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.FechaPublicacion, "2025-01-30");
        
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //4
    [HttpGet("costo")]
    public IActionResult Costo(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.Costo, 100000);
        
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }

    //5
    [HttpGet("metros-construccion")]
    public IActionResult MetrosContruccion(){
        MongoClient client = new MongoClient(CadenasConexion.Mongo_DB);
        var db = client.GetDatabase("Inmuebles");
        var collection = db.GetCollection<Inmueble>("RentasVentas");

        var filtro = Builders<Inmueble>.Filter.Gt(x => x.MetrosContruccion, 200);
        
        var list = collection.Find(filtro).ToList();

        return Ok(list);
    }
}