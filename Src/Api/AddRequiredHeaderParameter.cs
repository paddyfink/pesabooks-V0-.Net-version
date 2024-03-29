﻿using Swashbuckle.AspNetCore.SwaggerGen;
using System.Collections.Generic;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Any;
using Pesabooks.Api.Common;

namespace Pesabooks.Api
{
    public class AddRequiredHeaderParameter : IOperationFilter
    {
        public void Apply(OpenApiOperation operation, OperationFilterContext context)
        {

            if (operation.Parameters == null)
                operation.Parameters = new List<OpenApiParameter>();

            operation.Parameters.Add(new OpenApiParameter()
            {
                Name = Constants.HttpContextTenantKey,
                Description = "Tenant Id",
                In = ParameterLocation.Header,
               // Schema = new OpenApiSchema() { Type = "String" },
                Required = false,
                Example = new OpenApiString("1")
            });
        }
    }
}
