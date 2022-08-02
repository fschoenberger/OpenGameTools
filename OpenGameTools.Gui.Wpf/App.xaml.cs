using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;

namespace OpenGameTools.Gui.Wpf {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private readonly IHost _host;
        private ILogger<App>? _log;

        public App() {
            _host = new HostBuilder()
                .ConfigureServices((context, services) => {
                    // Add services here
                    // TODO: Dynamic plugin discovery
                    services.AddSingleton<MainWindow>();
                })
                .ConfigureLogging(logging => {
                    // TODO: Make this read from settings
                    logging.AddConsole();
                    logging.AddDebug();
                })
                .Build();
        }

        private async void App_OnStartup(object sender, StartupEventArgs e) {
            await _host.StartAsync();

            _log = _host.Services.GetService<ILogger<App>>()!;
            var mainWindow = _host.Services.GetService<MainWindow>();

            if (mainWindow == null) {
                _log.LogCritical("MainWindow not resolvable via DI. Shutting down.");
                Shutdown();
            } else {
                mainWindow?.Show();
                _log.LogInformation("All services initialized.");
            }
        }

        private async void App_OnExit(object sender, ExitEventArgs e) {
            using (_host) {
                await _host.StopAsync(TimeSpan.FromSeconds(10));
            }
        }
    }
}