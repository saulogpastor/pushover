using System.IO;
using System;
using System.Net;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        var parameters = new NameValueCollection {
            { "token", "APP_TOKEN" },
            { "user", "USER_KEY" },
            { "message", "hello world" }
        };

        using (var client = new WebClient())
            client.UploadValues("https://api.pushover.net/1/messages.json", parameters);
    }
}
