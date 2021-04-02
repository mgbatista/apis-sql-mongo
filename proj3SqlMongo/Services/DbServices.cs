using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using proj3SqlMongo.Dto;

namespace proj3SqlMongo.Services
{
    public class DbServices
    {
        HttpClient httpClient = new HttpClient();


        IEnumerable<ClienteDto> listCliente;

        IEnumerable<ProdutoDto> listProduto;

        public async Task<IEnumerable<ClienteDto>> GetClienteAsync()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5002");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await httpClient.GetAsync("api/Cliente");
            if (response.IsSuccessStatusCode)
            {
                var produtoString = await response.Content.ReadAsStringAsync();
                listCliente = JsonConvert.DeserializeObject<IEnumerable<ClienteDto>>(produtoString);
            }
            else
            {
                response.EnsureSuccessStatusCode();
            }
            return listCliente;
        }

        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync()
        {
            httpClient.BaseAddress = new Uri("http://localhost:5003");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await httpClient.GetAsync("api/Produto");
            if (response.IsSuccessStatusCode)
            {
                var produtoString = await response.Content.ReadAsStringAsync();
                listProduto = JsonConvert.DeserializeObject<IEnumerable<ProdutoDto>>(produtoString);
            }
            else
            {
                response.EnsureSuccessStatusCode();
            }
            return listProduto;
        }
    }
}