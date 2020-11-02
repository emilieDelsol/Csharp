using System;
using System.Net;

namespace queteAPI
{
    class Program
    {
        
        public static void Main()
        {
            WebClient client = new WebClient();

            String response = client.DownloadString("http://google.com");

            Console.WriteLine(response);
        }
    }
    
}
