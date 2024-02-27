using AppControleFinanceiro.Repositories;
using LiteDB;
using Microsoft.Extensions.Logging;

namespace AppControleFinanceiro
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder.Services
                .AddSingleton<LiteDatabase>(
                opts => 
                {
                    return new LiteDatabase($"Filename={AppSettings.StringConnection};Connection=Shared");
                });

            builder.Services.AddTransient<ITransactionRepository, TransactionRepository>();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
#
            builder.Logging.AddDebug();

            return builder.Build();
        }
    }
}
