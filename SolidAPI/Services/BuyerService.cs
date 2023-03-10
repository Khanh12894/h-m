using AutoMapper;
using SolidAPI.Entities;
using SolidAPI.Intefaces;
using SolidAPI.Models;
using System.Threading.Tasks;

namespace SolidAPI.Services
{
    public class BuyerService : IBuyerService
    {
        public DataContext _context;
        public IMapper _mapper; 

        public BuyerService(DataContext context, IMapper map) { 
            _context = context;
            _mapper = map;
        }
        public Task<bool> Create(BuyerModel model)
        {
            var buyer = _mapper.Map<Buyer>(model);
            _context.Add<Buyer>(buyer);
            _context.SaveChanges();
            return Task.FromResult(true);

        }
    }
}
