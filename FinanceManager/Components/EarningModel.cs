using System;
using FinanceManager.Shared;

namespace FinanceManager.Components
{
    public class EarningModel
    {
        public DateTime Date { get; set; }
        public string Subject { get; set; }
        public EarningCategory Category { get; set; }
        public decimal Amount { get; set; }

    }
}
