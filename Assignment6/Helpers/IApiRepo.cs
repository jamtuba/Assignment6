using System.Threading.Tasks;
using Assignment6.Models;

namespace Assignment6.Helpers
{
    public interface IApiRepo
    {
        Task SendHttp(OfferClassDTO offerClassDTO);
    }
}