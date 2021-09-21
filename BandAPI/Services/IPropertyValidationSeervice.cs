namespace BandAPI.Services
{
    public interface IPropertyValidationSeervice
    {
        bool HasValidProperties<T>(string fields);
    }
}