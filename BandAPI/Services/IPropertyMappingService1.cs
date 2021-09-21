using System.Collections.Generic;

namespace BandAPI.Services
{
    public interface IPropertyMappingService1
    {
        Dictionary<string, PropertyMappingValue> GetPropertyMapping<TSource, TDestination>();
        bool ValidMappingExists<TSource, TDestination>(string fields);
    }
}