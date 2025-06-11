using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using MammothHouse.Models;


namespace MammothHouse
{
    public class Program
    {
        static async Task Main()
        {
            using HttpClient client = new HttpClient();
            string url = "https://api.weatherapi.com/v1/current.json?key=YOUR_API_KEY&q=Fairbanks,AK";

            HttpResponseMessage response = await client.GetAsync(url);
            string result = await response.Content.ReadAsStringAsync();

            Console.WriteLine(result);
            var builder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            var config = builder.Build();
            string apiKey = config["2b57c62844e54e999ab173149252105"];

        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();

            IHttpClientBuilder httpClientBuilder = builder.Services.AddHttpClient<WeatherApiKey>();



        }
    }
}
