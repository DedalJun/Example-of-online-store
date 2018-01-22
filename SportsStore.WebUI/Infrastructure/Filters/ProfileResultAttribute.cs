using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Diagnostics;

namespace SportsStore.WebUI.Infrastructure.Filters
{
    public class ProfileResultAttribute: FilterAttribute, IResultFilter
    {
        private Stopwatch timer;

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public void OnResultExecuted(ResultExecutedContext filterConttext)
        {
            timer.Stop();
            filterConttext.HttpContext.Response.Write(string.Format("Result execution - elapsed time: {0}",
                timer.Elapsed.TotalSeconds));
            timer.Reset();
        }
    }
}