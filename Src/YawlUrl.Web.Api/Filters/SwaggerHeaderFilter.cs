﻿using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YawlUrl.Web.Api.Filters
{
    //public class SwaggerHeaderFilter : IOperationFilter
    //{
    //    public void Apply(Operation operation, OperationFilterContext context)
    //    {
    //        if (operation.Parameters == null)
    //            operation.Parameters = new List<IParameter>();

    //        operation.Parameters.Add(new NonBodyParameter
    //        {
    //            Name = "x-consumer",
    //            In = "header",
    //            Type = "string",
    //            Required = false
    //        });

    //        operation.Parameters.Add(new NonBodyParameter
    //        {
    //            Name = "x-traceid",
    //            In = "header",
    //            Type = "string",
    //            Required = false
    //        });
    //    }
    //}
}
