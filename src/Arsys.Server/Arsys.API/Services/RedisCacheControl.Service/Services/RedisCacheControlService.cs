using Arsys.API.Services.RedisCacheControl.Service.Interfaces;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Arsys.API.Services.RedisCacheControl.Service.Services;

public class RedisCacheControlService : IRedisCacheControlService
{
    private readonly IDatabase _redisDatabase;

    public RedisCacheControlService(IConnectionMultiplexer multiplexer)
    {
        _redisDatabase = multiplexer.GetDatabase();
    }

    public async Task SetRedisCache(string key, object value) => 
        await _redisDatabase.StringSetAsync(key, JsonConvert.SerializeObject(value));

    public async Task<T> GetRedisCache<T>(string key)
    {
        var redisCacheData = await _redisDatabase.StringGetAsync(key);
        return redisCacheData == string.Empty
            ? default
            : JsonConvert.DeserializeObject<T>(await _redisDatabase.StringGetAsync(key));
    }
}