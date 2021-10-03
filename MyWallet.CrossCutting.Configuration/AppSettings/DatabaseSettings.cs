namespace MyWallet.CrossCutting.Configuration.AppSettings
{
    public class DatabaseSettings : IDatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

        public CollectionsDatabase Collections { get; set; }

        public class CollectionsDatabase
        {
            public string Lancamentos { get; set; }
        }
    }

    public interface IDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        DatabaseSettings.CollectionsDatabase Collections { get; set; }
    }
}
