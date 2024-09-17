using ConsoleApp1.model;
using GrapeCity.Documents.Word;
using GrapeCity.Documents.Word.Layout;
using System.IO.Compression;

string FileName = Path.Combine(@"Template", "RentalAgreement[Template].docx");

// Initalize Word instance
var wordDoc = new GcWordDocument();
// Load DOCX file 
wordDoc.Load(FileName);


wordDoc.DataTemplate.DataSources.Add("landlordName", "ABC");
wordDoc.DataTemplate.DataSources.Add("landlordAddrLine1", "line 1 ");
wordDoc.DataTemplate.DataSources.Add("landlordAddrLine2", "line 2 ");
wordDoc.DataTemplate.DataSources.Add("landlordAddrCity", "dummy city");
wordDoc.DataTemplate.DataSources.Add("landlordAddrState", "dummy state");
wordDoc.DataTemplate.DataSources.Add("landlordAddrPostal", "dummy potalcode");
wordDoc.DataTemplate.DataSources.Add("landlordPhone", "1235468795");
wordDoc.DataTemplate.DataSources.Add("tenantName", "XYZ");
wordDoc.DataTemplate.DataSources.Add("tenantEmail", "XYZ@gmail.com");
wordDoc.DataTemplate.DataSources.Add("tenantPhone", "8521458762");
wordDoc.DataTemplate.DataSources.Add("tenantOccupants", "owner");
// Process data template based on the bindings in data source
wordDoc.DataTemplate.Process();


// Create an instance of the GcWordLayout
using (var layout = new GcWordLayout(wordDoc))
{
    // Define the PDF output settings
    PdfOutputSettings pdfOutputSettings = new PdfOutputSettings();
    pdfOutputSettings.CompressionLevel = CompressionLevel.Fastest;
    pdfOutputSettings.ConformanceLevel = GrapeCity.Documents.Pdf.PdfAConformanceLevel.PdfA1a;

    // Save the Word layout as a PDF
    layout.SaveAsPdf("ProcurementLetter.pdf", null, pdfOutputSettings);
}



///////////////////
/// List Data
///////////////////


for (int i = 0; i < Rentallist.objListData.Count; i++)
{
    // Initalize Word instance
    var wordDoc2 = new GcWordDocument();
    // Load DOCX file 
    wordDoc2.Load(FileName);
    wordDoc2.DataTemplate.DataSources.Add("landlordName", Rentallist.objListData[i].LandlordName);
    wordDoc2.DataTemplate.DataSources.Add("landlordAddrLine1", Rentallist.objListData[i].LandlordAddrLine1);
    wordDoc2.DataTemplate.DataSources.Add("landlordAddrLine2", Rentallist.objListData[i].LandlordAddrLine2);
    wordDoc2.DataTemplate.DataSources.Add("landlordAddrCity", Rentallist.objListData[i].LandlordAddrCity);
    wordDoc2.DataTemplate.DataSources.Add("landlordAddrState", Rentallist.objListData[i].LandlordAddrState);
    wordDoc2.DataTemplate.DataSources.Add("landlordAddrPostal", Rentallist.objListData[i].LandlordAddrPostal);
    wordDoc2.DataTemplate.DataSources.Add("landlordPhone", Rentallist.objListData[i].LandlordAddrPostal);
    wordDoc2.DataTemplate.DataSources.Add("tenantName", Rentallist.objListData[i].TenantName);
    wordDoc2.DataTemplate.DataSources.Add("tenantEmail", Rentallist.objListData[i].TenantEmail);
    wordDoc2.DataTemplate.DataSources.Add("tenantPhone", Rentallist.objListData[i].TenantPhone);
    wordDoc2.DataTemplate.DataSources.Add("tenantOccupants", Rentallist.objListData[i].TenantOccupants);
    // Process data template based on the bindings in data source
    wordDoc2.DataTemplate.Process();


    // Create an instance of the GcWordLayout
    using (var layout = new GcWordLayout(wordDoc2))
    {
        // Define the PDF output settings
        PdfOutputSettings pdfOutputSettings = new PdfOutputSettings();
        pdfOutputSettings.CompressionLevel = CompressionLevel.Fastest;
        pdfOutputSettings.ConformanceLevel = GrapeCity.Documents.Pdf.PdfAConformanceLevel.PdfA1a;

        // Save the Word layout as a PDF
        layout.SaveAsPdf("RentalAgreementLetterWith" + Rentallist.objListData[i].TenantName + ".pdf", null, pdfOutputSettings);
    }
}