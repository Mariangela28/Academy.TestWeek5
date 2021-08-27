using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academy.TestWeek5.MVC.Filters
{
    public class PiattoCodeFilter
    {
        private readonly string piattoCode;

        public PiattoCodeFilter(string code)
        {
            piattoCode = code;
        }

        //public override void OnActionExecuting(ActionExecutingContext context)
        //{
        //    //base.OnActionExecuting(context);
        //    //niente da eseguire
        //}

        //public override void OnActionExecuted(ActionExecutedContext context)
        //{
        //    context.HttpContext.Response.Headers.Add("piatto-code", piattoCode);
        //}
    }
}
