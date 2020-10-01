using Microsoft.AspNetCore.Mvc.Testing;
using SurfSpots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace SurfBreaks.Tests
{
    public class SurfBreaksControllerTests : IClassFixture<WebApplicationFactory<Startup>>
    {
        private readonly HttpClient _httpClient;

        public SurfBreaksControllerTests(WebApplicationFactory<Startup> factory)
        {
            _httpClient = factory.CreateDefaultClient();
        }

        [Fact]
        public async Task GetAll_ReturnsSuccessfulStatusCode()
        {
            var response = await _httpClient.GetAsync("api/SurfBreaks");
            response.EnsureSuccessStatusCode();
        }

        [Fact]
        public async Task GetAll_ReturnsSuccessfulMediaType()
        {
            var response = await _httpClient.GetAsync("api/SurfBreaks");
            Assert.Equal("application/json", response.Content.Headers.ContentType.MediaType);
        }

        [Fact]
        public async Task GetAll_ReturnsContent()
        {
            var response = await _httpClient.GetAsync("api/SurfBreaks");
            Assert.NotNull(response.Content);
            Assert.True(response.Content.Headers.ContentLength > 0);
        }
    }
}
