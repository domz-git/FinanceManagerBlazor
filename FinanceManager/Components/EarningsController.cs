using FinanceManager.Shared;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using FinanceManager.Storage;

namespace FinanceManager.Components
{
    [Route("api/[controller]")]
    [ApiController]

    public class EarningsController : ControllerBase
    {
        private readonly IRepository<Earning> _earningRepository;

        public EarningsController(IRepository<Earning> earningRepository)
        {
            _earningRepository = earningRepository;
        }

        [HttpGet]
        public IEnumerable<Earning> Get()
        {
            return _earningRepository.GetAll()
                .OrderBy(earning => earning.Date);
        }
    }
}
