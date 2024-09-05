
using iText.Html2pdf;

Console.WriteLine("Aplicação Iniciada");
Console.WriteLine("Passe o caminho do Arquivo: ");

string caminhoDoArquivoHTML = @"";
string caminhoDoArquivoPDF = @""; 
if (File.Exists(caminhoDoArquivoHTML))
{
    using (FileStream htmlSource = File.Open(caminhoDoArquivoHTML, FileMode.Open))
    using (FileStream pdfDest = File.Open(caminhoDoArquivoPDF, FileMode.Create))
    {
        ConverterProperties converterProperties = new ConverterProperties();
        HtmlConverter.ConvertToPdf(htmlSource, pdfDest, converterProperties);
    }

}
   
 Console.WriteLine("Arquivo não encontrado");

