using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Net.Http.Headers;

namespace api_consulta_cnpj.Filters
{
    public class AutenticationFilter :  IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context) { }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.Request.Headers.ContainsKey("tokenapi"))
            {
                context.Result = new ContentResult() { Content = "Token não informado." }; return;
            }
            else
            {
                string token = AuthenticationHeaderValue.Parse(context.HttpContext.Request.Headers["tokenapi"]).ToString();
                if (string.IsNullOrEmpty(token))
                {
                    context.Result = new ContentResult() { Content = "Token não informado." }; return;
                }
                else if (!token.Equals("0B148103-571F-8CE5-F032-65DAB8F65C87"))
                {
                    context.Result = new ContentResult() { Content = "Token inválido." }; return;
                }
            }
        }
    }
}