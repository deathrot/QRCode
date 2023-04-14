using NUnit.Framework;

namespace DecoderTest
{
    public class SmokeTests
    {

        [Test]
        public void SmokeTest()
        {
            QRCodeDecoderLibrary.QRDecoder decoder = new();
            var result = decoder.ImageDecoder(SixLabors.ImageSharp.Image.Load("pass.png"));

            Assert.IsNotNull(result);

            result = decoder.ImageDecoder(SixLabors.ImageSharp.Image.Load("fail.jpg"));
            Assert.IsNull(result);
        }

        [Test]
        public void DecoderTest()
        {
            QRCodeDecoderLibrary.QRDecoder decoder = new ();
            var result = decoder.ImageDecoder(SixLabors.ImageSharp.Image.Load("pass.png"));

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Length == 1);
            var decodedResult = QRCodeDecoderLibrary.QRDecoder.ByteArrayToString(result[0]);
            Assert.AreEqual(decodedResult, "Bugs Bunny\n07/27/1940");
        }
    }

}