using QRCodeDecoderLibrary;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class QRCodeDecoderExtensions
    {
        public static IServiceCollection AddQRCodeDecoder(this IServiceCollection services)
        {
            return services.AddTransient<QRDecoder>();
        }

        public static IServiceCollection AddQRCodeDecoderFactory(this IServiceCollection services)
        {
            return services.AddSingleton<IQRDecoderFactory, QRDecoderFactory>();
        }
    }
}