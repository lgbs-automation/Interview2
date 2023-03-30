using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interview;

public sealed class Mailing
{
    public async void Send(string recipient, string subject, string body, string cc, string bcc,
        Credential credentials)
    {
        await Task.Run(async () =>
        {
            Console.WriteLine("Checking credentials...");
            var checker = new Checker();
            
            if (!checker.CheckCredential(credentials))
            {
                Console.WriteLine("Invalid credentials");
                return;
            }
            
            await Task.Delay(200);

            Console.WriteLine("Checking server connection...");

            await Task.Delay(100);

            Console.WriteLine("Adding attachments...");

            await Task.Delay(1000);
            
            Console.WriteLine("Sending email to " + recipient + " with subject "
                              + subject + " and body " + body + " cc " + cc + " bcc " + bcc);
        });
    }
}