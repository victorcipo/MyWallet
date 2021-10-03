using MongoDB.Driver;
using MyWallet.CrossCutting.Configuration.AppSettings;
using MyWallet.Infrastructure.Data.MongoDb.Entities;
using System.Collections.Generic;
using System.Linq;
using MyWallet.Infrastructure.Data.MongoDb.Interfaces;

namespace MyWallet.Infrastructure.Data.MongoDb.Queries
{
    public class LancamentoQuery : ILancamentoQuery
    {
        private readonly IMongoCollection<Lancamentos> _lancamentos;

        public LancamentoQuery(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _lancamentos = database.GetCollection<Lancamentos>(settings.Collections.Lancamentos);
        }

        public List<Lancamentos> Get() =>
            _lancamentos.Find(book => true).ToList();
    }
}
