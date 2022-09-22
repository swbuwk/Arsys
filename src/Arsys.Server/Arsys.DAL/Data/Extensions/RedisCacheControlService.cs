using Arsys.Domain.Entities.CashDesk;
using Newtonsoft.Json;
using StackExchange.Redis;

namespace Arsys.DAL.Data.Extensions;

public static class RedisCacheControlExtension
{
    public static async Task SetRedisCache(this IDatabaseAsync redisDb, string key, object value) => 
        await redisDb.StringSetAsync(key, JsonConvert.SerializeObject(value));

    public static async Task<T> GetRedisCache<T>(this IDatabaseAsync redisDb, string key)
    {
        var redisCacheData = await redisDb.StringGetAsync(key);
        if (String.IsNullOrEmpty(redisCacheData)) return default; 
        return JsonConvert.DeserializeObject<T>(await redisDb.StringGetAsync(key));
    }
}