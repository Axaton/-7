using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая__7
{
    class Triad
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }

        public Triad(int first, int second, int third)
        {
            First = first;
            Second = second;
            Third = third;
        }

        public Triad Add(int increase = 1)
        {
            return new Triad(First + increase, Second + increase, Third + increase);
        }

        public static Triad operator +(Triad triad, int summand)
        {
            return new Triad(
                triad.First,
                triad.Second,
                triad.Third + summand);
        }
    }
}
