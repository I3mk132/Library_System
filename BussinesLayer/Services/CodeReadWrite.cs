using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ZXing;
using System.Runtime.InteropServices;
using ZXing.Common;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using DataLayer;

namespace BussinesLayer
{
    public class clsCodeReadWrite
    {
        public static Bitmap WriteQrCode(string text, int Size, int Margin = 1)
        {
            if (string.IsNullOrEmpty(text))
                return null;

            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.QR_CODE,
                Options = new ZXing.Common.EncodingOptions
                {
                    Width = Size,
                    Height = Size,
                    Margin = Margin
                }
            };

            return writer.Write(text);

        }
        public static string ReadQrCode(Bitmap Image)
        {
            if (Image == null) 
                return null;

            BarcodeReader reader = new BarcodeReader
            {
                AutoRotate = true,
                Options = new DecodingOptions
                {
                    PossibleFormats = new[] { BarcodeFormat.QR_CODE }
                }
            };
            var result = reader.Decode(Image);

            return (result == null ? null : result.Text);
        } 
        public static Bitmap WriteBarcode(string text, int Width, int Height, int Margin = 1)
        {
            BarcodeWriter writer = new BarcodeWriter
            {
                Format = BarcodeFormat.EAN_13,
                Options = new EncodingOptions
                {
                    Width = Width,
                    Height = Height,
                    Margin = Margin,
                    PureBarcode = false
                }
            };

            return writer.Write(text);
        }
        public static string ReadBarcode(Bitmap Image)
        {
            if (Image == null)
                return null;

            BarcodeReader reader = new BarcodeReader
            {
                AutoRotate = true,
                Options = new DecodingOptions
                {
                    PossibleFormats = new[] {BarcodeFormat.EAN_13}
                }
            };
            var result = reader.Decode(Image);

            return result == null ? null : result.Text;
        }

        public static clsBookInfo GetBookDataByISBN(string ISBN)
        {
            string url = $"https://openlibrary.org/api/books?bibkeys=ISBN:{ISBN}&format=json&jscmd=data";


            HttpClient client = new HttpClient();
            clsBookInfo book = new clsBookInfo();
            try
            { 
            string response = client.GetStringAsync(url).Result;

            JObject json = JObject.Parse(response);
            var BookKey = "ISBN:" + ISBN;

            if (!json.ContainsKey(BookKey)) 
            { 
                return null; 
            }
            
            var data = json[BookKey];

            
            book.Title = data["title"]?.ToString();

            // Get first author only (for simplicity)
            if (data["authors"] != null && data["authors"].HasValues)
                book.Author = data["authors"][0]["name"]?.ToString();

            string dateStr = data["publish_date"]?.ToString();
            if (DateTime.TryParse(dateStr, out DateTime parsedDate))
                book.PublicationDate = parsedDate;
            else
                book.PublicationDate = DateTime.Now.AddDays(-1); // fallback


            // Get first subject as genre
            if (data["subjects"] != null && data["subjects"].HasValues)
                book.Genre = data["subjects"][0]["name"]?.ToString();

            // Description or notes
            book.Details = data["notes"]?.ToString() ?? "";

            // Cover image
            if (data["cover"] != null)
                book.ImagePath = data["cover"]["medium"]?.ToString();

            
            }
            catch { }
            
            return book;    
        }
        public static clsBookInfo GetBookDataByISBNBarcode(Bitmap Image)
        {
            return GetBookDataByISBN(ReadBarcode(Image));
        }
        
    }
}
