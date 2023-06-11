using IronOcr;
namespace Csharp_Text_Recognizer
{
    class Program
    {
        static void Main(string[] args)
        {
            var ocr = new IronTesseract();
            using (var input = new OcrInput(@"Image-path"))
            {
                var result = ocr.Read(input);
                result.SaveAsTextFile(@"Output-path");
            }
        }
    }
}
