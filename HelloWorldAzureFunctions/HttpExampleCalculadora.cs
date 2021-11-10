using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace HelloWorldAzureFunctions
{
    public static class HttpExampleCalculadora
    {
        [FunctionName("HttpExample")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");
            double a = 0;
            double b = 0;

            string operacao = req.Query["operacao"].ToString() ?? string.Empty ;
            string responseMessage = "A Operação está nula.";

            if (!string.IsNullOrEmpty(operacao))
            {
                if (req.Query.ContainsKey("a"))
                    a = double.Parse(req.Query["a"].ToString());

                if (req.Query.ContainsKey("b"))
                    b = double.Parse(req.Query["b"].ToString());
                
                double resultado = 0.0;

                if (operacao.Equals("soma"))
                    resultado = Calculo.Somar(a, b);
                else if (operacao.Equals("subtracao"))
                    resultado = Calculo.Subtrair(a, b);
                else if (operacao.Equals("multiplicacao"))
                    resultado = Calculo.Multiplicar(a, b);
                else if (operacao.Equals("divisao"))
                    resultado = Calculo.Dividir(a, b);

                responseMessage = $"O Resultado da {operacao} é {resultado}";
            }

            return new OkObjectResult(responseMessage);
        }

        
    }
}
