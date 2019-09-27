using System;
using System.IO;
using System.Linq;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using ReadFileAndSaveDataToDBServer.Business.Abstract;
using ReadFileAndSaveDataToDBServer.Business.Concrete;
using ReadFileAndSaveDataToDBServer.DataAccess.Abstract;
using ReadFileAndSaveDataToDBServer.DataAccess.Concrete.EntityFrameworkCore.Dals;
using ReadFileAndSaveDataToDBServer.DataAccess.Entities.Concrete;

namespace ReadFileAndSaveDataToDBServer
{

    public class Program
    {
        private static IServiceProvider _serviceProvider;
        public static void Main()
        {
            RegisterServices();
            var ballcockService = _serviceProvider.GetService<IBallcockService>();
            //var adcpService = _serviceProvider.GetService<IAdcpService>();
            //var adcpDetailService = _serviceProvider.GetService<IAdcpService>();


            Console.WriteLine("Please, drag a your folder or write a folder path and press enter...");
            var folderPath = Console.ReadLine();
            var folderName = Path.GetFileName(folderPath);
            var fileArray =
                Directory.GetFiles(folderPath ?? throw new InvalidOperationException("File path not found!"), "*.txt");

            foreach (var file in fileArray)
            {
                var firstLine = File.ReadAllLines(file, Encoding.UTF8)[0].Trim().Split(',');
                if (firstLine[0].StartsWith('#'))
                {
                    var ballcock = new Ballcock
                    {
                        Id = int.Parse(firstLine[0].TrimStart('#')),
                        BallcockNo = int.Parse(folderName.Split('-')[0])
                    };

                    if (ballcockService.GetAll().Count(b => b.Id == ballcock.Id && b.BallcockNo == ballcock.BallcockNo) == 0)
                    {
                        ballcockService.Add(ballcock);
                        Console.WriteLine("New ballcock is added.");
                    }
                }
                Console.ReadLine();
            }
            
            DisposeServices();
        }

        private static void RegisterServices()
        {
            var collection = new ServiceCollection();
            collection.AddScoped<IBallcockService, BallcockManager>();
            collection.AddScoped<IBallcockDal, EfBallcockDal>();
            collection.AddScoped<IAdcpService, AdcpManager>();
            collection.AddScoped<IAdcpDal, EfAdcpDal>();
            collection.AddScoped<IAdcpDetailService, AdcpDetailManager>();
            collection.AddScoped<IAdcpDetailDal, EfAdcpDetailDal>();

            _serviceProvider = collection.BuildServiceProvider();
        }

        private static void DisposeServices()
        {
            switch (_serviceProvider)
            {
                case null:
                    return;
                case IDisposable disposable:
                    disposable.Dispose();
                    break;
            }
        }
    }
}