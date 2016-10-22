namespace WebApplication1.Controllers
{
    public interface IFooService
    {
        object GetBaz();
        object GetABaz(int id);
        object PostBaz(string value);
    }
}