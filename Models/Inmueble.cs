using MongoDB.Bson.Serialization.Attributes;
public class Inmueble {
    [BsonId]
    [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]

    public string? id { get; set; }

    [BsonElemnt("tipo")]
    public string Tipo { get; set; } = string.Empty;
    [BsonElemnt("operacion")]
    public string Operacion { get; set; } = string.Empty;
    [BsonElemnt("nombre_agente")]
    public string NombreAgente { get; set; } = string.Empty;
    [BsonElemnt("baños")]
    public int Banos { get; set; }
    [BsonElemnt("metros_terreno")]
    public int Metrosterreno  { get; set; }
    [BsonElemnt("metros_construccion")]
    public int  MetrosContruccion { get; set; }
    [BsonElemnt("tiene_patio")]
    public bool  TienePatio { get; set; }
    [BsonElemnt("pisos")]
    public int Pisos { get; set; }
    [BsonElemnt("agencia")]
    public string Agencia { get; set; } = string.Empty;
    [BsonElemnt("fecha_publicacion")]
    public string  FechaPublicacion { get; set; } = string.Empty;
    [BsonElemnt("costo")]
    public int Costo { get; set; }

}
