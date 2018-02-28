using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public static class ExpLevelMapper
    {

        public static int CalculateExp(String level)
        {
            int newExp;
            Contract.Ensures(Contract.Result<string>() != null);
            if (string.IsNullOrEmpty(level))
            {
                throw new ArgumentException("message", nameof(level));
            }
            return newExp = (int)(10 * 10 * Convert.ToInt64(level));
        }
    }
}
