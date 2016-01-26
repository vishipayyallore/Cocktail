using System.Threading.Tasks;

namespace CocktailUI.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
