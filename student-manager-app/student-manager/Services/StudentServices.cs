using Microsoft.Extensions.Options;
using MongoDB.Driver;
namespace student_manager.Services
{
    public class StudentServices
    {
        private readonly IMongoCollection<Models.Student> _studentCollection;
        public StudentServices(IOptions<Data.DatabaseSettings> settings)
        {
            var mongoClient = new MongoClient(settings.Value.Connection);
            var mongoDb = mongoClient.GetDatabase(settings.Value.DatabaseName);
            _studentCollection = mongoDb.GetCollection<Models.Student>(settings.Value.CollectionName);
        }

        public async Task<List<Models.Student>> GetAsync()
        {
            return await _studentCollection.Find(_ => true).ToListAsync();
        }

        public async Task<Models.Student> getAsync(string id) => await _studentCollection.Find(x => x.Id == id).FirstOrDefaultAsync();
        public async Task CreateAsync(Models.Student newStudent) => await _studentCollection.InsertOneAsync(newStudent);
        public async Task UpdateAsync(string id, Models.Student updatedStudent) => await _studentCollection.ReplaceOneAsync(x => x.Id == id, updatedStudent);
        public async Task RemoveAsync(string id) => await _studentCollection.DeleteOneAsync(x => x.Id == id);
    }
}
