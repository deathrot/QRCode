using System;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace QRCodeDecoderLibrary
{
    public interface IQRDecoderFactory
    {
        QRDecoder CreateQRDecoder();
    }

    public class QRDecoderFactory : IQRDecoderFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public QRDecoderFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public QRDecoder CreateQRDecoder()
        {
            var logger = _serviceProvider.GetRequiredService<ILogger<QRDecoder>>();
            return new QRDecoder(logger);
        }
    }
}
