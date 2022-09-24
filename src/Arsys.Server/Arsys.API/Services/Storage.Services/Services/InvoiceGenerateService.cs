using Arsys.API.Services.Storage.Services.Interfaces;
using IronPdf;

namespace Arsys.API.Services.Storage.Services.Services
{
    public class InvoiceGenerateService : IInvoiceGenerateService
    {
        public void GenerateInvoice()
        {
            // Create a PDF from an existing HTML using C#
            var Renderer = new ChromePdfRenderer();
            using var PDF = Renderer.RenderHtmlFileAsPdf("Assets/MyHTML.html");
            PDF.SaveAs("MyPdf.pdf");
        }
    }
}
