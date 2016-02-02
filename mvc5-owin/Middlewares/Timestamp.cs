using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mvc5_owin.Middlewares
{
    using System.Diagnostics;
    using AppFunc = Func<IDictionary<string, object>, Task>;
    public class Timestamp
    {
        private readonly AppFunc next;
        public Timestamp(AppFunc next)
        {
            this.next = next;
        }

        public async Task Invoke(IDictionary<string, object> environment)
        {
            var stopwatch = Stopwatch.StartNew();
            var scope = (IDictionary<string, string[]>)environment["owin.ResponseHeaders"];
            await this.next(environment);
            stopwatch.Stop();
            scope.Add("ResponseTime", new[] { stopwatch.Elapsed.ToString() });
        }
    }
}