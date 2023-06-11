using IronOcr;
namespace Csharp_Text_Recognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ocr = new IronTesseract();
            using (var input = new OcrInput(@"C:\Users\filip\Downloads\(1º) Lynn Beagheal - SQL Use a Cabeça!-Alta Ebooks (2008).pdf"))
            {
                var result = ocr.Read(input);
                result.SaveAsTextFile(@"C:\Users\filip\OneDrive\Área de Trabalho\file.txt");
            }
        }
    }
}
