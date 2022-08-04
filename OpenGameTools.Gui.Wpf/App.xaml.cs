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
using OpenGameTools.Gui.ViewModel;
using OpenGameTools.Gui.Wpf.ViewModel;
using ReactiveUI;
using Splat;
using Splat.Microsoft.Extensions.DependencyInjection;
using Splat.Microsoft.Extensions.Logging;

namespace OpenGameTools.Gui.Wpf {
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application {
        private readonly IHost _host;
        private ILogger<App> _log;

        public App() {
            _host = new HostBuilder()
                .ConfigureServices((context, services) => {
                    //Register splat and ReactiveUI
                    services.UseMicrosoftDependencyResolver();
                    var resolver = Locator.CurrentMutable;
                    resolver.InitializeSplat();
                    resolver.InitializeReactiveUI();

                    // Add services here
                    // TODO: Dynamic plugin discovery
                    services
                        .AddSingleton<IMainWindowViewModel, MainWindowViewModel>()
                        .AddSingleton<IViewFor<IMainWindowViewModel>, MainWindow>();
                })
                .ConfigureLogging(logging => {
                    // TODO: Make this read from settings
                    //logging.AddConsole();
                    logging.AddDebug();
                    logging.AddSplat();
                })
                .Build();

            //Set logger here
            _log = _host.Services.GetRequiredService<ILogger<App>>()!;

            //Re-register splat
            _host.Services.UseMicrosoftDependencyResolver();
        }

        private async void App_OnStartup(object sender, StartupEventArgs e) {
            await _host.StartAsync();

            if (_host.Services.GetRequiredService<IViewFor<IMainWindowViewModel>>() is not Window mainWindow) {
                _log.LogCritical("MainWindow not resolvable via DI. Shutting down.");
                Shutdown();
            }
            else {
                mainWindow.Show();
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