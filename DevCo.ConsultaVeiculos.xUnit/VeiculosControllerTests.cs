using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using DevCo.ConsultaVeiculos.WebAPI.Models;
using Xunit;
using DevCo.ConsultaVeiculos.API.IntegrationTests;
using DevCo.ConsultaVeiculos.WebAPI;

namespace DevCo.ConsultaVeiculos.API.IntegrationTests
{
    public class VeiculosControllerTests : IClassFixture<TestFixture<Startup>>
    {
        private readonly HttpClient Client;

        public VeiculosControllerTests(TestFixture<Startup> fixture)
        {
            Client = fixture.Client;
        }


        [Fact]
        public async Task TestPostSaveVeiculosAsync()
        {
            // Arrange
            var request = new
            {
                Url = "/api/gravar-placa/",
                Body = new
                {
                    Placa = "UNT1010",
                    Proprietario = "xUnit Tests",
                    Veiculo_Roubado = false,
                    Ano_Fabricacao = 2019,
                    Ano_Modelo = 2020
                }
            };

            // Act
            var response = await Client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));
            await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task TestPostVeiculosAsync()
        {
            // Arrange
            var request = new
            {
                Url = "/api/consulta-placa/",
                Body =  "ABC1234"
            };

            // Act
            var response = await Client.PostAsync(request.Url, ContentHelper.GetStringContent(request.Body));
            await response.Content.ReadAsStringAsync();

            // Assert
            response.EnsureSuccessStatusCode();
        }

    }
}