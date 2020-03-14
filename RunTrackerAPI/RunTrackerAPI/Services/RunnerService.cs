using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RunTrackerAPI.Models;
using MongoDB.Driver;

namespace RunTrackerAPI.Services
{
    public class RunnerService
    {
        private readonly IMongoCollection<Runner> _runners;

        public RunnerService(IRunFarDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _runners = database.GetCollection<Runner>(settings.RunnersCollectionName);
        }

        public List<Runner> Get() => 
            _runners.Find(runner => true).ToList();

        public Runner Get(string id) =>
            _runners.Find<Runner>(runner => runner.Id == id).FirstOrDefault();

        public Runner Create(Runner runner)
        {
            _runners.InsertOne(runner);
            return runner;
        }

        public void Update(string id, Runner runnerIn) =>
            _runners.ReplaceOne(runner => runner.Id == id, runnerIn);

        public void Remove(Runner runnerIn) =>
            _runners.DeleteOne(runner => runner.Id == runnerIn.Id);

        public void Remove(string id) =>
            _runners.DeleteOne(runner => runner.Id == id);
    }
}
