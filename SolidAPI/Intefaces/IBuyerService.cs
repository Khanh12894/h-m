using SolidAPI.Models;
using System.Threading.Tasks;

namespace SolidAPI.Intefaces
{
    public interface IBuyerService
    {
        Task<bool> Create(BuyerModel buyer);
    }
}
