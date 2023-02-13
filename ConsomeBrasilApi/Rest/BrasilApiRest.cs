using ConsomeBrasilApi.DTOs;
using ConsomeBrasilApi.Interfaces;
using ConsomeBrasilApi.Models;
using System.Dynamic;
using System.Text.Json;

namespace ConsomeBrasilApi.Rest
{
    public class BrasilApiRest : IBrasilApi
    {
        public async Task<ResponseGenerico<List<Feriado>>> BuscaTodosFeriadosPorAno(string ano)
        {
            var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/feriados/v1/{ano}");

            var response = new ResponseGenerico<List<Feriado>>();
            using (var client = new HttpClient())
            {
                var responseBrasilApi = await client.SendAsync(request);
                var contentResp = await responseBrasilApi.Content.ReadAsStringAsync();
                var objResponse = JsonSerializer.Deserialize<List<Feriado>>(contentResp);

                if(responseBrasilApi.IsSuccessStatusCode)
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.DadosRetorno = objResponse;
                }
                else
                {
                    response.CodigoHttp = responseBrasilApi.StatusCode;
                    response.ErroRetorno = JsonSerializer.Deserialize<ExpandoObject>(contentResp);
                }
            }

            return response;
        }
    }
}
