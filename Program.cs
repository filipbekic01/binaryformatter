using Aspose.PSD;
using Aspose.PSD.FileFormats.Psd;
using Aspose.PSD.ImageOptions;

using FileStream psdStream = new("Test.psd", FileMode.Open);
using FileStream outputFileStream = File.Create(("output.png"));

using PsdImage psd = (PsdImage)Image.Load(psdStream);
psd.Save(outputFileStream, new PsdOptions());
