using MiApiJuego.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace MiApiJuego.Services
{
    public class JugadorService
    {
        private readonly IMongoCollection<Jugador> _jugadores;

        public JugadorService(IConfiguration config)
        {
            var cliente = new MongoClient(config["MongoDB:ConnectionString"]);
            var baseDeDatos = cliente.GetDatabase(config["MongoDB:DatabaseName"]);
            _jugadores = baseDeDatos.GetCollection<Jugador>("jugadores");
        }

        public List<Jugador> Obtener() =>
            _jugadores.Find(jugador => true).ToList();

        public Jugador Crear(Jugador jugador)
        {
            _jugadores.InsertOne(jugador);
            return jugador;
        }
    }
}
