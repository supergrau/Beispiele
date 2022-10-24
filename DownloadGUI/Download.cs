using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownloadGUI
{
    internal class Download
    {

        /// <summary>
        /// Lädt die im Link genannten Ressource herunter
        /// </summary>
        /// <param name="link">Link zur Ressorce im Netz</param>
        /// <param name="msg">Mitteilung im Fehlerfall</param>
        /// <returns>True im Erfolgsfall</returns>
        static public bool ResDownload(string link, out string msg)
        {
            Uri url = new Uri(link);
            try
            {
                using (System.Net.WebClient client = new System.Net.WebClient())
                {
                    string filename = url.Segments[url.Segments.Length - 1];
                    //Console.WriteLine($"Lade {filename} herunter");
                    client.DownloadFile(url, filename);
                }
                msg = "";
                return true;
            }
            catch (Exception e)
            {
                // Console.WriteLine($"Datei {link}: \n {e.Message}");
                msg = e.Message;
                return false;
            }
        }

    }
}
