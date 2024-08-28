using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LapDay1CSharpAdvanced
{
    internal class Range<T> where T : struct , IComparable<T> , ISubtractionOperators<T , T , T>
    {
        public T Minimum { get; set; }
        public T Maximum { get; set; }

        public Range(T minimum  , T maximum)
        {
            if (minimum.CompareTo(maximum) > 0)
            {
                throw new ArgumentException("Minimum should not be greater than Maximum.");
            }
            Minimum = minimum;
            Maximum = maximum;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Minimum) >= 0  && value.CompareTo(Maximum) <= 0;
        }


        public T Length()
        {
            T min = Minimum;
            T max = Maximum;
            return max - min;
        }
    }
}
