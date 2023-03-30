namespace Interview;

public sealed class Checker
{
    public bool CheckCredential(Credential credential)
    {
        return credential is 
            { Password: "Password", userName: "User" };
    }
}