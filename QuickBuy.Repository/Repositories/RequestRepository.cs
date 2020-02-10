using QuickBuy.Domain.Contracts;
using QuickBuy.Domain.Entities;
using QuickBuy.Repository.Context;

namespace QuickBuy.Repository.Repositories
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(QuickBuyContext quickBuyContext) : base(quickBuyContext)
        {
        }
    }
}
