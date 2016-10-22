namespace WebApplication1.Controllers
{
    public interface IFooService
    {
        object GetBaz();
        object PostBaz(string value);
        object PutBaz(string value);
        object GetABaz(int id);
    }
}