using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfGameMyRPG
{
    public static class RandomProvider
    {
        private static int seed = Environment.TickCount;
        private static ThreadLocal<Random> randomWrapper = new ThreadLocal<Random>(() =>
            new Random(Interlocked.Increment(ref seed))
        );
        public static Random GetThreadRandom()
        {
            return randomWrapper.Value;
        }
    }
}
