using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace TraversalCoreProje.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/"+"dosya1.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();

            Paragraph paragraph = new Paragraph("Treversal Rezervasyon Pdf Raporu");
            document.Add(paragraph);
            document.Close();
            return File("/PdfReports/dosya1.pdf","application/pdf","dosya1.pdf");
        }

        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya2.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfPTable = new PdfPTable(3);
            pdfPTable.AddCell("Misafir Adı");
            pdfPTable.AddCell("Misafir Soyadı");
            pdfPTable.AddCell("Misafir TC");

            pdfPTable.AddCell("Eylül");
            pdfPTable.AddCell("Yücedağ");
            pdfPTable.AddCell("12345433454");

            pdfPTable.AddCell("Kemal");
            pdfPTable.AddCell("Yıldız");
            pdfPTable.AddCell("52345433454");

            pdfPTable.AddCell("Mehmet");
            pdfPTable.AddCell("Yıldız");
            pdfPTable.AddCell("654342523423");
            document.Add(pdfPTable);
            document.Close();
            return File("/PdfReports/dosya2.pdf", "application/pdf", "dosya2.pdf");

        }
    }
}
