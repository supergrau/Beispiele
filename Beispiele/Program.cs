using System.Net;

namespace Beispiele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> linklist = new List<string>();
            string msg = "";
            linklist.Add("https://lincont.de/Programmieren_lernen.pdf");
            linklist.Add("https://lincont.de/EinstiegCSharp.pdf");
            linklist.Add("https://aaaaaaa.de/test.txt");
            
            foreach(string l in linklist)
            {
                Console.WriteLine($"Download: {l}");
                if (!Download(l, out msg))
                {
                    Console.WriteLine($@"Download fehlgeschlagen: {msg}");
                }

            }
            Console.WriteLine("erledigt");
        }

        /// <summary>
        /// Lädt die im Link genannten Ressource herunter
        /// </summary>
        /// <param name="link">Link zur Ressorce im Netz</param>
        /// <param name="msg">Mitteilung im Fehlerfall</param>
        /// <returns>True im Erfolgsfall</returns>
        static bool Download(string link, out string msg)
        {
            Uri url = new Uri(link);
            try { 
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    string filename = url.Segments[url.Segments.Length - 1];
                    //Console.WriteLine($"Lade {filename} herunter");
                    client.DownloadFile(url, filename);
                }
                msg = "";
                return true;
            } catch (Exception e) 
            {
                // Console.WriteLine($"Datei {link}: \n {e.Message}");
                msg = e.Message;
                return false;
            }
        }








        //static async void Download()
        //{
        //    Console.WriteLine("Start...");

        //    var httpClient = new HttpClient();

        //    using (var stream = await httpClient.GetStreamAsync("https://via.placeholder.com/300.png"))
        //    {
        //        using (var fileStream = new FileStream("300.png", FileMode.CreateNew))
        //        {
        //            await stream.CopyToAsync(fileStream);
        //        }
        //    }
        //    Console.WriteLine("Ende...");
        //}
    }
}