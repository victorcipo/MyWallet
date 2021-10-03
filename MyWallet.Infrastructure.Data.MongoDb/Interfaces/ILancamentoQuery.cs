using MyWallet.Infrastructure.Data.MongoDb.Entities;
using System.Collections.Generic;

namespace MyWallet.Infrastructure.Data.MongoDb.Interfaces
{
    public interface ILancamentoQuery
    {
        List<Lancamentos> Get();
    }
}
