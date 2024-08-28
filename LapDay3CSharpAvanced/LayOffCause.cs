using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapDay3CSharpAdvanced
{
    [Flags]
    internal enum LayOffCause : byte
    {
        AgeAboveSixty = 1,
        HolidayStockLessThanZero = 2
    }
}
