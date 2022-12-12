using System;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NuGet.Common;
using static System.Formats.Asn1.AsnWriter;

namespace Loterie_project_2022.Services
{
    public class CronService : BackgroundService
    {
        
        private readonly IServiceScopeFactory _scopeFactory;
        private Timer? _timer = null;

        public CronService(IServiceScopeFactory scope)
        {
           
            _scopeFactory = scope;
          
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            
            _timer = new Timer(DoWork, null, TimeSpan.Zero,
          TimeSpan.FromMinutes(5));

            return Task.CompletedTask;
        }

        private async void DoWork(object state)
        {
            using (var scope = _scopeFactory.CreateScope())
            {
                var GameCreate = scope.ServiceProvider.GetRequiredService<GameServices>();

                // Run something
                GameCreate.CreateGame();
            }
        }
    }
}
