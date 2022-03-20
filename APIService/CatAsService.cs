using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace CatAsService.APIService
{
    /// <summary>
    /// Classe responsável pelas requisições REST 
    /// </summary>
    public class CatAsService
    {
        /// <summary>
        /// Procure uma Raça o nome como parâmetro de consulta 'q'.
        /// </summary>
        /// <param name="Id"></param>
        public CatModel GetCaracteristicasPorID(string Id) 
        {
            //Codigo gerado no Insomnia
            var client = new RestClient("https://api.thecatapi.com/v1/breeds/search?");
            client.AddDefaultParameter("q", Id);
            var request = new RestRequest(Method.GET);
            IRestResponse response = client.Execute(request);

            //Resposta sem tratamento de erros
            if (response.StatusCode == HttpStatusCode.OK)
            {
                List<CatModel> resultados = JsonConvert.DeserializeObject<List<CatModel>>(response.Content.ToString());
                return resultados[0];
            }
            else
                return null;
        }

    }
}
