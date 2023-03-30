using Interview;

var credentials = new GetCredentials().Get().Result;

if (credentials.Equals(null))
{
    throw new Exception("No credentials");
}

var user_names = new Service().Run(); //get names from DB
var together = user_names.Order().Where(n => n.StartsWith("J")).Select(n => new
{ name = n,
    body = "Hello " + n + "this is the rest of the e-mail body"});

foreach (var n in together)
{
    Mailing mail = new Mailing();
    mail.Send(n.name, "Subject", n.body, "cc", "bcc", credentials);
    
}