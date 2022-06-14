using FinanceManager.Shared;
using FinanceManager.Storage;
using System;

namespace FinanceManager
{
    public static class SampleData
    {
        public static void AddEarningsRepository(this IServiceCollection services)
        {
            var today = DateTime.Today;
            var lastMonth = DateTime.Today.AddMonths(-1);
            var previuosMonth = DateTime.Today.AddMonths(-2);

            var earningRepository = new MemoryRepository<Earning>();

            earningRepository.Add(new Earning { Date = new DateTime(previuosMonth.Year, previuosMonth.Month, 25), Amount = 2480, Category = EarningCategory.Coaching, Subject = "Thing" });

            services.AddSingleton<IRepository<Earning>>(earningRepository);
        }
    }
}
