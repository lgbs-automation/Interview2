namespace Interview;

public sealed class GetCredentials
{
    public async Task<Credential?> Get()
    {
        var random = new Random();
        var user_name = "User";
        var password = "Password";

        if (random.Next(0,5) > 3)
        {
            return null;
        }
        
        return await Task.FromResult(new Credential
        {
            userName = user_name,
            Password = password
        });
    }
}