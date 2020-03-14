namespace RunTrackerAPI.Models
{
    public class RunFarDatabaseSettings : IRunFarDatabaseSettings
    {
        public string RunnersCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IRunFarDatabaseSettings
    {
        string RunnersCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
