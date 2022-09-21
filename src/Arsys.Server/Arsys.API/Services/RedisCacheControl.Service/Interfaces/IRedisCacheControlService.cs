namespace Arsys.API.Services.RedisCacheControl.Service.Interfaces;

public interface IRedisCacheControlService
{
    Task SetRedisCache(string key, object value);
    Task<T> GetRedisCache<T>(string key);
}